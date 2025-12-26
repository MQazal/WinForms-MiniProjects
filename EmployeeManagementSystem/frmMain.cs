using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmployeeManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[5];
            SetTextBox(txtUsername, "Enter Username...", Color.Gray);
            SetTextBox(txtPassword, "Enter Password...", Color.Gray);
            SetupUserImage();
            SetupPasswordImage();
        }

        private void SetupUserImage()
        {
            pbxUser.Size = new Size(50, 50);
            pbxUser.Image = imageList1.Images[1];
            pbxUser.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SetupPasswordImage()
        {
            pbxPassword.Size = new Size(50, 50);
            pbxPassword.Image = imageList1.Images[2];
            pbxPassword.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ShowPassword()
        {
            pbxPassword.Image = imageList1.Images[3];
            txtPassword.PasswordChar = '\0';
            pbxPassword.Tag = "Show";
        }

        private void HidePassword()
        {
            pbxPassword.Image = imageList1.Images[2];
            txtPassword.PasswordChar = '*';
            pbxPassword.Tag = "Hidden";
        }

        private void SetPasswordVisibility(object sender, MouseEventArgs e)
        {
            if (pbxPassword.Tag.ToString() == "Hidden")
                ShowPassword();
            else
                HidePassword();
        }

        private void SetTextBox(TextBox box, string DefaultText, Color DefaultTextColor)
        {
            box.Text = DefaultText;
            box.ForeColor = DefaultTextColor;
        }

        private void SetUsernameBox(TextBox Username)
        {
            if(Username.Text == "Enter Username...")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void SetPasswordBox(TextBox Password)
        {
            if (Password.Text == "Enter Password...")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                Password.PasswordChar = '*';
            }
        }

        private void StartTyping(object sender, EventArgs e)
        {
            if ((TextBox)sender == txtUsername)
            {
                SetUsernameBox(txtUsername);
            }
            else
            {
                SetPasswordBox(txtPassword);
            }
        }

        private void FinishTyping(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "" && box == txtUsername)
            {
                SetTextBox(txtUsername, "Enter Username...", Color.Gray);
                return;
            }

            if (box.Text == "" && box == txtPassword)
            {
                SetTextBox(txtPassword, "Enter Password...", Color.Gray);
                txtPassword.PasswordChar = '\0';
            }
        }

        private bool IsValidAccount(string Username, string Password)
        {
            return (Username == txtUsername.Text) && (Password == txtPassword.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidAccount(txtUsername.Tag.ToString(), txtPassword.Tag.ToString()))
            {
                this.Hide(); // Login form will be saved in memeory for Logout Feature again
                frmEmployeeManagement management = new frmEmployeeManagement();
                management.Show();
            }
            else
                MessageBox.Show("Invalid Login,\ntry again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}