
namespace AP8PO_Projekt
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.refreshEmployeeDGV = new System.Windows.Forms.Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.personalPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.workPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.loadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IsDoctorandCheckbox = new System.Windows.Forms.CheckBox();
            this.personalEmailTextBox = new System.Windows.Forms.TextBox();
            this.workEmailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.harness = new System.Windows.Forms.Label();
            this.private_email = new System.Windows.Forms.Label();
            this.work_email = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fieldTab = new System.Windows.Forms.TabPage();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.groupLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.gradeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.typeOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.formOfStudyComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfStudentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.groupNameShortTextBox = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.subjectTab = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.guarantorInstituteComboBox = new System.Windows.Forms.ComboBox();
            this.creditsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Label11 = new System.Windows.Forms.Label();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.subjectLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.formOfCompletionComboBox = new System.Windows.Forms.ComboBox();
            this.classSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seminarHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.practiceHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lectureHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfWeeksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.subjectNameShortTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.subject_shortcut = new System.Windows.Forms.Label();
            this.scheduleAction = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scheduleActionsListBox = new System.Windows.Forms.ListBox();
            this.employeesGroupBox = new System.Windows.Forms.GroupBox();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabs.SuspendLayout();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadNumericUpDown)).BeginInit();
            this.fieldTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).BeginInit();
            this.subjectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWeeksNumericUpDown)).BeginInit();
            this.scheduleAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.employeesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.employeeTab);
            this.tabs.Controls.Add(this.fieldTab);
            this.tabs.Controls.Add(this.subjectTab);
            this.tabs.Controls.Add(this.scheduleAction);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1232, 463);
            this.tabs.TabIndex = 1;
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.refreshEmployeeDGV);
            this.employeeTab.Controls.Add(this.employeeDataGridView);
            this.employeeTab.Controls.Add(this.label21);
            this.employeeTab.Controls.Add(this.label20);
            this.employeeTab.Controls.Add(this.personalPhoneNumberTextBox);
            this.employeeTab.Controls.Add(this.workPhoneNumberTextBox);
            this.employeeTab.Controls.Add(this.loadNumericUpDown);
            this.employeeTab.Controls.Add(this.IsDoctorandCheckbox);
            this.employeeTab.Controls.Add(this.personalEmailTextBox);
            this.employeeTab.Controls.Add(this.workEmailTextBox);
            this.employeeTab.Controls.Add(this.lastNameTextBox);
            this.employeeTab.Controls.Add(this.addEmployeeButton);
            this.employeeTab.Controls.Add(this.harness);
            this.employeeTab.Controls.Add(this.private_email);
            this.employeeTab.Controls.Add(this.work_email);
            this.employeeTab.Controls.Add(this.last_name);
            this.employeeTab.Controls.Add(this.first_name);
            this.employeeTab.Controls.Add(this.firstNameTextBox);
            this.employeeTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employeeTab.Location = new System.Drawing.Point(4, 32);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(1224, 427);
            this.employeeTab.TabIndex = 0;
            this.employeeTab.Text = "Přidat zaměstnance";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // refreshEmployeeDGV
            // 
            this.refreshEmployeeDGV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshEmployeeDGV.Location = new System.Drawing.Point(432, 343);
            this.refreshEmployeeDGV.Name = "refreshEmployeeDGV";
            this.refreshEmployeeDGV.Size = new System.Drawing.Size(101, 72);
            this.refreshEmployeeDGV.TabIndex = 18;
            this.refreshEmployeeDGV.Text = "Obnovit tabulku";
            this.refreshEmployeeDGV.UseVisualStyleBackColor = true;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(540, 21);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 29;
            this.employeeDataGridView.Size = new System.Drawing.Size(676, 394);
            this.employeeDataGridView.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 28);
            this.label21.TabIndex = 16;
            this.label21.Text = "Soukromé tel. číslo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 182);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 28);
            this.label20.TabIndex = 15;
            this.label20.Text = "Pracovní tel. číslo";
            // 
            // personalPhoneNumberTextBox
            // 
            this.personalPhoneNumberTextBox.Location = new System.Drawing.Point(202, 222);
            this.personalPhoneNumberTextBox.Name = "personalPhoneNumberTextBox";
            this.personalPhoneNumberTextBox.Size = new System.Drawing.Size(331, 34);
            this.personalPhoneNumberTextBox.TabIndex = 14;
            this.personalPhoneNumberTextBox.TextChanged += new System.EventHandler(this.personalPhoneNumberTextBox_TextChanged);
            // 
            // workPhoneNumberTextBox
            // 
            this.workPhoneNumberTextBox.Location = new System.Drawing.Point(202, 182);
            this.workPhoneNumberTextBox.Name = "workPhoneNumberTextBox";
            this.workPhoneNumberTextBox.Size = new System.Drawing.Size(331, 34);
            this.workPhoneNumberTextBox.TabIndex = 13;
            this.workPhoneNumberTextBox.TextChanged += new System.EventHandler(this.workPhoneNumberTextBox_TextChanged);
            this.workPhoneNumberTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.workPhoneNumberTextBox_Validating);
            // 
            // loadNumericUpDown
            // 
            this.loadNumericUpDown.DecimalPlaces = 2;
            this.loadNumericUpDown.Location = new System.Drawing.Point(202, 262);
            this.loadNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loadNumericUpDown.Name = "loadNumericUpDown";
            this.loadNumericUpDown.Size = new System.Drawing.Size(222, 34);
            this.loadNumericUpDown.TabIndex = 12;
            // 
            // IsDoctorandCheckbox
            // 
            this.IsDoctorandCheckbox.AutoSize = true;
            this.IsDoctorandCheckbox.Location = new System.Drawing.Point(205, 305);
            this.IsDoctorandCheckbox.Name = "IsDoctorandCheckbox";
            this.IsDoctorandCheckbox.Size = new System.Drawing.Size(158, 32);
            this.IsDoctorandCheckbox.TabIndex = 11;
            this.IsDoctorandCheckbox.Text = "Je doktorand?";
            this.IsDoctorandCheckbox.UseVisualStyleBackColor = true;
            // 
            // personalEmailTextBox
            // 
            this.personalEmailTextBox.Location = new System.Drawing.Point(202, 141);
            this.personalEmailTextBox.Name = "personalEmailTextBox";
            this.personalEmailTextBox.Size = new System.Drawing.Size(331, 34);
            this.personalEmailTextBox.TabIndex = 10;
            this.personalEmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.personalEmailTextBox_Validating);
            // 
            // workEmailTextBox
            // 
            this.workEmailTextBox.Location = new System.Drawing.Point(202, 101);
            this.workEmailTextBox.Name = "workEmailTextBox";
            this.workEmailTextBox.Size = new System.Drawing.Size(331, 34);
            this.workEmailTextBox.TabIndex = 9;
            this.workEmailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.workEmailTextBox_Validating);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(202, 61);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(331, 34);
            this.lastNameTextBox.TabIndex = 8;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(8, 347);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(331, 72);
            this.addEmployeeButton.TabIndex = 7;
            this.addEmployeeButton.Text = "Přidat zaměstnance";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // harness
            // 
            this.harness.AutoSize = true;
            this.harness.Location = new System.Drawing.Point(23, 265);
            this.harness.Name = "harness";
            this.harness.Size = new System.Drawing.Size(75, 28);
            this.harness.TabIndex = 6;
            this.harness.Text = "Úvazek";
            // 
            // private_email
            // 
            this.private_email.AutoSize = true;
            this.private_email.Location = new System.Drawing.Point(23, 144);
            this.private_email.Name = "private_email";
            this.private_email.Size = new System.Drawing.Size(154, 28);
            this.private_email.TabIndex = 4;
            this.private_email.Text = "Soukromý email";
            // 
            // work_email
            // 
            this.work_email.AutoSize = true;
            this.work_email.Location = new System.Drawing.Point(23, 104);
            this.work_email.Name = "work_email";
            this.work_email.Size = new System.Drawing.Size(139, 28);
            this.work_email.TabIndex = 3;
            this.work_email.Text = "Pracovní email";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(23, 64);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(83, 28);
            this.last_name.TabIndex = 2;
            this.last_name.Text = "Příjmení";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(23, 24);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(69, 28);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "Jméno";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(203, 21);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(330, 34);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            // 
            // fieldTab
            // 
            this.fieldTab.Controls.Add(this.addGroupButton);
            this.fieldTab.Controls.Add(this.groupNameTextBox);
            this.fieldTab.Controls.Add(this.Label19);
            this.fieldTab.Controls.Add(this.groupLanguageComboBox);
            this.fieldTab.Controls.Add(this.gradeNumericUpDown);
            this.fieldTab.Controls.Add(this.typeOfStudyComboBox);
            this.fieldTab.Controls.Add(this.formOfStudyComboBox);
            this.fieldTab.Controls.Add(this.numberOfStudentsNumericUpDown);
            this.fieldTab.Controls.Add(this.semesterComboBox);
            this.fieldTab.Controls.Add(this.groupNameShortTextBox);
            this.fieldTab.Controls.Add(this.Label18);
            this.fieldTab.Controls.Add(this.Label17);
            this.fieldTab.Controls.Add(this.Label16);
            this.fieldTab.Controls.Add(this.Label15);
            this.fieldTab.Controls.Add(this.Label14);
            this.fieldTab.Controls.Add(this.Label13);
            this.fieldTab.Controls.Add(this.Label12);
            this.fieldTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fieldTab.Location = new System.Drawing.Point(4, 32);
            this.fieldTab.Name = "fieldTab";
            this.fieldTab.Padding = new System.Windows.Forms.Padding(3);
            this.fieldTab.Size = new System.Drawing.Size(1224, 427);
            this.fieldTab.TabIndex = 1;
            this.fieldTab.Text = "Přidat skupinu";
            this.fieldTab.UseVisualStyleBackColor = true;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Location = new System.Drawing.Point(332, 298);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(294, 72);
            this.addGroupButton.TabIndex = 16;
            this.addGroupButton.Text = "Přidat skupinu";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(460, 6);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(453, 34);
            this.groupNameTextBox.TabIndex = 15;
            this.groupNameTextBox.TextChanged += new System.EventHandler(this.groupNameTextBox_TextChanged);
            this.groupNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.groupNameTextBox_Validating);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(332, 12);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(125, 28);
            this.Label19.TabIndex = 14;
            this.Label19.Text = "Název oboru";
            // 
            // groupLanguageComboBox
            // 
            this.groupLanguageComboBox.FormattingEnabled = true;
            this.groupLanguageComboBox.Location = new System.Drawing.Point(661, 197);
            this.groupLanguageComboBox.Name = "groupLanguageComboBox";
            this.groupLanguageComboBox.Size = new System.Drawing.Size(252, 36);
            this.groupLanguageComboBox.TabIndex = 13;
            // 
            // gradeNumericUpDown
            // 
            this.gradeNumericUpDown.Location = new System.Drawing.Point(662, 134);
            this.gradeNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gradeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gradeNumericUpDown.Name = "gradeNumericUpDown";
            this.gradeNumericUpDown.Size = new System.Drawing.Size(251, 34);
            this.gradeNumericUpDown.TabIndex = 12;
            this.gradeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // typeOfStudyComboBox
            // 
            this.typeOfStudyComboBox.FormattingEnabled = true;
            this.typeOfStudyComboBox.Location = new System.Drawing.Point(662, 65);
            this.typeOfStudyComboBox.Name = "typeOfStudyComboBox";
            this.typeOfStudyComboBox.Size = new System.Drawing.Size(251, 36);
            this.typeOfStudyComboBox.TabIndex = 11;
            // 
            // formOfStudyComboBox
            // 
            this.formOfStudyComboBox.FormattingEnabled = true;
            this.formOfStudyComboBox.Location = new System.Drawing.Point(184, 199);
            this.formOfStudyComboBox.Name = "formOfStudyComboBox";
            this.formOfStudyComboBox.Size = new System.Drawing.Size(259, 36);
            this.formOfStudyComboBox.TabIndex = 10;
            // 
            // numberOfStudentsNumericUpDown
            // 
            this.numberOfStudentsNumericUpDown.Location = new System.Drawing.Point(184, 135);
            this.numberOfStudentsNumericUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numberOfStudentsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfStudentsNumericUpDown.Name = "numberOfStudentsNumericUpDown";
            this.numberOfStudentsNumericUpDown.Size = new System.Drawing.Size(259, 34);
            this.numberOfStudentsNumericUpDown.TabIndex = 9;
            this.numberOfStudentsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(184, 67);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(259, 36);
            this.semesterComboBox.TabIndex = 8;
            // 
            // groupNameShortTextBox
            // 
            this.groupNameShortTextBox.Location = new System.Drawing.Point(184, 6);
            this.groupNameShortTextBox.Name = "groupNameShortTextBox";
            this.groupNameShortTextBox.Size = new System.Drawing.Size(104, 34);
            this.groupNameShortTextBox.TabIndex = 7;
            this.groupNameShortTextBox.TextChanged += new System.EventHandler(this.groupNameShortTextBox_TextChanged);
            this.groupNameShortTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.groupNameShortTextBox_Validating);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(490, 203);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(58, 28);
            this.Label18.TabIndex = 6;
            this.Label18.Text = "Jazyk";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(490, 71);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(101, 28);
            this.Label17.TabIndex = 5;
            this.Label17.Text = "Typ studia";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(11, 205);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(126, 28);
            this.Label16.TabIndex = 4;
            this.Label16.Text = "Forma studia";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(11, 140);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(142, 28);
            this.Label15.TabIndex = 3;
            this.Label15.Text = "Počet studentů";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(11, 73);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(82, 28);
            this.Label14.TabIndex = 2;
            this.Label14.Text = "Semestr";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(490, 139);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 28);
            this.Label13.TabIndex = 1;
            this.Label13.Text = "Ročník";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(11, 12);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(136, 28);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Zkratka oboru";
            // 
            // subjectTab
            // 
            this.subjectTab.Controls.Add(this.label22);
            this.subjectTab.Controls.Add(this.guarantorInstituteComboBox);
            this.subjectTab.Controls.Add(this.creditsNumericUpDown);
            this.subjectTab.Controls.Add(this.Label11);
            this.subjectTab.Controls.Add(this.addSubjectButton);
            this.subjectTab.Controls.Add(this.Label9);
            this.subjectTab.Controls.Add(this.subjectNameTextBox);
            this.subjectTab.Controls.Add(this.Label8);
            this.subjectTab.Controls.Add(this.subjectLanguageComboBox);
            this.subjectTab.Controls.Add(this.formOfCompletionComboBox);
            this.subjectTab.Controls.Add(this.classSizeNumericUpDown);
            this.subjectTab.Controls.Add(this.seminarHoursNumericUpDown);
            this.subjectTab.Controls.Add(this.practiceHoursNumericUpDown);
            this.subjectTab.Controls.Add(this.lectureHoursNumericUpDown);
            this.subjectTab.Controls.Add(this.numberOfWeeksNumericUpDown);
            this.subjectTab.Controls.Add(this.subjectNameShortTextBox);
            this.subjectTab.Controls.Add(this.Label7);
            this.subjectTab.Controls.Add(this.Label6);
            this.subjectTab.Controls.Add(this.Label5);
            this.subjectTab.Controls.Add(this.Label1);
            this.subjectTab.Controls.Add(this.Label4);
            this.subjectTab.Controls.Add(this.Label3);
            this.subjectTab.Controls.Add(this.Label2);
            this.subjectTab.Controls.Add(this.subject_shortcut);
            this.subjectTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectTab.Location = new System.Drawing.Point(4, 32);
            this.subjectTab.Name = "subjectTab";
            this.subjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.subjectTab.Size = new System.Drawing.Size(1224, 427);
            this.subjectTab.TabIndex = 2;
            this.subjectTab.Text = "Přidat předmět";
            this.subjectTab.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(448, 236);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 28);
            this.label22.TabIndex = 25;
            this.label22.Text = "Ústav";
            // 
            // guarantorInstituteComboBox
            // 
            this.guarantorInstituteComboBox.FormattingEnabled = true;
            this.guarantorInstituteComboBox.Location = new System.Drawing.Point(619, 233);
            this.guarantorInstituteComboBox.Name = "guarantorInstituteComboBox";
            this.guarantorInstituteComboBox.Size = new System.Drawing.Size(294, 36);
            this.guarantorInstituteComboBox.TabIndex = 24;
            // 
            // creditsNumericUpDown
            // 
            this.creditsNumericUpDown.Location = new System.Drawing.Point(619, 191);
            this.creditsNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.creditsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.creditsNumericUpDown.Name = "creditsNumericUpDown";
            this.creditsNumericUpDown.Size = new System.Drawing.Size(294, 34);
            this.creditsNumericUpDown.TabIndex = 23;
            this.creditsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(448, 197);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(127, 28);
            this.Label11.TabIndex = 22;
            this.Label11.Text = "Počet kreditů";
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(619, 300);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(294, 72);
            this.addSubjectButton.TabIndex = 21;
            this.addSubjectButton.Text = "Přidat předmět";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(343, 90);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(0, 28);
            this.Label9.TabIndex = 19;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Location = new System.Drawing.Point(520, 9);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(393, 34);
            this.subjectNameTextBox.TabIndex = 17;
            this.subjectNameTextBox.TextChanged += new System.EventHandler(this.subjectNameTextBox_TextChanged);
            this.subjectNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.subjectNameTextBox_Validating);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(343, 15);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(157, 28);
            this.Label8.TabIndex = 16;
            this.Label8.Text = "Název předmětu";
            // 
            // subjectLanguageComboBox
            // 
            this.subjectLanguageComboBox.FormattingEnabled = true;
            this.subjectLanguageComboBox.Location = new System.Drawing.Point(619, 141);
            this.subjectLanguageComboBox.Name = "subjectLanguageComboBox";
            this.subjectLanguageComboBox.Size = new System.Drawing.Size(294, 36);
            this.subjectLanguageComboBox.TabIndex = 15;
            // 
            // formOfCompletionComboBox
            // 
            this.formOfCompletionComboBox.FormattingEnabled = true;
            this.formOfCompletionComboBox.Location = new System.Drawing.Point(619, 99);
            this.formOfCompletionComboBox.Name = "formOfCompletionComboBox";
            this.formOfCompletionComboBox.Size = new System.Drawing.Size(294, 36);
            this.formOfCompletionComboBox.TabIndex = 14;
            // 
            // classSizeNumericUpDown
            // 
            this.classSizeNumericUpDown.Location = new System.Drawing.Point(182, 254);
            this.classSizeNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.classSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classSizeNumericUpDown.Name = "classSizeNumericUpDown";
            this.classSizeNumericUpDown.Size = new System.Drawing.Size(242, 34);
            this.classSizeNumericUpDown.TabIndex = 13;
            this.classSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seminarHoursNumericUpDown
            // 
            this.seminarHoursNumericUpDown.Location = new System.Drawing.Point(182, 214);
            this.seminarHoursNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.seminarHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seminarHoursNumericUpDown.Name = "seminarHoursNumericUpDown";
            this.seminarHoursNumericUpDown.Size = new System.Drawing.Size(242, 34);
            this.seminarHoursNumericUpDown.TabIndex = 12;
            this.seminarHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // practiceHoursNumericUpDown
            // 
            this.practiceHoursNumericUpDown.Location = new System.Drawing.Point(182, 174);
            this.practiceHoursNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.practiceHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.practiceHoursNumericUpDown.Name = "practiceHoursNumericUpDown";
            this.practiceHoursNumericUpDown.Size = new System.Drawing.Size(242, 34);
            this.practiceHoursNumericUpDown.TabIndex = 11;
            this.practiceHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lectureHoursNumericUpDown
            // 
            this.lectureHoursNumericUpDown.Location = new System.Drawing.Point(182, 134);
            this.lectureHoursNumericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.lectureHoursNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lectureHoursNumericUpDown.Name = "lectureHoursNumericUpDown";
            this.lectureHoursNumericUpDown.Size = new System.Drawing.Size(242, 34);
            this.lectureHoursNumericUpDown.TabIndex = 10;
            this.lectureHoursNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfWeeksNumericUpDown
            // 
            this.numberOfWeeksNumericUpDown.Location = new System.Drawing.Point(182, 94);
            this.numberOfWeeksNumericUpDown.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numberOfWeeksNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfWeeksNumericUpDown.Name = "numberOfWeeksNumericUpDown";
            this.numberOfWeeksNumericUpDown.Size = new System.Drawing.Size(242, 34);
            this.numberOfWeeksNumericUpDown.TabIndex = 9;
            this.numberOfWeeksNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // subjectNameShortTextBox
            // 
            this.subjectNameShortTextBox.Location = new System.Drawing.Point(182, 9);
            this.subjectNameShortTextBox.Name = "subjectNameShortTextBox";
            this.subjectNameShortTextBox.Size = new System.Drawing.Size(126, 34);
            this.subjectNameShortTextBox.TabIndex = 8;
            this.subjectNameShortTextBox.TextChanged += new System.EventHandler(this.subjectNameShortTextBox_TextChanged);
            this.subjectNameShortTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.subjectNameShortTextBox_Validating);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 259);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(126, 28);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Velikost třídy";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(448, 147);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(58, 28);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Jazyk";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(446, 105);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(170, 28);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Způsob zakončení";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 219);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(160, 28);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Hodiny seminářů";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(11, 179);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(140, 28);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Hodiny cvičení";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 139);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(171, 28);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Hodiny přednášek";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 99);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 28);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Počet týdnů";
            // 
            // subject_shortcut
            // 
            this.subject_shortcut.AutoSize = true;
            this.subject_shortcut.Location = new System.Drawing.Point(11, 15);
            this.subject_shortcut.Name = "subject_shortcut";
            this.subject_shortcut.Size = new System.Drawing.Size(168, 28);
            this.subject_shortcut.TabIndex = 0;
            this.subject_shortcut.Text = "Zkratka předmětu";
            // 
            // scheduleAction
            // 
            this.scheduleAction.Controls.Add(this.groupBox1);
            this.scheduleAction.Controls.Add(this.employeesGroupBox);
            this.scheduleAction.Location = new System.Drawing.Point(4, 32);
            this.scheduleAction.Name = "scheduleAction";
            this.scheduleAction.Padding = new System.Windows.Forms.Padding(3);
            this.scheduleAction.Size = new System.Drawing.Size(1224, 427);
            this.scheduleAction.TabIndex = 3;
            this.scheduleAction.Text = "Předmět -> Skupina";
            this.scheduleAction.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scheduleActionsListBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 360);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rozvrhové akce";
            // 
            // scheduleActionsListBox
            // 
            this.scheduleActionsListBox.FormattingEnabled = true;
            this.scheduleActionsListBox.ItemHeight = 20;
            this.scheduleActionsListBox.Location = new System.Drawing.Point(5, 23);
            this.scheduleActionsListBox.Name = "scheduleActionsListBox";
            this.scheduleActionsListBox.Size = new System.Drawing.Size(435, 324);
            this.scheduleActionsListBox.TabIndex = 0;
            // 
            // employeesGroupBox
            // 
            this.employeesGroupBox.Controls.Add(this.employeesListBox);
            this.employeesGroupBox.Location = new System.Drawing.Point(455, 12);
            this.employeesGroupBox.Name = "employeesGroupBox";
            this.employeesGroupBox.Size = new System.Drawing.Size(458, 360);
            this.employeesGroupBox.TabIndex = 26;
            this.employeesGroupBox.TabStop = false;
            this.employeesGroupBox.Text = "Zaměstnanci";
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 20;
            this.employeesListBox.Location = new System.Drawing.Point(7, 20);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(445, 324);
            this.employeesListBox.TabIndex = 24;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeftChanged += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 463);
            this.Controls.Add(this.tabs);
            this.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.Name = "Form";
            this.Text = "AP8PO_Project";
            this.tabs.ResumeLayout(false);
            this.employeeTab.ResumeLayout(false);
            this.employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadNumericUpDown)).EndInit();
            this.fieldTab.ResumeLayout(false);
            this.fieldTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).EndInit();
            this.subjectTab.ResumeLayout(false);
            this.subjectTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seminarHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWeeksNumericUpDown)).EndInit();
            this.scheduleAction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.employeesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tabs;
        internal System.Windows.Forms.TabPage employeeTab;
        internal System.Windows.Forms.NumericUpDown loadNumericUpDown;
        internal System.Windows.Forms.CheckBox IsDoctorandCheckbox;
        internal System.Windows.Forms.TextBox personalEmailTextBox;
        internal System.Windows.Forms.TextBox workEmailTextBox;
        internal System.Windows.Forms.TextBox lastNameTextBox;
        internal System.Windows.Forms.Button addEmployeeButton;
        internal System.Windows.Forms.Label harness;
        internal System.Windows.Forms.Label private_email;
        internal System.Windows.Forms.Label work_email;
        internal System.Windows.Forms.Label last_name;
        internal System.Windows.Forms.Label first_name;
        internal System.Windows.Forms.TextBox firstNameTextBox;
        internal System.Windows.Forms.TabPage fieldTab;
        internal System.Windows.Forms.Button addGroupButton;
        internal System.Windows.Forms.TextBox groupNameTextBox;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.ComboBox groupLanguageComboBox;
        internal System.Windows.Forms.NumericUpDown gradeNumericUpDown;
        internal System.Windows.Forms.ComboBox typeOfStudyComboBox;
        internal System.Windows.Forms.ComboBox formOfStudyComboBox;
        internal System.Windows.Forms.NumericUpDown numberOfStudentsNumericUpDown;
        internal System.Windows.Forms.ComboBox semesterComboBox;
        internal System.Windows.Forms.TextBox groupNameShortTextBox;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TabPage subjectTab;
        internal System.Windows.Forms.NumericUpDown creditsNumericUpDown;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button addSubjectButton;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox subjectNameTextBox;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox subjectLanguageComboBox;
        internal System.Windows.Forms.ComboBox formOfCompletionComboBox;
        internal System.Windows.Forms.NumericUpDown classSizeNumericUpDown;
        internal System.Windows.Forms.NumericUpDown seminarHoursNumericUpDown;
        internal System.Windows.Forms.NumericUpDown practiceHoursNumericUpDown;
        internal System.Windows.Forms.NumericUpDown lectureHoursNumericUpDown;
        internal System.Windows.Forms.NumericUpDown numberOfWeeksNumericUpDown;
        internal System.Windows.Forms.TextBox subjectNameShortTextBox;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label subject_shortcut;
        internal System.Windows.Forms.TabPage scheduleAction;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox personalPhoneNumberTextBox;
        private System.Windows.Forms.TextBox workPhoneNumberTextBox;
        private System.Windows.Forms.Label label22;
        internal System.Windows.Forms.ComboBox guarantorInstituteComboBox;
        internal System.Windows.Forms.ListBox employeesListBox;
        internal System.Windows.Forms.NumericUpDown NumericUpDown;
        internal System.Windows.Forms.Button addGrou;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox scheduleActionsListBox;
        private System.Windows.Forms.GroupBox employeesGroupBox;
        internal System.Windows.Forms.ListBox emListBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button refreshEmployeeDGV;
    }
}

