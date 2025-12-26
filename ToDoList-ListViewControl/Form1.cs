using System;
using System.Drawing;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace ProgressPersentageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetControlVisibleStatus(Control control, bool VisibleStatus)
        {
            control.Visible = VisibleStatus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetTextBox(tbMajorTask, "Add New Major Task...", Color.Gray);
            SetTextBox(tbSubTask, "Add New Sub-Task...", Color.Gray);

            SetControlVisibleStatus(lbMinutes, false);
            SetControlVisibleStatus(label5, false);
            SetControlVisibleStatus(lbSeconds, false);

            lbMinutes.Text = Minutes.ToString();
            lbSeconds.Text = Seconds.ToString();
        }

        byte Minutes = 1;

        byte Seconds = 0;

        enum Operation { AddMajor, AddSub, Cross, Delete, CheckAll, UncheckAll, Clear };
        Operation CurrentOperation;

        private void SendNotification (string Title, string Content)
        {
            notifyIcon1.Icon = SystemIcons.WinLogo;
            notifyIcon1.ShowBalloonTip(5000, Title, Content, ToolTipIcon.Info);
        }

        private void PerformOperation()
        {
            switch (CurrentOperation)
            {
                case Operation.AddMajor:
                    this.AddMajorTask();
                    SendNotification("Add", "Your Major Task is added");
                    break;

                case Operation.AddSub:
                    this.AddSubTask();
                    SendNotification("Add", "Your Sub Task is added");
                    break;

                case Operation.Cross:
                    this.CrossOutTasks();
                    SendNotification("Cross", "Task(s) crossed out");
                    break;

                case Operation.Delete:
                    this.DeleteTasks();
                    SendNotification("Delete", "Task(s) deleted");
                    break;

                case Operation.CheckAll:
                    this.CheckAllTasks();
                    SendNotification("Check", "List is Checked");
                    break;

                case Operation.UncheckAll:
                    this.UncheckAllTasks();
                    SendNotification("UnCheck", "List is UnCheck");
                    break;

                case Operation.Clear:
                    this.ClearTasksList();
                    SendNotification("Clear", "List is Cleared");
                    break;
            }
        }

        private void ProcessTimerTick()
        {
            timer1.Enabled = true;

            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    timer1.Stop();
                    PerformOperation();
                    Minutes = 1;
                    Seconds = 0;
                }
                else
                {
                    Seconds = 59;
                    Minutes--;
                }
            }

            else
            {
                Seconds--;
            }

            lbMinutes.Text = Minutes.ToString();
            lbSeconds.Text = Seconds.ToString();
        }

        private void ProcessProgressBar(int MinimumValue, int MaximumValue)
        {
            progressBar1.Minimum = MinimumValue;
            progressBar1.Maximum = MaximumValue; // Seconds of Minutes + Seconds = Full Timer -> 100% of Progress Bar
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lbPercentage.Text = ((progressBar1.Value * 100) / progressBar1.Maximum).ToString() + "%";
            }
            else
            {
                progressBar1.Value = 0;
                lbPercentage.Text = "0%";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProcessTimerTick();
            ProcessProgressBar(0, 60);
        }

        int PendingTasks = default(int);

        int CompletedTasks = default(int);

        private void SetPendingTasksNumber(int Number)
        {
            PendingTasks = Number;
            lbPending.Text = PendingTasks.ToString();
        }

        private void SetCompletedTasksNumber(int Number)
        {
            CompletedTasks = Number;
            lbCompleted.Text = CompletedTasks.ToString();
        }

        private void SetTextBox(TextBox box, string DefaultString, Color DefaultColor)
        {
            box.Text = DefaultString;
            box.ForeColor = DefaultColor;
        }

        private void TypeInBox(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            box.Text = "";
            box.ForeColor = Color.Black;
        }

        private void LeaveBox(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "" && box.Tag.ToString() == "MajorT")
            {
                SetTextBox(tbMajorTask, "Add New Major Task...", Color.Gray);
            }

            else if(box.Text == "" && box.Tag.ToString() == "SubT")
            {
                SetTextBox(tbSubTask, "Add New Sub-Task...", Color.Gray);
            }
        }

        private TreeNode CreateNewRootNode(string RootName)
        {
            TreeNode NewRoot = new TreeNode(RootName);
            return NewRoot;
        }

        private void AddMajorTask()
        {
            TreeNode NewTask = CreateNewRootNode(tbMajorTask.Text);
            tvTasks.Nodes.Add(NewTask);
            cbMajorTasks.Items.Add(NewTask.Text);
            SetPendingTasksNumber(PendingTasks += 1);
            SetTextBox(tbMajorTask, "Add New Major Task...", Color.Gray);
        }

        private void btAddMajorTask_Click(object sender, EventArgs e)
        {
            if (tbMajorTask.Text == "Add New Major Task...")
            {
                MessageBox.Show("Invalid Task Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Do you want to add this major task?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.AddMajor;
            }
        }

        private TreeNode CreateNewChildNode(TreeNode Root, string ChildKey, string ChildName)
        {
            return Root.Nodes.Add(ChildKey, ChildName);
        }

        private void AddSubTask()
        {
            // 1- Find Major Task
            foreach (TreeNode node in tvTasks.Nodes)
            {
                if (node.Text == cbMajorTasks.SelectedItem.ToString())
                {
                    // 2- Add Sub Task
                    CreateNewChildNode(node, "SubTask", tbSubTask.Text);
                    break;
                }
            }
            SetPendingTasksNumber(PendingTasks += 1);
            SetTextBox(tbSubTask, "Add New Sub-Task...", Color.Gray);
        }

        private void btAddSubTask_Click(object sender, EventArgs e)
        {
            if (cbMajorTasks.SelectedItem == null)
            {
                MessageBox.Show("You don't select any major task!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbSubTask.Text == "Add New Sub-Task...")
            {
                MessageBox.Show("Invalid Task Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show("Do you want to add this sub task?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.AddSub;
            }
        }

        private void CrossOutNodesContainer(TreeNode Container, Boolean CrossAllNodes = true)
        {
            for(int i = Container.Nodes.Count - 1; i >= 0; i--)
            {
                if (!CrossAllNodes)
                {
                    if (Container.Nodes[i].Checked)
                        Container.Nodes[i].NodeFont = new Font(tvTasks.Font, FontStyle.Strikeout);
                }
                else
                    Container.Nodes[i].NodeFont = new Font(tvTasks.Font, FontStyle.Strikeout);
            }
        }

        private int GetCrossedNodesInContainer(TreeNode Container)
        {
            int CrossNodes = default(int);
            foreach(TreeNode node in Container.Nodes)
            {
                if (node.NodeFont.Style == FontStyle.Strikeout)
                {
                    CrossNodes++;
                }
            }
            return CrossNodes;
        }

        private int UpdateCompletedTasksNumberAfterCross()
        {
            int CrossedTasksNumber = default(int);

            foreach(TreeNode node in tvTasks.Nodes)
            {
                if(node.Nodes.Count > 0)
                {
                    CrossedTasksNumber = GetCrossedNodesInContainer(node);
                }

                // Count this root node only once
                if (node.NodeFont != null && node.NodeFont.Style == FontStyle.Strikeout)
                {
                    CrossedTasksNumber++;
                }
            }
            return CrossedTasksNumber;
        }

        private void CrossOutTasks()
        {
            foreach (TreeNode node in tvTasks.Nodes)
            {
                if (node.Checked)
                {
                    if (node.Nodes.Count > 0) // Root Node has childs
                    {
                        CrossOutNodesContainer(node);
                        node.NodeFont = new Font(tvTasks.Font, FontStyle.Strikeout);
                    }
                    else // Root Node without childs
                        node.NodeFont = new Font(tvTasks.Font, FontStyle.Strikeout);
                }
                else
                {
                    CrossOutNodesContainer(node, false);
                }
            }
            SetPendingTasksNumber(PendingTasks - UpdateCompletedTasksNumberAfterCross());
            SetCompletedTasksNumber(UpdateCompletedTasksNumberAfterCross());
        }

        private void btCrossOutTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cross out task(s)?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.Cross;
            }
        }

        private void DeleteNodesContainer(TreeNode Container, Boolean DeleteAllNodes = true)
        {
            for (int i = Container.Nodes.Count - 1; i >= 0; i--)
            {
                UpdateTasksNumberAfterDelete(Container.Nodes[i]);

                if (!DeleteAllNodes)
                {
                    if (Container.Nodes[i].Checked)
                        Container.Nodes.RemoveAt(i);
                }
                else
                    Container.Nodes.RemoveAt(i);
            }
        }

        private void UpdateTasksNumberAfterDelete(TreeNode nodeToDelete)
        {
            if (nodeToDelete.NodeFont != null && nodeToDelete.NodeFont.Style == FontStyle.Strikeout)
                SetCompletedTasksNumber(CompletedTasks -= 1);
            else
                SetPendingTasksNumber(PendingTasks -= 1);
        }

        private void DeleteRootFromComboBox(TreeNode Root)
        {
            // Root.Text -> Current Root Node

            for (int i = 0; i < cbMajorTasks.Items.Count; i++)
            {
                if (Root.Text == cbMajorTasks.Items[i].ToString())
                {
                    cbMajorTasks.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void DeleteTasks()
        {
            if (tvTasks.Nodes.Count == 0)
            {
                MessageBox.Show("Tasks number is 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = tvTasks.Nodes.Count - 1; i >= 0; i--)
            {
                TreeNode node = tvTasks.Nodes[i];

                if (node.Checked)
                {
                    UpdateTasksNumberAfterDelete(node);
                    DeleteRootFromComboBox(node);
                    if (node.Nodes.Count > 0) // Root Node has childs
                    {
                        DeleteNodesContainer(node); // Delete Childs
                        tvTasks.Nodes.RemoveAt(i); // Delete Root
                    }

                    else
                        tvTasks.Nodes.RemoveAt(i); // Normal Root Node
                }

                else
                    // enter to Unchecked Root to clarify if it has a checked child(s) to delete
                    DeleteNodesContainer(node, false);
            }
        }

        private void btDeleteTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete task(s)?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.Delete;
            }
        }

        private void CheckAllNodesContainer(TreeNode Container, Boolean isChecked)
        {
            foreach(TreeNode node in Container.Nodes)
            {
                node.Checked = isChecked;
            }
        }

        private void CheckAllTasks()
        {
            foreach (TreeNode node in tvTasks.Nodes)
            {
                CheckAllNodesContainer(node, node.Checked = true);
            }
        }

        private void btCheckTree_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to check task(s)?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.CheckAll;
            }
        }

        private void UncheckAllTasks()
        {
            foreach (TreeNode node in tvTasks.Nodes)
            {
                CheckAllNodesContainer(node, node.Checked = false);
            }
        }

        private void btUncheckTree_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to uncheck task(s)?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.UncheckAll;
            }
        }

        private void ClearTasksList()
        {
            if (tvTasks.Nodes.Count == 0)
            {
                MessageBox.Show("Tasks number is 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvTasks.Nodes.Clear();
            SetPendingTasksNumber(0);
            SetCompletedTasksNumber(0);
        }

        private void btClearTree_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the list?", "Perform", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timer1.Start();
                CurrentOperation = Operation.Clear;
            }
        }
    }
}