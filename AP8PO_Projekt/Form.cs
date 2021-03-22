using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace AP8PO_Projekt
{
    public partial class Form : System.Windows.Forms.Form
    {
        string oldFirstName = string.Empty;
        string oldLastName = string.Empty;
        string oldWorkPhone = string.Empty;
        string oldPersonalPhone = string.Empty;
        bool isEverythingValid = false;

        public Form()
        {
            InitializeComponent();
            loadNumericUpDown.Increment = 0.05m;
            errorProvider.BlinkRate = 0;
        }

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

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (isEverythingValid)
            {
                MessageBox.Show("Succesful", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(firstNameTextBox.Text)) { errorProvider.SetError(firstNameTextBox, "First name cannot be empty!"); }

                if (string.IsNullOrEmpty(lastNameTextBox.Text)) { errorProvider.SetError(lastNameTextBox, "Last name cannot be empty!"); }

                if (string.IsNullOrEmpty(workPhoneNumberTextBox.Text)) { errorProvider.SetError(workPhoneNumberTextBox, "Work phone number cannot be empty!"); }
                
                if (string.IsNullOrEmpty(workEmailTextBox.Text)) { errorProvider.SetError(workEmailTextBox, "Work email cannot be empty!"); }
                
                isEverythingValid = false;
            }
        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(firstNameTextBox, "First name cannot be empty!");
                isEverythingValid = false;
            }
            else
            {
                errorProvider.Clear();
                isEverythingValid = true;
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
                errorProvider.SetError(lastNameTextBox, "Last name cannot be empty!");
                isEverythingValid = false;
            }
            else
            {
                errorProvider.Clear();
                isEverythingValid = true;
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
                    errorProvider.SetError(workEmailTextBox, "You must enter valid email!");
                    isEverythingValid = false;
                }
                else
                {
                    errorProvider.Clear();
                    isEverythingValid = true;
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(workEmailTextBox, "Work email cannot be empty!");
                isEverythingValid = false;
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
                        errorProvider.SetError(personalEmailTextBox, "You must enter valid or no email!");
                        isEverythingValid = false;
                    }
                    else
                    {
                        errorProvider.Clear();
                        isEverythingValid = true;
                    }
                }
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
                errorProvider.SetError(workPhoneNumberTextBox, "You must enter work phone number!");
                isEverythingValid = false;
            }
            else
            {
                errorProvider.Clear();
                isEverythingValid = true;
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
    }
}
