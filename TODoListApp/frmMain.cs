using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetTextBox();
            MakeCircleButton(btAddTask);
            MakeCircleButton(btDeleteFirstTask);
            MakeCircleButton(btCheckedBox);
            MakeCircleButton(btUncheckedBox);
            MakeCircleButton(btClearBox);
        }

        private void ShowButtonFunction(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            Button button = (Button)sender;
            switch(button.Tag.ToString())
            {
                case "Add":
                    tip.SetToolTip(btAddTask, "Add new Task");
                    break;
                case "Delete":
                    tip.SetToolTip(btDeleteFirstTask, "Delete Task");
                    break;
                case "Clear":
                    tip.SetToolTip(btClearBox, "Clear all Tasks");
                    break;
                case "CheckAll":
                    tip.SetToolTip(btCheckedBox, "Check all Tasks");
                    break;
                case "UncheckAll":
                    tip.SetToolTip(btUncheckedBox, "Uncheck all Tasks");
                    break;
            }
        }

        private void SetTextBox()
        {
            tbTask.Text = "Write new Task here...";
            tbTask.ForeColor = Color.Gray;
        }

        private void TypeTask(object sender, EventArgs e)
        {
            tbTask.Text = "";
            tbTask.ForeColor = Color.Black;
        }

        private void LeaveTaskBox(object sender, EventArgs e)
        {
            if (tbTask.Text == "")
                SetTextBox();
        }

        private void btAddTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTask.Text))
            {
                clbTasks.Items.Add(tbTask.Text);
                cbTasks.Items.Add(tbTask.Text);
                SetTextBox();
                UpdatePendingTasksNumber();
            }
        }

        private void btDeleteFirstTask_Click(object sender, EventArgs e)
        {
            if (clbTasks.Items.Count == 0)
            {
                MessageBox.Show("Tasks List is Empty!");
                return;
            }
            clbTasks.Items.RemoveAt(0);
            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void btDeleteLastTask_Click(object sender, EventArgs e)
        {
            if (clbTasks.Items.Count == 0)
            {
                MessageBox.Show("Tasks List is Empty!");
                return;
            }
            clbTasks.Items.RemoveAt(clbTasks.Items.Count - 1);
            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void DeleteCheckedTasks_Click(object sender, EventArgs e)
        {
            // clear CheckedItems temproary list

            if (clbTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("No Tasks are checked yet!");
                return;
            }

            for (byte i = 1; i <= clbTasks.CheckedItems.Count; i++)
            {
                clbTasks.Items.Remove(clbTasks.CheckedItems[i - 1]);
            }

            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void clbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void btCheckedBox_Click(object sender, EventArgs e)
        {
            for (byte i = 1; i <= clbTasks.Items.Count; i++)
            {
                if (!clbTasks.GetItemChecked(i - 1))
                    clbTasks.SetItemChecked(i - 1, true);
            }
            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void btUncheckedBox_Click(object sender, EventArgs e)
        {
            for (byte i = 1; i <= clbTasks.Items.Count; i++)
            {
                if (clbTasks.GetItemChecked(i - 1))
                    clbTasks.SetItemChecked(i - 1, false);
            }
            UpdatePendingTasksNumber();
            UpdateCompletedTasksNumber();
        }

        private void btClearBox_Click(object sender, EventArgs e)
        {
            if (clbTasks.Items.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to clear all tasks?", "Clear All Tasks", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    clbTasks.Items.Clear();
                    UpdatePendingTasksNumber();
                    UpdateCompletedTasksNumber();
                }
            }
        }

        private void UpdatePendingTasksNumber()
        {
            lbPending.Text = Convert.ToString(clbTasks.Items.Count - clbTasks.CheckedItems.Count);
        }

        private void UpdateCompletedTasksNumber()
        {
            lbCompleted.Text = clbTasks.CheckedItems.Count.ToString();
        }

        private void MakeCircleButton(Button btn)
        {
            System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
            p.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(p);
        }

        private void btShowCheckedTasks_Click(object sender, EventArgs e)
        {
            if (clbTasks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Tasks List is Empty!");
                return;
            }

            for (byte i = 1; i <= clbTasks.CheckedItems.Count; i++)
            {
                MessageBox.Show("Task: " + i + ": " + clbTasks.CheckedItems[i]);
            }
        }

        private void btDeleteIndexByComboBox_Click(object sender, EventArgs e)
        {
            if (clbTasks.Items.Count == 0)
            {
                MessageBox.Show("Tasks List is Empty!");
                return;
            }

            string TaskToDelete = cbTasks.SelectedItem.ToString();
            for (byte i = 1; i <= clbTasks.Items.Count; i++)
            {
                if (clbTasks.Items[i - 1].ToString() == TaskToDelete)
                {
                    clbTasks.Items.RemoveAt(i - 1);
                    break;
                }
            }
        }
    }
}