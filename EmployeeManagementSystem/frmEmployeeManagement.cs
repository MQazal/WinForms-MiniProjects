using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class frmEmployeeManagement : Form
    {
        private static DateTime time = DateTime.Now;

        private static int Hour = time.Hour;

        private static int Minutes = time.Minute;

        private static int Seconds = time.Second;

        public string EmployeesFile = @"E:\Programming_Path\Programming Advices.com\Backend Development Track\Course#14\Course Code\Windows Forms\EmployeeManagementSystem\Employees.txt";

        public struct stEmployeeInfo
        {
            public byte ID;
            public string FirstName;
            public string LastName;
            public byte Age;
            public DateTime BirthDate;
            public string Job;
            public string Department;
            public float Salary;
            public DateTime HiringDate;
            public string Gender;
            public string WorkFrom;
            public string WorkTo;
            public string PhoneNumber;
            public string Email;
        }

        private ListViewItem SelectedItem;

        public frmEmployeeManagement()
        {
            InitializeComponent();
        }

        private void SelectEmployee(object sender, EventArgs e)
        {
            if (livwEmployess.SelectedItems.Count == 0)
            {
                SelectedItem = null;
                return;
            }
            SelectedItem = livwEmployess.SelectedItems[0];
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(EmployeesFile))
                File.Create(EmployeesFile).Close();
        }

        private ListViewItem ConvertDataLineToItem(string[] line)
        {
            // Line length = 14
            ListViewItem item = new ListViewItem(line[0]);
            for (short i = 1; i < line.Length; i++)
            {
                item.SubItems.Add(line[i]);
            }
            return item;
        }

        private void AddEmployeeToListView(ListViewItem EmployeeItem)
        {
            livwEmployess.Items.Add(EmployeeItem);
            EmployeeItem.ImageIndex = EmployeeItem.SubItems[9].Text == "Male" ? 0 : 1;
        }

        private void LoadEmployeesDataFromFile(string Separator)
        {
            livwEmployess.Items.Clear();
            string[] Lines = File.ReadAllLines(EmployeesFile);
            if (Lines.Length == 0)
                return;
            foreach (string line in Lines)
            {
                string[] Data = line.Split(new[] { Separator }, StringSplitOptions.None);
                AddEmployeeToListView(ConvertDataLineToItem(Data));
            }
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            InsertDate();
            EnsureFileExists();
            LoadEmployeesDataFromFile("#//#");
        }

        private void InsertDate()
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
        }

        private void UpdateTimerValues(MaskedTextBox HoursBox, MaskedTextBox MinutesBox, MaskedTextBox SecondsBox)
        {
            HoursBox.Text = Hour.ToString();
            MinutesBox.Text = Minutes.ToString();
            SecondsBox.Text = Seconds.ToString();
        }

        private void SetTimerValues()
        {
            if (Seconds == 59)
            {
                if (Minutes == 59)
                {
                    Hour += 1;
                    Minutes = 0;
                    Seconds = 0;
                }
                Seconds = 0;
                Minutes += 1;
            }
            else
            {
                Seconds += 1;
            }
            UpdateTimerValues(mskHour, mskMinute, mskSecond);
        }

        private void SetAmPm()
        {
            if (Hour < 12)
                txbxAMPM.Text = "AM";
            else
                txbxAMPM.Text = "PM";
        }

        private void tWatch_Tick(object sender, EventArgs e)
        {
            SetTimerValues();
            SetAmPm();
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAdd = new frmAddEmployee(this);
            frmAdd.ShowDialog();
        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (livwEmployess.SelectedItems.Count == 0)
                MessageBox.Show("You don't select employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form ShowEmployee = new frmShowEmployee(this);
                ShowEmployee.ShowDialog();
            }
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (livwEmployess.SelectedItems.Count == 0)
                MessageBox.Show("You don't select employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form UpdateEmployee = new frmUpdateEmployee(this);
                UpdateEmployee.ShowDialog();
            }
        }

        public stEmployeeInfo ConvertDataLineToStructure(string[] DataLine)
        {
            stEmployeeInfo info = new stEmployeeInfo();
            info.ID = Convert.ToByte(DataLine[0]);
            info.FirstName = DataLine[1];
            info.LastName = DataLine[2];
            info.Age = Convert.ToByte(DataLine[3]);
            info.BirthDate = Convert.ToDateTime(DataLine[4]);
            info.Job = DataLine[5];
            info.Department = DataLine[6];
            info.Salary = Convert.ToSingle(DataLine[7]);
            info.HiringDate = Convert.ToDateTime(DataLine[8]);
            info.Gender = DataLine[9];
            info.WorkFrom = DataLine[10];
            info.WorkTo = DataLine[11];
            info.PhoneNumber = DataLine[12];
            info.Email = DataLine[13];
            return info;
        }

        private bool IsMatchingID(byte Database_ID)
        {
            return Database_ID == Convert.ToByte(SelectedItem.SubItems[0].Text);
        }

        private List<stEmployeeInfo> LoadDataFileToList(string Separator)
        {
            List<stEmployeeInfo> employeesList = new List<stEmployeeInfo>();

            string[] lines = File.ReadAllLines(EmployeesFile);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new[] { Separator }, StringSplitOptions.None);

                stEmployeeInfo employee = ConvertDataLineToStructure(parts);

                if (!IsMatchingID(employee.ID))
                    employeesList.Add(employee);
            }

            return employeesList;
        }

        public void ClearFile()
        {
            File.Delete(EmployeesFile);
            File.Create(EmployeesFile).Close();
        }

        public string ConvertRecordToDataLine(stEmployeeInfo info, string Separator)
        {
            return string.Join(Separator, new string[]
            {
                info.ID.ToString(),
                info.FirstName,
                info.LastName,
                info.Age.ToString(),
                info.BirthDate.ToString("MM-dd-yyyy"),
                info.Job,
                info.Department,
                info.Salary.ToString(),
                info.HiringDate.ToString("MM-dd-yyyy"),
                info.Gender,
                info.WorkFrom,
                info.WorkTo,
                info.PhoneNumber,
                info.Email
            });  
        }

        public void LoadEmployeesListDataToFile(List<stEmployeeInfo> employees)
        {
            foreach (stEmployeeInfo employee in employees)
            {
                string DataLine = ConvertRecordToDataLine(employee, "#//#");
                File.AppendAllText(EmployeesFile, DataLine + Environment.NewLine);
            }
        }

        private void RefreshFileAfterDelete(string FileName)
        {
            List<stEmployeeInfo> employeesList = LoadDataFileToList("#//#");
            ClearFile();
            LoadEmployeesListDataToFile(employeesList);
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (livwEmployess.SelectedItems.Count == 0)
            {
                MessageBox.Show("You don't select employee!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure to delete this employee?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RefreshFileAfterDelete(EmployeesFile);
                SelectedItem.Remove();
            }
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (livwEmployess.Items.Count == 0)
            {
                MessageBox.Show("Employees List is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Are you sure to clear employess list?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                livwEmployess.Items.Clear();
                ClearFile();
            }
        }

        private void searchAboutUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SearchAboutEmployee = new frmSearchAboutEmployee(this);
            SearchAboutEmployee.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}