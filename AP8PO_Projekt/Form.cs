using AP8PO_Projekt.Models;
using ClassLibrary;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace AP8PO_Projekt
{
    public partial class Form : System.Windows.Forms.Form
    {
        #region Variables
        string oldFirstName = string.Empty;
        string oldLastName = string.Empty;
        string oldWorkPhone = string.Empty;
        string oldPersonalPhone = string.Empty;
        bool isFirstNameValid = false;
        bool isLastNameValid = false;
        bool isWorkPhoneValid = false;
        bool isWorkEmailValid = false;
        bool isPersonalEmailValid = true;

        string oldGroupNameShort = string.Empty;
        string oldGroupName = string.Empty;
        bool isGroupNameShortValid = false;
        bool isGroupNameValid = false;

        string oldSubjectNameShort = string.Empty;
        string oldSubjectName = string.Empty;
        bool isSubjectNameShortValid = false;
        bool isSubjectNameValid = false;
        #endregion

        #region Lists
        private List<string> groupsColsNames = new List<string>
        {
            "Id", "Název", "Zkratka", "Ročník", "Semestr",
            "Počet studentů", "Forma studia", "Typ studia", "Jazyk"
        };

        private List<string> employeesColsNames = new List<string>
        {
            "Id", "Jméno", "Příjmení", "Pracovní email", "Osobní email",
            "Pracovní tel. číslo", "Osobní tel. číslo", "Je doktorand?", "Úvazek", ""
        };

        private List<string> subjectsColsNames = new List<string>
        {
            "Id", "Název", "Zkratka", "Počet týdnů", "Přednášky", "Cvičení", "Semináře", "Zakončení",
            "Jazyk", "Velikost třídy", "Kredity", "Garantující ústav", "Jméno garanta", "Příjmení garanta"
        };

        private List<string> groupSubjectsColsNames = new List<string>
        {
            "Id skupiny", "Id předmětu"
        };
        #endregion

        #region Database tables
        private readonly string employeeTable = "EmployeeTable";
        private readonly string groupTable = "GroupTable";
        private readonly string subjectTable = "SubjectTable";
        private readonly string groupSubjectTable = "GroupSubject";
        #endregion

        public Form()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            loadNumericUpDown.Increment = 0.05m;
            errorProvider.BlinkRate = 0;

            semesterComboBox.DataSource = Enum.GetValues(typeof(SemesterEnum));
            formOfStudyComboBox.DataSource = Enum.GetValues(typeof(FormOfStudyEnum));
            typeOfStudyComboBox.DataSource = Enum.GetValues(typeof(TypeOfStudyEnum));
            groupLanguageComboBox.DataSource = Enum.GetValues(typeof(LanguageEnum));
            formOfCompletionComboBox.DataSource = Enum.GetValues(typeof(FormOfCompletionEnum));
            subjectLanguageComboBox.DataSource = Enum.GetValues(typeof(LanguageEnum));

            populateDataGridView(true, employeeDataGridView, employeesColsNames, employeeTable);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == subjectsTab)
            {
                populateDataGridView(true, subjectDataGridView, subjectsColsNames, subjectTable);
            }
            else if (tabs.SelectedTab == groupsTab)
            {
                populateDataGridView(true, groupDataGridView, groupsColsNames, groupTable);
            }
            else if (tabs.SelectedTab == employeesTab)
            {
                populateDataGridView(true, employeeDataGridView, employeesColsNames, employeeTable);
            }
            else if (tabs.SelectedTab == subjectsGroupsTab)
            {
                populateDataGridView(false, groupsDetailDataGridView, groupsColsNames, groupTable);
                populateDataGridView(false, subjectsDetailDataGridView, subjectsColsNames, subjectTable);
                populateDataGridView(false, subjectsGroupsDataGridView, groupSubjectsColsNames, groupSubjectTable);
                populateComboBox(groupTable, groupsComboBox);
                populateCheckableListBox(subjectTable, subjectsCheckedListBox);
            }
        }

        /// <summary>
        /// Uses timer for delay in milliseconds.
        /// </summary>
        /// <param name="milliseconds">Value of delay in milliseconds.</param>
        public void wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Button that adds new employee to the DB, it also checks if every input field is valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (isFirstNameValid && isLastNameValid && isWorkPhoneValid && isWorkEmailValid && isPersonalEmailValid)
            {
                Employee employeeModel = new Employee();
                employeeModel.FirstName = firstNameTextBox.Text;
                employeeModel.LastName = lastNameTextBox.Text;
                employeeModel.WorkEmail = workEmailTextBox.Text;
                employeeModel.PersonalEmail = personalEmailTextBox.Text;
                employeeModel.WorkPhoneNumber = workPhoneNumberTextBox.Text;
                employeeModel.PersonalPhoneNumber = personalPhoneNumberTextBox.Text;
                employeeModel.DoctoralStudent = IsDoctorandCheckbox.Checked;
                employeeModel.EmployeeLoad = (float)loadNumericUpDown.Value;

                GlobalConfig.Connection.CreateEmployee(employeeModel);

                MessageBox.Show("Zaměstnanec se jménem \"" + string.Join(" ", employeeModel.FirstName, employeeModel.LastName) + "\" byl úspěšně přidán do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                workEmailTextBox.Text = "";
                personalEmailTextBox.Text = "";
                workPhoneNumberTextBox.Text = "";
                personalPhoneNumberTextBox.Text = "";
                IsDoctorandCheckbox.Checked = false;
                loadNumericUpDown.Value = 0.00M;

                populateDataGridView(true, employeeDataGridView, employeesColsNames, "EmployeeTable");
            }
            else
            {
                if (string.IsNullOrEmpty(firstNameTextBox.Text)) { errorProvider.SetError(firstNameTextBox, "Jméno nesmí být prázdné!"); }

                if (string.IsNullOrEmpty(lastNameTextBox.Text)) { errorProvider.SetError(lastNameTextBox, "Příjmení nesmí být prázdné!"); }

                if (string.IsNullOrEmpty(workPhoneNumberTextBox.Text)) { errorProvider.SetError(workPhoneNumberTextBox, "Pracovní telefonní číslo nesmí být prázdné!"); }

                if (string.IsNullOrEmpty(workEmailTextBox.Text)) { errorProvider.SetError(workEmailTextBox, "Pracovní email nemůže být prázdný!"); }
            }
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(firstNameTextBox, "Jméno nesmí být prázdné!");
                isFirstNameValid = false;
            }
            else
            {
                errorProvider.Clear();
                isFirstNameValid = true;
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldFirstName = firstNameTextBox.Text;
                firstNameTextBox.Text = oldFirstName;
            }
            else
            {
                firstNameTextBox.Text = oldFirstName;
                firstNameTextBox.BackColor = Color.Red;
                firstNameTextBox.ForeColor = Color.White;
                wait(1000);
                firstNameTextBox.BackColor = Color.White;
                firstNameTextBox.ForeColor = Color.Black;
            }
            firstNameTextBox.SelectionStart = firstNameTextBox.Text.Length;
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(lastNameTextBox, "Příjmení nesmí být prázdné!");
                isLastNameValid = false;
            }
            else
            {
                errorProvider.Clear();
                isLastNameValid = true;
            }
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldLastName = lastNameTextBox.Text;
                lastNameTextBox.Text = oldLastName;
            }
            else
            {
                lastNameTextBox.Text = oldLastName;
                lastNameTextBox.BackColor = Color.Red;
                lastNameTextBox.ForeColor = Color.White;
                wait(1000);
                lastNameTextBox.BackColor = Color.White;
                lastNameTextBox.ForeColor = Color.Black;
            }
            lastNameTextBox.SelectionStart = lastNameTextBox.Text.Length;
        }

        private void workEmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex mRegxExpression;
            if (workEmailTextBox.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(workEmailTextBox.Text.Trim()))
                {
                    e.Cancel = false;
                    errorProvider.SetError(workEmailTextBox, "Pracovní email musí být ve správném tvaru!");
                    isWorkEmailValid = false;
                }
                else
                {
                    errorProvider.Clear();
                    isWorkEmailValid = true;
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(workEmailTextBox, "Pracovní email nemůže být prázdný!");
                isWorkEmailValid = false;
            }
        }

        private void personalEmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(personalEmailTextBox.Text))
            {
                Regex mRegxExpression;
                if (personalEmailTextBox.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(personalEmailTextBox.Text.Trim()))
                    {
                        e.Cancel = false;
                        errorProvider.SetError(personalEmailTextBox, "Osobní email musí být ve správném tvaru nebo prázdný!");
                        isPersonalEmailValid = false;
                    }
                    else
                    {
                        errorProvider.Clear();
                        isPersonalEmailValid = true;
                    }
                }
            }
            else
            {
                isPersonalEmailValid = true;
            }
        }

        private void workPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(workPhoneNumberTextBox.Text, "[^0-9]"))
            {
                oldWorkPhone = workPhoneNumberTextBox.Text;
                workPhoneNumberTextBox.Text = oldWorkPhone;
            }
            else
            {
                workPhoneNumberTextBox.Text = oldWorkPhone;
                workPhoneNumberTextBox.BackColor = Color.Red;
                workPhoneNumberTextBox.ForeColor = Color.White;
                wait(1000);
                workPhoneNumberTextBox.BackColor = Color.White;
                workPhoneNumberTextBox.ForeColor = Color.Black;
            }
            workPhoneNumberTextBox.SelectionStart = workPhoneNumberTextBox.Text.Length;
        }

        private void workPhoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(workPhoneNumberTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(workPhoneNumberTextBox, "Pracovní telefonní číslo nesmí být prázdné!");
                isWorkPhoneValid = false;
            }
            else
            {
                errorProvider.Clear();
                isWorkPhoneValid = true;
            }
        }

        private void personalPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(personalPhoneNumberTextBox.Text, "[^0-9]"))
            {
                oldPersonalPhone = personalPhoneNumberTextBox.Text;
                personalPhoneNumberTextBox.Text = oldPersonalPhone;
            }
            else
            {
                personalPhoneNumberTextBox.Text = oldPersonalPhone;
                personalPhoneNumberTextBox.BackColor = Color.Red;
                personalPhoneNumberTextBox.ForeColor = Color.White;
                wait(1000);
                personalPhoneNumberTextBox.BackColor = Color.White;
                personalPhoneNumberTextBox.ForeColor = Color.Black;
            }
            personalPhoneNumberTextBox.SelectionStart = personalPhoneNumberTextBox.Text.Length;
        }

        /// <summary>
        /// Button that adds new group to the DB, it also checks if every input field is valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGroupButton_Click(object sender, EventArgs e)
        {
            if (isGroupNameShortValid && isGroupNameValid)
            {
                Models.Group groupModel = new Models.Group();
                groupModel.Name = groupNameTextBox.Text;
                groupModel.NameShort = groupNameShortTextBox.Text;
                groupModel.Grade = (int)gradeNumericUpDown.Value;
                groupModel.Semester = semesterComboBox.SelectedValue.ToString();
                groupModel.NumberOfStudents = (int)numberOfStudentsNumericUpDown.Value;
                groupModel.FormOfStudy = formOfStudyComboBox.SelectedValue.ToString();
                groupModel.TypeOfStudy = typeOfStudyComboBox.SelectedValue.ToString();
                groupModel.Language = groupLanguageComboBox.SelectedValue.ToString();

                GlobalConfig.Connection.CreateGroup(groupModel);

                MessageBox.Show("Obor s názvem \"" + groupModel.Name.ToUpper() + "\" byl úspěšně přidán do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

                groupNameTextBox.Text = "";
                groupNameShortTextBox.Text = "";
                gradeNumericUpDown.Value = 1;
                numberOfStudentsNumericUpDown.Value = 1;
                formOfStudyComboBox.SelectedIndex = 0;
                typeOfStudyComboBox.SelectedIndex = 0;
                groupLanguageComboBox.SelectedIndex = 0;
                semesterComboBox.SelectedIndex = 0;

                populateDataGridView(true, groupDataGridView, groupsColsNames, "GroupTable");
            }
            else
            {
                if (string.IsNullOrEmpty(groupNameShortTextBox.Text)) { errorProvider.SetError(groupNameShortTextBox, "Název oboru nesmí být prázdný!"); }

                if (string.IsNullOrEmpty(groupNameTextBox.Text)) { errorProvider.SetError(groupNameTextBox, "Zkratka oboru nesmí být prázdná!"); }
            }

        }

        private void groupNameShortTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(groupNameShortTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(groupNameShortTextBox, "Zkratka oboru nesmí být prázdná!");
                isGroupNameShortValid = false;
            }
            else
            {
                errorProvider.Clear();
                isGroupNameShortValid = true;
            }
        }

        private void groupNameShortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (groupNameShortTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldGroupNameShort = groupNameShortTextBox.Text;
                groupNameShortTextBox.Text = oldGroupNameShort;
            }
            else
            {
                groupNameShortTextBox.Text = oldGroupNameShort;
                groupNameShortTextBox.BackColor = Color.Red;
                groupNameShortTextBox.ForeColor = Color.White;
                wait(1000);
                groupNameShortTextBox.BackColor = Color.White;
                groupNameShortTextBox.ForeColor = Color.Black;
            }
            groupNameShortTextBox.SelectionStart = groupNameShortTextBox.Text.Length;
        }

        private void groupNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(groupNameTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(groupNameTextBox, "Jméno oboru nesmí být prázdné!");
                isGroupNameValid = false;
            }
            else
            {
                errorProvider.Clear();
                isGroupNameValid = true;
            }
        }

        private void groupNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (groupNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldGroupName = groupNameTextBox.Text;
                groupNameTextBox.Text = oldGroupName;
            }
            else
            {
                groupNameTextBox.Text = oldGroupName;
                groupNameTextBox.BackColor = Color.Red;
                groupNameTextBox.ForeColor = Color.White;
                wait(1000);
                groupNameTextBox.BackColor = Color.White;
                groupNameTextBox.ForeColor = Color.Black;
            }
            groupNameTextBox.SelectionStart = groupNameTextBox.Text.Length;
        }

        /// <summary>
        /// Button that adds new subject to the DB, it also checks if every input field is valid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSubjectButton_Click(object sender, EventArgs e)
        {
            if (isSubjectNameShortValid && isSubjectNameValid)
            {
                Subject subjectModel = new Subject();
                subjectModel.Name = subjectNameTextBox.Text;
                subjectModel.NameShort = subjectNameShortTextBox.Text;
                subjectModel.NumberOfWeeks = (int)numberOfWeeksNumericUpDown.Value;
                subjectModel.LectureHours = (int)lectureHoursNumericUpDown.Value;
                subjectModel.PracticeHours = (int)practiceHoursNumericUpDown.Value;
                subjectModel.SeminarHours = (int)seminarHoursNumericUpDown.Value;
                subjectModel.FormOfCompletion = formOfCompletionComboBox.SelectedValue.ToString();
                subjectModel.Language = subjectLanguageComboBox.SelectedValue.ToString();
                subjectModel.ClassSize = (int)classSizeNumericUpDown.Value;
                subjectModel.Credits = (int)creditsNumericUpDown.Value;

                GlobalConfig.Connection.CreateSubject(subjectModel);

                MessageBox.Show("Předmět s názvem \"" + subjectModel.Name + "\" byl úspěšně přidán do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

                subjectNameTextBox.Text = "";
                subjectNameShortTextBox.Text = "";
                numberOfWeeksNumericUpDown.Value = 1;
                lectureHoursNumericUpDown.Value = 0;
                practiceHoursNumericUpDown.Value = 0;
                seminarHoursNumericUpDown.Value = 0;
                classSizeNumericUpDown.Value = 1;
                creditsNumericUpDown.Value = 1;
                subjectLanguageComboBox.SelectedIndex = 0;
                formOfCompletionComboBox.SelectedIndex = 0;

                populateDataGridView(true, subjectDataGridView, subjectsColsNames, "SubjectTable");
            }
        }

        private void subjectNameShortTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(subjectNameShortTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(subjectNameShortTextBox, "Zkratka oboru nesmí být prázdná!");
                isSubjectNameShortValid = false;
            }
            else
            {
                errorProvider.Clear();
                isSubjectNameShortValid = true;
            }
        }

        private void subjectNameShortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (subjectNameShortTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldSubjectNameShort = subjectNameShortTextBox.Text;
                subjectNameShortTextBox.Text = oldSubjectNameShort;
            }
            else
            {
                subjectNameShortTextBox.Text = oldSubjectNameShort;
                subjectNameShortTextBox.BackColor = Color.Red;
                subjectNameShortTextBox.ForeColor = Color.White;
                wait(1000);
                subjectNameShortTextBox.BackColor = Color.White;
                subjectNameShortTextBox.ForeColor = Color.Black;
            }
            subjectNameShortTextBox.SelectionStart = subjectNameShortTextBox.Text.Length;
        }

        private void subjectNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(subjectNameTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(subjectNameTextBox, "Název oboru nesmí být prázdný!");
                isSubjectNameValid = false;
            }
            else
            {
                errorProvider.Clear();
                isSubjectNameValid = true;
            }
        }

        private void subjectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (subjectNameTextBox.Text.All(chr => char.IsLetter(chr)))
            {
                oldSubjectName = subjectNameTextBox.Text;
                subjectNameTextBox.Text = oldSubjectName;
            }
            else
            {
                subjectNameTextBox.Text = oldSubjectName;
                subjectNameTextBox.BackColor = Color.Red;
                subjectNameTextBox.ForeColor = Color.White;
                wait(1000);
                subjectNameTextBox.BackColor = Color.White;
                subjectNameTextBox.ForeColor = Color.Black;
            }
            subjectNameTextBox.SelectionStart = subjectNameTextBox.Text.Length;
        }

        /// <summary>
        /// Fills dataGridView with relevant data from db
        /// </summary>
        /// <param name="showDeleteButton">True if you want to have option to delete data from db, otherwise false</param>
        /// <param name="dataGrid">dataGridView to fill with data</param>
        /// <param name="columnsNames">List with names of columns in dataGridView</param>
        /// <param name="dbTableName">Name of relevant table in db (without dbo. !)</param>
        private void populateDataGridView(bool showDeleteButton, DataGridView dataGrid, List<string> columnsNames, string dbTableName)
        {
            if (dataGrid.ColumnCount > 0)
            {
                dataGrid.Columns.RemoveAt(dataGrid.ColumnCount - 1);
            }

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                SqlDataAdapter sqlDataAdapter;
                DataTable dataTable;

                connection.Open();
                try
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo." + dbTableName, connection);
                    dataTable = new DataTable();
                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
                connection.Close();

                sqlDataAdapter.Fill(dataTable);

                dataGrid.AutoGenerateColumns = true;
                dataGrid.DataSource = dataTable;
                dataGrid.AutoGenerateColumns = false;
            }

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.ReadOnly = true;
            dataGrid.AllowUserToAddRows = false;

            Color lighterGray = ControlPaint.Light(Color.LightGray, (float)0.5);
            dataGrid.RowsDefaultCellStyle.BackColor = lighterGray;

            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;

            var numberOfColumns = dataGrid.Columns.Count;
            for (int i = 0; i < numberOfColumns; i++)
            {
                dataGrid.Columns[i].HeaderText = columnsNames[i];
            }

            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dbTableName == "EmployeeTable")
            {
                dataGrid.Columns[numberOfColumns - 1].DefaultCellStyle.Format = "N2";
            }

            if (showDeleteButton)
            {
                var delButton = new DataGridViewButtonColumn();
                delButton.Text = "Odstranit";
                delButton.UseColumnTextForButtonValue = true;
                delButton.ReadOnly = false;
                dataGrid.Columns.Add(delButton);
            }
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == employeeDataGridView.ColumnCount - 1)
            {
                DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];
                var employeeFirstName = row.Cells[1].Value;
                var employeeSurname = row.Cells[2].Value;
                var employeeId = row.Cells[0].Value;

                bool confirmed = MessageBox.Show(string.Format("Opravdu chcete odstranit zaměstnance \"{0} {1}\" ?", employeeFirstName, employeeSurname), "Potvrdit odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                if (confirmed)
                {
                    using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
                    {
                        using (SqlCommand command = new SqlCommand("DELETE FROM dbo.EmployeeTable WHERE id = @EmployeeId", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@EmployeeId", employeeId);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    populateDataGridView(true, employeeDataGridView, employeesColsNames, "EmployeeTable");

                    MessageBox.Show(string.Format("Zaměstnanec \"{0} {1}\", byl úspěšně odstraněn!", employeeFirstName, employeeSurname), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void groupDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == groupDataGridView.ColumnCount - 1)
            {
                DataGridViewRow row = groupDataGridView.Rows[e.RowIndex];
                var groupName = row.Cells[1].Value;
                var groupId = row.Cells[0].Value;

                bool confirmed = MessageBox.Show(string.Format("Opravdu chcete odstranit skupinu \"{0}\" ?", groupName), "Potvrdit odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                if (confirmed)
                {
                    using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM dbo.GroupSubject WHERE groupId = @groupId", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@groupId", groupId);

                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand("DELETE FROM dbo.GroupTable WHERE id = @groupId", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@groupId", groupId);
                            
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    populateDataGridView(true, groupDataGridView, groupsColsNames, groupTable);

                    MessageBox.Show(string.Format("Skupina \"{0}\", byla úspěšně odstraněna!", groupName), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void subjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == subjectDataGridView.ColumnCount - 1)
            {
                DataGridViewRow row = subjectDataGridView.Rows[e.RowIndex];
                var subjectName = row.Cells[1].Value;
                var subjectId = row.Cells[0].Value;

                bool confirmed = MessageBox.Show(string.Format("Opravdu chcete odstranit předmět \"{0}\" ?", subjectName), "Potvrdit odstranění", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                if (confirmed)
                {
                    using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM dbo.GroupSubject WHERE subjectId = @subjectId", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@subjectId", subjectId);

                            command.ExecuteNonQuery();
                        }

                        using (SqlCommand command = new SqlCommand("DELETE FROM dbo.SubjectTable WHERE id = @SubjectId", connection))
                        {
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@SubjectId", subjectId);
                            
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    populateDataGridView(true, subjectDataGridView, subjectsColsNames, subjectTable);

                    MessageBox.Show(string.Format("Předmět \"{0}\", byl úspěšně odstraněn!", subjectName), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void populateComboBox(string dbTableName, ComboBox comboBox)
        {
            DataTable dataTable;

            using (var connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                SqlDataAdapter sqlDataAdapter;

                connection.Open();
                try
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo." + dbTableName, connection);
                    dataTable = new DataTable();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
                connection.Close();

                sqlDataAdapter.Fill(dataTable);
            }

            comboBox.DataSource = dataTable;
            comboBox.ValueMember = dataTable.Columns[0].ColumnName;
            comboBox.DisplayMember = dataTable.Columns[1].ColumnName;
        }

        private void populateCheckableListBox(string dbTableName, CheckedListBox checkedListBox)
        {
            DataTable dataTable;

            using (var connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                SqlDataAdapter sqlDataAdapter;

                connection.Open();
                try
                {
                    sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo." + dbTableName, connection);
                    dataTable = new DataTable();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.ToString());
                    return;
                }
                connection.Close();

                sqlDataAdapter.Fill(dataTable);

                ((ListBox)checkedListBox).DataSource = dataTable;
                ((ListBox)checkedListBox).ValueMember = dataTable.Columns[0].ColumnName;
                ((ListBox)checkedListBox).DisplayMember = dataTable.Columns[1].ColumnName;
            }
        }

        private void groupSubjectsButton_Click(object sender, EventArgs e)
        {
            string selectedGroupId = groupsComboBox.SelectedValue.ToString();
            int succesful = 0;

            using (var connection = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                foreach (object checkedItem in subjectsCheckedListBox.CheckedItems)
                {
                    DataRowView dataRowView = (DataRowView)checkedItem;
                    string checkedItemValue = dataRowView[0].ToString();

                    using (var command = new SqlCommand())
                    {
                        try
                        {
                            connection.Open();

                            command.Connection = connection;
                            command.CommandText = @"INSERT INTO dbo.GroupSubject (groupId, subjectId) VALUES (@groupId, @subjectId)";
                            command.Parameters.AddWithValue("@groupId", Convert.ToInt32(selectedGroupId));
                            command.Parameters.AddWithValue("@subjectId", Convert.ToInt32(checkedItemValue));

                            succesful = command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (SqlException exception)
                        {
                            Console.WriteLine(exception.ToString());
                        }
                    }
                }
            }

            if (succesful > 0)
            {
                populateDataGridView(false, groupsDetailDataGridView, groupsColsNames, groupTable);
                populateDataGridView(false, subjectsDetailDataGridView, subjectsColsNames, subjectTable);
                populateDataGridView(false, subjectsGroupsDataGridView, groupSubjectsColsNames, groupSubjectTable);
                populateComboBox(groupTable, groupsComboBox);
                populateCheckableListBox(subjectTable, subjectsCheckedListBox);

                MessageBox.Show(string.Format("Předmět(y) byly úspěšně přiřazeny ke skupině s ID: {0}.", selectedGroupId), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
