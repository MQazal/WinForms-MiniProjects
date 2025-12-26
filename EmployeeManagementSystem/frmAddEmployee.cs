using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;
using System.IO;

// group.Controls -> childs of group or its different controls

namespace EmployeeManagementSystem
{
    public partial class frmAddEmployee : Form
    {
        // Pass the form reference via constructor
        private frmEmployeeManagement Employee;
        private CancelEventArgs e;
        private byte ErrorsCounter = 0;

        enum enTextBox
        {
            FirstName = 1,
            LastName,
            Email,
            Full
        }

        enum enMasked
        {
            ID = 1,
            Age,
            Salary,
            TimeFrom,
            TimeTo,
            PhoneNumber,
            Full
        }

        private bool IsNumberInRange(int Number, int From, int To)
        {
            return (Number >= From) && (Number <= To);
        }

        public frmAddEmployee(frmEmployeeManagement managementForm)
        {
            InitializeComponent();
            Employee = managementForm;
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            AddJobs();
            AddDepartments();
        }

        private void AddJobs()
        {
            cmbxJob.Items.Add("Full-Stack Desktop Developer");
            cmbxJob.Items.Add("Full-Stack Web Seveloper");
            cmbxJob.Items.Add("Full-Stack Mobile Developer");
        }

        private void AddDepartments()
        {
            cmbxDepartment.Items.Add("Desktop Apps Development");
            cmbxDepartment.Items.Add("Wep Apps Development");
            cmbxDepartment.Items.Add("Mobile Apps Development");
        }

        private ListViewItem CreateMainItem(Control control)
        {
            ListViewItem NewItem = new ListViewItem(control.Text.Trim());
            return NewItem;
        }

        private enTextBox GetTextBox(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                if (box == txbxFName)
                    return enTextBox.FirstName;
                else if (box == txbxLName)
                    return enTextBox.LastName;
                else
                    return enTextBox.Email;
            }
            return enTextBox.Full;
        }

        private void SetTextBoxErrorMessage(enTextBox boxValue)
        {
            switch (boxValue)
            {
                case enTextBox.FirstName:
                    errorProvider.SetError(txbxFName, "First Name is required");
                    ErrorsCounter++;
                    break;
                case enTextBox.LastName:
                    errorProvider.SetError(txbxLName, "Last Name is required");
                    ErrorsCounter++;
                    break;
                default:
                    errorProvider.SetError(txbxEmail, "Email is required");
                    ErrorsCounter++;
                    break;
            }
        }

        private void IsAnyEmptyTextBoxInGroup(GroupBox group)
        {
            enTextBox BoxEnum;
            foreach (TextBox box in group.Controls.OfType<TextBox>())
            {
                BoxEnum = GetTextBox(box);

                if (BoxEnum != enTextBox.Full)
                    SetTextBoxErrorMessage(BoxEnum);
                else
                    errorProvider.SetError(box, "");
            }
        }

        private enMasked GetMaskBox(MaskedTextBox masked)
        {
            if (masked == mskAge)
                return enMasked.Age;

            if (masked == mskSalary)
                return enMasked.Salary;

            // other masks
            if (!masked.MaskFull)
            {
                if (masked == mskID)
                    return enMasked.ID;

                else if (masked == mskTimeFrom)
                    return enMasked.TimeFrom;

                else if (masked == mskTimeTo)
                    return enMasked.TimeTo;

                else
                    return enMasked.PhoneNumber;
            }
            return enMasked.Full;
        }

        private void SetMaskErrorMessage(enMasked maskedValue)
        {
            switch (maskedValue)
            {
                case enMasked.ID:
                    errorProvider.SetError(mskID, "Please enter Employee ID.");
                    ErrorsCounter++;
                    break;

                case enMasked.Age:
                    if (string.IsNullOrWhiteSpace(mskAge.Text))
                    {
                        errorProvider.SetError(mskAge, "Age is required");
                        ErrorsCounter++;
                    }
                    else if (!IsNumberInRange(Convert.ToInt32(mskAge.Text), 25, 65))
                    {
                        errorProvider.SetError(mskAge, "Age must be a number between 25 and 65.");
                        ErrorsCounter++;
                    }
                    else
                    {
                        errorProvider.SetError(mskAge, "");
                    }
                    break;

                case enMasked.Salary:
                    string SalaryDigits = mskSalary.Text.Substring(0, 5);
                    if (string.IsNullOrWhiteSpace(SalaryDigits))
                    {
                        errorProvider.SetError(mskSalary, "Salary is required");
                        ErrorsCounter++;
                    }
                    else
                    {
                        errorProvider.SetError(mskSalary, "");
                    }
                    break;

                case enMasked.TimeFrom:
                    errorProvider.SetError(mskTimeFrom, "Please enter a valid start time.");
                    ErrorsCounter++;
                    break;

                case enMasked.TimeTo:
                    errorProvider.SetError(mskTimeTo, "Please enter a valid end time.");
                    ErrorsCounter++;
                    break;

                default:
                    errorProvider.SetError(mskPhone, "Please enter a valid phone number.");
                    ErrorsCounter++;
                    break;
            }
        }

        private void IsAnyEmptyMaskedTextBoxInGroup(GroupBox group)
        {
            enMasked Mask;
            foreach (MaskedTextBox masked in group.Controls.OfType<MaskedTextBox>())
            {
                Mask = GetMaskBox(masked);

                if (Mask != enMasked.Full)
                    SetMaskErrorMessage(Mask);
                else
                    errorProvider.SetError(masked, "");
            }
        }

        private void IsAnyEmptyComboBoxInGroup(GroupBox group)
        {
            foreach (ComboBox combo in group.Controls.OfType<ComboBox>())
            {
                if (combo.SelectedIndex == -1)
                {
                    errorProvider.SetError(combo, "Please select a choice");
                    ErrorsCounter++;
                }
                else
                {
                    errorProvider.SetError(combo, "");
                }
            }
        }

        private void IsNoRadioButtonCheckedInGroup(GroupBox group)
        {
            if (group.Controls.OfType<RadioButton>().Any()) // check if group has radio button
            {
                if (group.Controls.OfType<RadioButton>().Any(radio => radio.Checked))
                {
                    foreach (RadioButton radio in group.Controls.OfType<RadioButton>())
                    {
                        errorProvider.SetError(radio, "");
                    }
                }
                else
                {
                    RadioButton Radio = group.Controls.OfType<RadioButton>().FirstOrDefault(); // returns the first RadioButton found
                    errorProvider.SetError(Radio, "Please Select Option");
                }
            }
        }

        private void ValidatePersonalData(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsAnyEmptyTextBoxInGroup((GroupBox)sender);
            IsAnyEmptyMaskedTextBoxInGroup((GroupBox)sender);
        }

        private void ValidateJobData(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsAnyEmptyComboBoxInGroup((GroupBox)sender);
            IsAnyEmptyMaskedTextBoxInGroup((GroupBox)sender);
        }

        private void ValidateGenderSelect(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsNoRadioButtonCheckedInGroup((GroupBox)sender);
        }

        private void ValidateWorkTimes(object sender, System.ComponentModel.CancelEventArgs e)
        {
           IsAnyEmptyMaskedTextBoxInGroup((GroupBox)sender);
        }

        private void ValidateContactData(object sender, System.ComponentModel.CancelEventArgs e)
        {
            IsAnyEmptyTextBoxInGroup((GroupBox)sender);
            IsAnyEmptyMaskedTextBoxInGroup((GroupBox)sender);
        }

        private bool IsThereEmptyField()
        {
            ErrorsCounter = 0; // Reset errors to 0

            ValidatePersonalData(gbxPersonal, e);
            ValidateJobData(gbxJob, e);
            ValidateGenderSelect(gbxGender, e);
            ValidateWorkTimes(gbxTime, e);
            ValidateContactData(gbxContact, e);

            return ErrorsCounter > 0;
        }

        private void AddSubItemToItem(ListViewItem Item, Control control)
        {
            Item.SubItems.Add(control.Text.Trim());
        }

        private void ConvertControlsToSubItems(GroupBox group, ListViewItem mainItem)
        {
            foreach (Control control in group.Controls.Cast<Control>().OrderBy(control => control.TabIndex))
            {
                if (control == mskID || control is Label)
                    continue;
                if (control == mskSalary)
                {
                    mainItem.SubItems.Add(mskSalary.Text.Substring(0, 5));
                    continue;
                }
                AddSubItemToItem(mainItem, control);
            }
        }

        private void AddItemToList(ListViewItem Item)
        {
            Employee.livwEmployess.Items.Add(Item);
        }

        private string ConvertItemToDataLine(ListViewItem Item, string Separator)
        {
            string DataLine = "";
            for (short i = 0; i < Item.SubItems.Count - 1; i++)
            {
                DataLine += Item.SubItems[i].Text + Separator;
            }
            // add last element of raw
            DataLine += Item.SubItems[Item.SubItems.Count - 1].Text;
            return DataLine;
        }

        private void AddDataLineToFile(string DataLine)
        {
            if (File.Exists(Employee.EmployeesFile))
                File.AppendAllText(Employee.EmployeesFile, DataLine + Environment.NewLine);
        }

        private bool AddNewEmployee()
        {
            ListViewItem MainItem = CreateMainItem(mskID);

            if (!IsThereEmptyField())
            {
                ConvertControlsToSubItems(gbxPersonal, MainItem);
                ConvertControlsToSubItems(gbxJob, MainItem);
                MainItem.SubItems.Add(rdbtnMale.Checked ? "Male" : "Female");
                MainItem.ImageIndex = rdbtnMale.Checked ? 0 : 1;
                ConvertControlsToSubItems(gbxTime, MainItem);
                ConvertControlsToSubItems(gbxContact, MainItem);
                AddItemToList(MainItem);
                AddDataLineToFile(ConvertItemToDataLine(MainItem, "#//#"));
                return true;
            }
            return false;
        }

        private void ClearControls()
        {
            foreach (GroupBox group in gbxNewEmployee.Controls.OfType<GroupBox>())
            {
                foreach (TextBox textBox in group.Controls.OfType<TextBox>())
                    textBox.Clear();

                foreach (MaskedTextBox masked in group.Controls.OfType<MaskedTextBox>())
                    masked.Clear();

                foreach (ComboBox combo in group.Controls.OfType<ComboBox>())
                    combo.SelectedItem = null;

                foreach (RadioButton radio in group.Controls.OfType<RadioButton>())
                    radio.Checked = false;
            }
            errorProvider.Clear();
        }

        private void ResetForm()
        {
            ClearControls();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (AddNewEmployee()) // Full new line of employee data
            {
                ResetForm();
                mskID.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}