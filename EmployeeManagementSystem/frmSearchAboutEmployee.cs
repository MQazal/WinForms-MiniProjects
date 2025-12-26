using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace EmployeeManagementSystem
{
    public partial class frmSearchAboutEmployee : Form
    {
        private frmEmployeeManagement Employee;

        public frmSearchAboutEmployee(frmEmployeeManagement managementForm)
        {
            InitializeComponent();
            Employee = managementForm;
        }

        private ListViewItem FindEmployee()
        {
            foreach(ListViewItem Item in Employee.livwEmployess.Items)
            {
                if (Item.SubItems[0].Text == mbxID.Text)
                {
                    return Item;
                }
            }
            return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListViewItem item = FindEmployee();
            if (item != null)
            {
                frmShowEmployee ShowEmployee = new frmShowEmployee(Employee);
                ShowEmployee.FillEmployeeFields(item);
                ShowEmployee.SetEmployeeImage(item);
                ShowEmployee.ShowDialog();
            }

            else
                MessageBox.Show("Employee is not found.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
