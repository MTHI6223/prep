namespace LectureManagementSystem.ApplicationLogicLayer;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        rootLayout = new TableLayoutPanel();
        pnlHeader = new Panel();
        lblHeading = new Label();
        pnlContent = new Panel();
        dgvLectures = new DataGridView();
        colId = new DataGridViewTextBoxColumn();
        colCode = new DataGridViewTextBoxColumn();
        colTitle = new DataGridViewTextBoxColumn();
        colLecturer = new DataGridViewTextBoxColumn();
        colDepartment = new DataGridViewTextBoxColumn();
        colCredits = new DataGridViewTextBoxColumn();
        colSemester = new DataGridViewTextBoxColumn();
        colSchedule = new DataGridViewTextBoxColumn();
        pnlSearch = new Panel();
        btnSearch = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        pnlInput = new Panel();
        tblInput = new TableLayoutPanel();
        lblCode = new Label();
        txtCode = new TextBox();
        lblTitle = new Label();
        txtTitle = new TextBox();
        lblLecturer = new Label();
        txtLecturer = new TextBox();
        lblDepartment = new Label();
        cboDepartment = new ComboBox();
        lblCredits = new Label();
        nudCredits = new NumericUpDown();
        lblSemester = new Label();
        cboSemester = new ComboBox();
        lblSchedule = new Label();
        txtSchedule = new TextBox();
        pnlButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        btnRefresh = new Button();
        statusStrip = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        rootLayout.SuspendLayout();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvLectures).BeginInit();
        pnlSearch.SuspendLayout();
        pnlInput.SuspendLayout();
        tblInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudCredits).BeginInit();
        pnlButtons.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // rootLayout
        // 
        rootLayout.ColumnCount = 2;
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
        rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        rootLayout.Controls.Add(pnlHeader, 0, 0);
        rootLayout.Controls.Add(pnlInput, 0, 1);
        rootLayout.Controls.Add(pnlContent, 1, 1);
        rootLayout.Dock = DockStyle.Fill;
        rootLayout.Location = new Point(0, 0);
        rootLayout.Name = "rootLayout";
        rootLayout.RowCount = 2;
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.Size = new Size(1024, 613);
        rootLayout.TabIndex = 0;
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(30, 58, 95);
        rootLayout.SetColumnSpan(pnlHeader, 2);
        pnlHeader.Controls.Add(lblHeading);
        pnlHeader.Dock = DockStyle.Fill;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Margin = new Padding(0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(1024, 60);
        pnlHeader.TabIndex = 0;
        // 
        // lblHeading
        // 
        lblHeading.Dock = DockStyle.Fill;
        lblHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblHeading.ForeColor = Color.White;
        lblHeading.Location = new Point(0, 0);
        lblHeading.Name = "lblHeading";
        lblHeading.Padding = new Padding(24, 0, 0, 0);
        lblHeading.Size = new Size(1024, 60);
        lblHeading.TabIndex = 0;
        lblHeading.Text = "Lecture Management System";
        lblHeading.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlContent
        // 
        pnlContent.Controls.Add(dgvLectures);
        pnlContent.Controls.Add(pnlSearch);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(340, 60);
        pnlContent.Margin = new Padding(0);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(12, 12, 12, 12);
        pnlContent.Size = new Size(684, 553);
        pnlContent.TabIndex = 2;
        // 
        // dgvLectures
        // 
        dgvLectures.AllowUserToAddRows = false;
        dgvLectures.AllowUserToDeleteRows = false;
        dgvLectures.AllowUserToResizeRows = false;
        dgvLectures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvLectures.BackgroundColor = Color.White;
        dgvLectures.BorderStyle = BorderStyle.Fixed3D;
        dgvLectures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLectures.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colTitle, colLecturer, colDepartment, colCredits, colSemester, colSchedule });
        dgvLectures.Dock = DockStyle.Fill;
        dgvLectures.Location = new Point(12, 68);
        dgvLectures.MultiSelect = false;
        dgvLectures.Name = "dgvLectures";
        dgvLectures.ReadOnly = true;
        dgvLectures.RowHeadersVisible = false;
        dgvLectures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvLectures.Size = new Size(660, 473);
        dgvLectures.TabIndex = 1;
        // 
        // colId
        // 
        colId.DataPropertyName = "Id";
        colId.FillWeight = 30F;
        colId.HeaderText = "ID";
        colId.Name = "colId";
        colId.ReadOnly = true;
        // 
        // colCode
        // 
        colCode.DataPropertyName = "Code";
        colCode.FillWeight = 60F;
        colCode.HeaderText = "Code";
        colCode.Name = "colCode";
        colCode.ReadOnly = true;
        // 
        // colTitle
        // 
        colTitle.DataPropertyName = "Title";
        colTitle.FillWeight = 130F;
        colTitle.HeaderText = "Title";
        colTitle.Name = "colTitle";
        colTitle.ReadOnly = true;
        // 
        // colLecturer
        // 
        colLecturer.DataPropertyName = "LecturerName";
        colLecturer.FillWeight = 100F;
        colLecturer.HeaderText = "Lecturer";
        colLecturer.Name = "colLecturer";
        colLecturer.ReadOnly = true;
        // 
        // colDepartment
        // 
        colDepartment.DataPropertyName = "Department";
        colDepartment.FillWeight = 90F;
        colDepartment.HeaderText = "Department";
        colDepartment.Name = "colDepartment";
        colDepartment.ReadOnly = true;
        // 
        // colCredits
        // 
        colCredits.DataPropertyName = "Credits";
        colCredits.FillWeight = 40F;
        colCredits.HeaderText = "Credits";
        colCredits.Name = "colCredits";
        colCredits.ReadOnly = true;
        // 
        // colSemester
        // 
        colSemester.DataPropertyName = "Semester";
        colSemester.FillWeight = 55F;
        colSemester.HeaderText = "Semester";
        colSemester.Name = "colSemester";
        colSemester.ReadOnly = true;
        // 
        // colSchedule
        // 
        colSchedule.DataPropertyName = "Schedule";
        colSchedule.FillWeight = 90F;
        colSchedule.HeaderText = "Schedule";
        colSchedule.Name = "colSchedule";
        colSchedule.ReadOnly = true;
        // 
        // pnlSearch
        // 
        pnlSearch.Controls.Add(btnSearch);
        pnlSearch.Controls.Add(txtSearch);
        pnlSearch.Controls.Add(lblSearch);
        pnlSearch.Dock = DockStyle.Top;
        pnlSearch.Location = new Point(12, 12);
        pnlSearch.Name = "pnlSearch";
        pnlSearch.Size = new Size(660, 56);
        pnlSearch.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSearch.Location = new Point(558, 13);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(90, 30);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.Location = new Point(70, 15);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search by code, title, lecturer, department...";
        txtSearch.Size = new Size(470, 25);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(3, 19);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(45, 17);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Search:";
        // 
        // pnlInput
        // 
        pnlInput.BackColor = Color.FromArgb(247, 248, 250);
        pnlInput.Controls.Add(tblInput);
        pnlInput.Dock = DockStyle.Fill;
        pnlInput.Location = new Point(0, 60);
        pnlInput.Margin = new Padding(0);
        pnlInput.Name = "pnlInput";
        pnlInput.Padding = new Padding(12, 12, 12, 12);
        pnlInput.Size = new Size(340, 553);
        pnlInput.TabIndex = 1;
        // 
        // tblInput
        // 
        tblInput.ColumnCount = 2;
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
        tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tblInput.Controls.Add(lblCode, 0, 0);
        tblInput.Controls.Add(txtCode, 1, 0);
        tblInput.Controls.Add(lblTitle, 0, 1);
        tblInput.Controls.Add(txtTitle, 1, 1);
        tblInput.Controls.Add(lblLecturer, 0, 2);
        tblInput.Controls.Add(txtLecturer, 1, 2);
        tblInput.Controls.Add(lblDepartment, 0, 3);
        tblInput.Controls.Add(cboDepartment, 1, 3);
        tblInput.Controls.Add(lblCredits, 0, 4);
        tblInput.Controls.Add(nudCredits, 1, 4);
        tblInput.Controls.Add(lblSemester, 0, 5);
        tblInput.Controls.Add(cboSemester, 1, 5);
        tblInput.Controls.Add(lblSchedule, 0, 6);
        tblInput.Controls.Add(txtSchedule, 1, 6);
        tblInput.Controls.Add(pnlButtons, 0, 7);
        tblInput.Dock = DockStyle.Fill;
        tblInput.Location = new Point(12, 12);
        tblInput.Name = "tblInput";
        tblInput.RowCount = 8;
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tblInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tblInput.Size = new Size(316, 529);
        tblInput.TabIndex = 0;
        // 
        // lblCode
        // 
        lblCode.Dock = DockStyle.Fill;
        lblCode.Location = new Point(3, 0);
        lblCode.Name = "lblCode";
        lblCode.Size = new Size(90, 40);
        lblCode.TabIndex = 0;
        lblCode.Text = "Code";
        lblCode.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtCode
        // 
        txtCode.Dock = DockStyle.Fill;
        txtCode.Location = new Point(99, 6);
        txtCode.Margin = new Padding(3, 6, 3, 6);
        txtCode.Name = "txtCode";
        txtCode.Size = new Size(214, 25);
        txtCode.TabIndex = 1;
        // 
        // lblTitle
        // 
        lblTitle.Dock = DockStyle.Fill;
        lblTitle.Location = new Point(3, 40);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(90, 40);
        lblTitle.TabIndex = 2;
        lblTitle.Text = "Title";
        lblTitle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtTitle
        // 
        txtTitle.Dock = DockStyle.Fill;
        txtTitle.Location = new Point(99, 46);
        txtTitle.Margin = new Padding(3, 6, 3, 6);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new Size(214, 25);
        txtTitle.TabIndex = 3;
        // 
        // lblLecturer
        // 
        lblLecturer.Dock = DockStyle.Fill;
        lblLecturer.Location = new Point(3, 80);
        lblLecturer.Name = "lblLecturer";
        lblLecturer.Size = new Size(90, 40);
        lblLecturer.TabIndex = 4;
        lblLecturer.Text = "Lecturer";
        lblLecturer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtLecturer
        // 
        txtLecturer.Dock = DockStyle.Fill;
        txtLecturer.Location = new Point(99, 86);
        txtLecturer.Margin = new Padding(3, 6, 3, 6);
        txtLecturer.Name = "txtLecturer";
        txtLecturer.Size = new Size(214, 25);
        txtLecturer.TabIndex = 5;
        // 
        // lblDepartment
        // 
        lblDepartment.Dock = DockStyle.Fill;
        lblDepartment.Location = new Point(3, 120);
        lblDepartment.Name = "lblDepartment";
        lblDepartment.Size = new Size(90, 40);
        lblDepartment.TabIndex = 6;
        lblDepartment.Text = "Department";
        lblDepartment.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cboDepartment
        // 
        cboDepartment.Dock = DockStyle.Fill;
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDown;
        cboDepartment.Location = new Point(99, 126);
        cboDepartment.Margin = new Padding(3, 6, 3, 6);
        cboDepartment.Name = "cboDepartment";
        cboDepartment.Size = new Size(214, 25);
        cboDepartment.TabIndex = 7;
        // 
        // lblCredits
        // 
        lblCredits.Dock = DockStyle.Fill;
        lblCredits.Location = new Point(3, 160);
        lblCredits.Name = "lblCredits";
        lblCredits.Size = new Size(90, 40);
        lblCredits.TabIndex = 8;
        lblCredits.Text = "Credits";
        lblCredits.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // nudCredits
        // 
        nudCredits.Dock = DockStyle.Fill;
        nudCredits.Location = new Point(99, 166);
        nudCredits.Margin = new Padding(3, 6, 3, 6);
        nudCredits.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        nudCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudCredits.Name = "nudCredits";
        nudCredits.Size = new Size(214, 25);
        nudCredits.TabIndex = 9;
        nudCredits.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblSemester
        // 
        lblSemester.Dock = DockStyle.Fill;
        lblSemester.Location = new Point(3, 200);
        lblSemester.Name = "lblSemester";
        lblSemester.Size = new Size(90, 40);
        lblSemester.TabIndex = 10;
        lblSemester.Text = "Semester";
        lblSemester.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // cboSemester
        // 
        cboSemester.Dock = DockStyle.Fill;
        cboSemester.DropDownStyle = ComboBoxStyle.DropDownList;
        cboSemester.Location = new Point(99, 206);
        cboSemester.Margin = new Padding(3, 6, 3, 6);
        cboSemester.Name = "cboSemester";
        cboSemester.Size = new Size(214, 25);
        cboSemester.TabIndex = 11;
        // 
        // lblSchedule
        // 
        lblSchedule.Dock = DockStyle.Fill;
        lblSchedule.Location = new Point(3, 240);
        lblSchedule.Name = "lblSchedule";
        lblSchedule.Size = new Size(90, 40);
        lblSchedule.TabIndex = 12;
        lblSchedule.Text = "Schedule";
        lblSchedule.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtSchedule
        // 
        txtSchedule.Dock = DockStyle.Fill;
        txtSchedule.Location = new Point(99, 246);
        txtSchedule.Margin = new Padding(3, 6, 3, 6);
        txtSchedule.Name = "txtSchedule";
        txtSchedule.Size = new Size(214, 25);
        txtSchedule.TabIndex = 13;
        // 
        // pnlButtons
        // 
        pnlButtons.AutoScroll = true;
        tblInput.SetColumnSpan(pnlButtons, 2);
        pnlButtons.Controls.Add(btnAdd);
        pnlButtons.Controls.Add(btnUpdate);
        pnlButtons.Controls.Add(btnDelete);
        pnlButtons.Controls.Add(btnClear);
        pnlButtons.Controls.Add(btnRefresh);
        pnlButtons.Dock = DockStyle.Fill;
        pnlButtons.Location = new Point(3, 283);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Padding = new Padding(0, 12, 0, 0);
        pnlButtons.Size = new Size(310, 243);
        pnlButtons.TabIndex = 14;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = Color.FromArgb(22, 101, 52);
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.ForeColor = Color.White;
        btnAdd.Location = new Point(3, 15);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(94, 36);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = false;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.FromArgb(30, 64, 175);
        btnUpdate.FlatStyle = FlatStyle.Flat;
        btnUpdate.ForeColor = Color.White;
        btnUpdate.Location = new Point(103, 15);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(94, 36);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.FromArgb(153, 27, 27);
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.White;
        btnDelete.Location = new Point(203, 15);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(94, 36);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(3, 57);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(94, 36);
        btnClear.TabIndex = 3;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = true;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(103, 57);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(94, 36);
        btnRefresh.TabIndex = 4;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip.Location = new Point(0, 613);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1024, 22);
        statusStrip.TabIndex = 1;
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(39, 17);
        lblStatus.Text = "Ready";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 635);
        Controls.Add(rootLayout);
        Controls.Add(statusStrip);
        Font = new Font("Segoe UI", 9.75F);
        MinimumSize = new Size(900, 560);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lecture Management System";
        rootLayout.ResumeLayout(false);
        pnlHeader.ResumeLayout(false);
        pnlContent.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvLectures).EndInit();
        pnlSearch.ResumeLayout(false);
        pnlSearch.PerformLayout();
        pnlInput.ResumeLayout(false);
        tblInput.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudCredits).EndInit();
        pnlButtons.ResumeLayout(false);
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel rootLayout = null!;
    private Panel pnlHeader = null!;
    private Label lblHeading = null!;
    private Panel pnlContent = null!;
    private DataGridView dgvLectures = null!;
    private DataGridViewTextBoxColumn colId = null!;
    private DataGridViewTextBoxColumn colCode = null!;
    private DataGridViewTextBoxColumn colTitle = null!;
    private DataGridViewTextBoxColumn colLecturer = null!;
    private DataGridViewTextBoxColumn colDepartment = null!;
    private DataGridViewTextBoxColumn colCredits = null!;
    private DataGridViewTextBoxColumn colSemester = null!;
    private DataGridViewTextBoxColumn colSchedule = null!;
    private Panel pnlSearch = null!;
    private Button btnSearch = null!;
    private TextBox txtSearch = null!;
    private Label lblSearch = null!;
    private Panel pnlInput = null!;
    private TableLayoutPanel tblInput = null!;
    private Label lblCode = null!;
    private TextBox txtCode = null!;
    private Label lblTitle = null!;
    private TextBox txtTitle = null!;
    private Label lblLecturer = null!;
    private TextBox txtLecturer = null!;
    private Label lblDepartment = null!;
    private ComboBox cboDepartment = null!;
    private Label lblCredits = null!;
    private NumericUpDown nudCredits = null!;
    private Label lblSemester = null!;
    private ComboBox cboSemester = null!;
    private Label lblSchedule = null!;
    private TextBox txtSchedule = null!;
    private FlowLayoutPanel pnlButtons = null!;
    private Button btnAdd = null!;
    private Button btnUpdate = null!;
    private Button btnDelete = null!;
    private Button btnClear = null!;
    private Button btnRefresh = null!;
    private StatusStrip statusStrip = null!;
    private ToolStripStatusLabel lblStatus = null!;
}
