using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using stEmployeeInfo = EmployeeManagementSystem.frmEmployeeManagement.stEmployeeInfo;

namespace EmployeeManagementSystem
{
    public partial class frmUpdateEmployee : Form
    {
        static private frmEmployeeManagement Employee = new frmEmployeeManagement();

        ListViewItem SelectedItem;

        public frmUpdateEmployee(frmEmployeeManagement managementForm)
        {
            InitializeComponent();
            Employee = managementForm;
            SelectedItem = Employee.livwEmployess.SelectedItems[0];
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            FillEmployeeFields();
            tbxFName.Focus();
        }

        private Control FindControl(int TabIndexToSearch)
        {
            foreach (Control control in gbxUpdate.Controls)
            {
                if (control.TabIndex == TabIndexToSearch)
                    return control;
            }
            return null;
        }

        private void FillFieldData(Control control, int Index)
        {
            if (control != null)
                control.Text = SelectedItem.SubItems[Index].Text;
            else
                MessageBox.Show("Control is not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillEmployeeFields()
        {
            for (int i = 0; i < SelectedItem.SubItems.Count; i++)
            {
                FillFieldData(FindControl(i), i);
            }
        }

        private string UpdateCeil(Control control, int Index)
        {
            return SelectedItem.SubItems[Index].Text = control.Text.Trim();
        }

        private void UpdateEmployeeCeils()
        {
            for (int i = 1; i < SelectedItem.SubItems.Count; i++)
            {
                if (FindControl(i) == mskSalary)
                {
                    SelectedItem.SubItems[i].Text = mskSalary.Text.Substring(0, 5);
                    continue;
                }
                SelectedItem.SubItems[i].Text = UpdateCeil(FindControl(i), i);
            }
        }

        private bool IsMatchingID(byte Database_ID)
        {
            return Database_ID == Convert.ToByte(SelectedItem.SubItems[0].Text);
        }

        private void UpdateEmployeeRecord(ref stEmployeeInfo Updated)
        {
            Updated.FirstName = SelectedItem.SubItems[1].Text;
            Updated.LastName = SelectedItem.SubItems[2].Text;
            Updated.Age = Convert.ToByte(SelectedItem.SubItems[3].Text);
            Updated.BirthDate = Convert.ToDateTime(SelectedItem.SubItems[4].Text);
            Updated.Job = SelectedItem.SubItems[5].Text;
            Updated.Department = SelectedItem.SubItems[6].Text;
            Updated.Salary = Convert.ToSingle(SelectedItem.SubItems[7].Text);
            Updated.HiringDate = Convert.ToDateTime(SelectedItem.SubItems[8].Text);
            Updated.Gender = SelectedItem.SubItems[9].Text;
            Updated.WorkFrom = SelectedItem.SubItems[10].Text;
            Updated.WorkTo = SelectedItem.SubItems[11].Text;
            Updated.PhoneNumber = SelectedItem.SubItems[12].Text;
            Updated.Email = SelectedItem.SubItems[13].Text;
        }

        private List<stEmployeeInfo> LoadDataFileToList(string Separator)
        {
            List<stEmployeeInfo> employeesList = new List<stEmployeeInfo>();

            string[] DataLines = File.ReadAllLines(Employee.EmployeesFile);

            foreach (string Line in DataLines)
            {
                string[] parts = Line.Split(new[] { Separator }, StringSplitOptions.None);
                stEmployeeInfo employee = Employee.ConvertDataLineToStructure(parts);
                // update
                if (IsMatchingID(employee.ID))
                {
                    UpdateEmployeeRecord(ref employee);
                }
                employeesList.Add(employee);
            }
            return employeesList;
        }

        private void RefreshFileAfterUpdate(string FileName)
        {
            List<stEmployeeInfo> employeesList = LoadDataFileToList("#//#");
            Employee.ClearFile();
            Employee.LoadEmployeesListDataToFile(employeesList);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to update employee?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UpdateEmployeeCeils();
                RefreshFileAfterUpdate(Employee.EmployeesFile);
                MessageBox.Show("Employee updated sucessfully.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}