using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// full row => List.SelectedItems[0]
// Ceil Index == Tab Index 

namespace EmployeeManagementSystem
{
    public partial class frmShowEmployee : Form
    {
        static private frmEmployeeManagement Employee = new frmEmployeeManagement();

        public frmShowEmployee(frmEmployeeManagement managementForm)
        {
            InitializeComponent();
            Employee = managementForm; // fill reference of management form to save it
        }

        private void frmShowEmployee_Load(object sender, EventArgs e)
        {
            tbxSalary.Text += "  SAR";
            if (Employee.livwEmployess.SelectedItems.Count != 0)
            {
                ListViewItem Item = Employee.livwEmployess.SelectedItems[0];
                FillEmployeeFields(Item);
                SetEmployeeImage(Item);
            }
        }

        private Control FindControl(int TabIndexToSearch)
        {
            foreach(Control control in gbxEmployee.Controls)
            {
                if (control.TabIndex == TabIndexToSearch)
                    return control;
            }
            return null;
        }

        private void FillFieldData(Control control, ListViewItem Item, int Index, bool IncludeNextIndex = false)
        {
            if (control != null)
            {
                if (IncludeNextIndex)
                    control.Text = Item.SubItems[Index].Text + ' ' + Item.SubItems[Index + 1].Text;
                else
                    control.Text = Item.SubItems[Index].Text;
            }
            else
                MessageBox.Show("Control is not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FillEmployeeFields(ListViewItem Item)
        {
            for (int i = 0; i < Item.SubItems.Count; i++)
            {
                if (i == 2)
                    continue;

                else if (i == 1)
                    FillFieldData(FindControl(i), Item, i, true);

                else
                    FillFieldData(FindControl(i), Item, i);
            }
        }

        public void SetEmployeeImage(ListViewItem Item)
        {
            if (Item.SubItems[9].Text == "Male")
                pbxEmployee.Image = imageList1.Images[0];
            else
                pbxEmployee.Image = imageList1.Images[1];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}