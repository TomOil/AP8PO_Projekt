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

        public enum SemesterEnum { LS, ZS }
        public enum FormOfStudyEnum { P, K }
        public enum TypeOfStudyEnum { Bc, Mgr, PhD }
        public enum LanguageEnum { CZ, EN }
        public enum FormOfCompletionEnum { Z, ZK, KL }
        public enum GuarantorInstituteEnum { AUIUI, AUPKS, AUART, AUEM }

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

            getEmployeesData();
            getGroupsData();
            getSubjectsData();
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

                MessageBox.Show("Zaměstnanec se jménem \"" + String.Join(" ", employeeModel.FirstName, employeeModel.LastName) + "\" byl úspěšně přidán do databáze.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                workEmailTextBox.Text = "";
                personalEmailTextBox.Text = "";
                workPhoneNumberTextBox.Text = "";
                personalPhoneNumberTextBox.Text = "";
                IsDoctorandCheckbox.Checked = false;
                loadNumericUpDown.Value = 0.00M;

                getEmployeesData();
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

                getGroupsData();
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

                getSubjectsData();
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
        /// Get employees data from db and display them in dataGridView
        /// </summary>
        private void getEmployeesData()
        {
            if (employeeDataGridView.ColumnCount > 0)
            {
                employeeDataGridView.Columns.RemoveAt(employeeDataGridView.ColumnCount - 1);
            }

            List<string> employeesColsNames = new List<string>
            {
                "Id", "Jméno", "Příjmení", "Pracovní email", "Osobní email",
                "Pracovní tel. číslo", "Osobní tel. číslo", "Je doktorand?", "Úvazek", ""
            };

            using (SqlConnection getData = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                getData.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.EmployeeTable", getData);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                getData.Close();

                employeeDataGridView.AutoGenerateColumns = true;
                employeeDataGridView.DataSource = dataTable;
                employeeDataGridView.AutoGenerateColumns = false;
            }
            employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.AllowUserToAddRows = false;

            Color lighterGray = ControlPaint.Light(Color.LightGray, (float)0.5);
            employeeDataGridView.RowsDefaultCellStyle.BackColor = lighterGray;

            employeeDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            employeeDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            var numberOfColumns = employeeDataGridView.ColumnCount;
            for (int i = 0; i < numberOfColumns; i++)
            {
                employeeDataGridView.Columns[i].HeaderText = employeesColsNames[i];
            }

            employeeDataGridView.Columns[numberOfColumns - 1].DefaultCellStyle.Format = "N2";
            employeeDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var delButton = new DataGridViewButtonColumn();
            delButton.Text = "Odstranit";
            delButton.UseColumnTextForButtonValue = true;
            delButton.ReadOnly = false;
            employeeDataGridView.Columns.Add(delButton);
        }

        /// <summary>
        /// Delete employee and refresh dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == employeeDataGridView.ColumnCount - 1)
            {
                DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];
                var employeeFirstname = row.Cells[1].Value;
                var employeeSurname = row.Cells[2].Value;
                var employeeId = row.Cells[0].Value;

                bool confirmed = MessageBox.Show(string.Format("Opravdu chcete odstranit zaměstnance \"{0} {1}\" ?", employeeFirstname, employeeSurname), "Potvrdit odstranění", MessageBoxButtons.YesNo) == DialogResult.Yes;
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
                    getEmployeesData();

                    MessageBox.Show(string.Format("Zaměstnanec \"{0} {1}\", byl úspěšně odstraněn!", employeeFirstname, employeeSurname), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void getGroupsData()
        {
            List<string> groupsColsNames = new List<string>
            {
                "Id", "Název", "Zkratka", "Ročník", "Semestr",
                "Počet studentů", "Forma studia", "Typ studia", "Jazyk"
            };

            using (SqlConnection getData = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                getData.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.GroupTable", getData);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                getData.Close();

                groupDataGridView.DataSource = dataTable;
                groupDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                groupDataGridView.ReadOnly = true;

                Color lighterGray = ControlPaint.Light(Color.LightGray, (float)0.5);
                groupDataGridView.RowsDefaultCellStyle.BackColor = lighterGray;

                groupDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                groupDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

                var numberOfColumns = groupDataGridView.Columns.Count;
                for (int i = 0; i < numberOfColumns; i++)
                {
                    groupDataGridView.Columns[i].HeaderText = groupsColsNames[i];
                }

                groupDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void getSubjectsData()
        {
            List<string> subjectsColsNames = new List<string>
            {
                "Id", "Název", "Zkratka", "Počet týdnů", "Přednášky", "Cvičení", "Semináře", "Zakončení", 
                "Jazyk", "Velikost třídy", "Kredity", "Garantující ústav", "Jméno garanta", "Příjmení garanta"
            };

            using (SqlConnection getData = new SqlConnection(GlobalConfig.ConnectionString("AP8PO_Projekt")))
            {
                getData.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM dbo.SubjectTable", getData);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                getData.Close();

                subjectDataGridView.DataSource = dataTable;
                subjectDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                subjectDataGridView.ReadOnly = true;

                Color lighterGray = ControlPaint.Light(Color.LightGray, (float)0.5);
                subjectDataGridView.RowsDefaultCellStyle.BackColor = lighterGray;

                subjectDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                subjectDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

                var numberOfColumns = subjectDataGridView.Columns.Count;
                for (int i = 0; i < numberOfColumns; i++)
                {
                    subjectDataGridView.Columns[i].HeaderText = subjectsColsNames[i];
                }

                subjectDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
