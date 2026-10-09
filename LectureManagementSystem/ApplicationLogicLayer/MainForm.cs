using LectureManagementSystem.BusinessLogicLayer;
using LectureManagementSystem.DatabaseLogicLayer;

namespace LectureManagementSystem.ApplicationLogicLayer;

/// <summary>
/// Application Logic Layer - the Windows Forms user interface.
/// It only talks to the Business Logic Layer (<see cref="LectureService"/>);
/// it never builds SQL itself.
/// </summary>
public partial class MainForm : Form
{
    private readonly LectureService _service = new();
    private readonly BindingSource _bindingSource = new();
    private bool _suppressSelection;

    public MainForm()
    {
        InitializeComponent();
        WireUpEvents();
        LoadLookups();
        dgvLectures.DataSource = _bindingSource;
    }

    private void WireUpEvents()
    {
        Load += MainForm_Load;
        btnAdd.Click += BtnAdd_Click;
        btnUpdate.Click += BtnUpdate_Click;
        btnDelete.Click += BtnDelete_Click;
        btnClear.Click += (_, _) => ClearInputs();
        btnRefresh.Click += (_, _) => LoadLectures();
        btnSearch.Click += (_, _) => RunSearch();
        txtSearch.KeyDown += TxtSearch_KeyDown;
        dgvLectures.SelectionChanged += DgvLectures_SelectionChanged;
    }

    private void LoadLookups()
    {
        cboDepartment.Items.AddRange(new object[]
        {
            "Computer Science", "Information Technology", "Mathematics", "Physics", "Business"
        });

        cboSemester.Items.AddRange(new object[] { "Semester 1", "Semester 2" });
        cboSemester.SelectedIndex = 0;
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        if (!Db.TestConnection(out var error))
        {
            SetStatus("Database not reachable.");
            MessageBox.Show(
                "Could not connect to the database." + Environment.NewLine +
                "Run the Database/Setup.sql script first, then check the connection string in Db.cs." +
                Environment.NewLine + Environment.NewLine + error,
                "Database connection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        LoadLectures();
    }

    private void LoadLectures()
    {
        try
        {
            _bindingSource.DataSource = _service.GetAll();
            SetStatus($"{_bindingSource.Count} lecture(s) loaded.");
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }

    private void RunSearch()
    {
        try
        {
            _bindingSource.DataSource = _service.Search(txtSearch.Text);
            SetStatus($"{_bindingSource.Count} result(s) for \"{txtSearch.Text}\".");
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }

    private void TxtSearch_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            RunSearch();
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        try
        {
            var lecture = ReadInputs();
            var newId = _service.Add(lecture);
            LoadLectures();
            SelectById(newId);
            SetStatus($"Lecture \"{lecture.Title}\" added.");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (GetSelectedLecture() is not { } selected)
        {
            MessageBox.Show("Select a lecture in the grid first.", "Update",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            var lecture = ReadInputs();
            lecture.Id = selected.Id;
            _service.Update(lecture);
            LoadLectures();
            SelectById(lecture.Id);
            SetStatus($"Lecture \"{lecture.Title}\" updated.");
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (GetSelectedLecture() is not { } selected)
        {
            MessageBox.Show("Select a lecture in the grid first.", "Delete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var confirm = MessageBox.Show(
            $"Delete lecture \"{selected.Title}\"?",
            "Confirm delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        try
        {
            _service.Delete(selected.Id);
            ClearInputs();
            LoadLectures();
            SetStatus("Lecture deleted.");
        }
        catch (Exception ex)
        {
            ShowError(ex);
        }
    }

    private void DgvLectures_SelectionChanged(object? sender, EventArgs e)
    {
        if (_suppressSelection || GetSelectedLecture() is not { } selected)
        {
            return;
        }

        WriteInputs(selected);
    }

    private Lecture ReadInputs() => new()
    {
        Code = txtCode.Text.Trim(),
        Title = txtTitle.Text.Trim(),
        LecturerName = txtLecturer.Text.Trim(),
        Department = cboDepartment.Text.Trim(),
        Credits = (int)nudCredits.Value,
        Semester = cboSemester.Text.Trim(),
        Schedule = txtSchedule.Text.Trim()
    };

    private void WriteInputs(Lecture lecture)
    {
        txtCode.Text = lecture.Code;
        txtTitle.Text = lecture.Title;
        txtLecturer.Text = lecture.LecturerName;
        cboDepartment.Text = lecture.Department;
        nudCredits.Value = Math.Clamp(lecture.Credits, (int)nudCredits.Minimum, (int)nudCredits.Maximum);
        cboSemester.Text = lecture.Semester;
        txtSchedule.Text = lecture.Schedule;
    }

    private void ClearInputs()
    {
        _suppressSelection = true;
        txtCode.Clear();
        txtTitle.Clear();
        txtLecturer.Clear();
        cboDepartment.SelectedIndex = -1;
        cboDepartment.Text = string.Empty;
        nudCredits.Value = nudCredits.Minimum;
        cboSemester.SelectedIndex = 0;
        txtSchedule.Clear();
        dgvLectures.ClearSelection();
        _suppressSelection = false;
        txtCode.Focus();
    }

    private void SelectById(int id)
    {
        foreach (DataGridViewRow row in dgvLectures.Rows)
        {
            if (row.DataBoundItem is Lecture lecture && lecture.Id == id)
            {
                row.Selected = true;
                dgvLectures.CurrentCell = row.Cells[0];
                break;
            }
        }
    }

    private Lecture? GetSelectedLecture() =>
        dgvLectures.CurrentRow?.DataBoundItem as Lecture;

    private void ShowError(Exception ex)
    {
        SetStatus("Operation failed.");
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void SetStatus(string message) => lblStatus.Text = message;
}
