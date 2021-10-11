using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.LoginForms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            btnHidePassword.Visible = false;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPasswordAgain.PasswordChar = '\0';
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPasswordAgain.PasswordChar = '*';
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
        }

        private bool RecControl()
        {
            UserManager userManager = new UserManager(new UserDal());
            var users = userManager.GetAll();
            bool isThere = false;

            foreach(var user in users)
            {
                if(user.Username == txtUsername.Text)
                {
                    isThere = true;
                    break;
                }
            }

            return isThere;
        }

        private void AddUser(int autID)
        {
            UserManager userManager = new UserManager(new UserDal());
            User user = new User();

            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.FirstName = txtFName.Text;
            user.LastName = txtLName.Text;
            user.AuthorityID = autID;
            user.Status = true;

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                user.Email = txtEmail.Text;
            }
            if (!string.IsNullOrEmpty(txtGsm.Text))
            {
                user.Gsm = txtGsm.Text;
            }

            userManager.Add(user);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) & !string.IsNullOrEmpty(txtPassword.Text) & !string.IsNullOrEmpty(txtPasswordAgain.Text) &
                    !string.IsNullOrEmpty(txtFName.Text) & !string.IsNullOrEmpty(txtLName.Text))
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
                {
                    if(!RecControl())
                    {
                        if (chbWriter.Checked)
                        {
                            UserManager userManager = new UserManager(new UserDal());
                            WriterManager writerManager = new WriterManager(new WriterDal());
                            Writer writer = new Writer();

                            AddUser(3);

                            writer.UserID = userManager.GetLastUser().ID;
                            writer.Confirmation = false;
                            writer.Status = true;

                            writerManager.Add(writer);

                            MessageBox.Show("Writer addition successful!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Close();
                            Form form = new Login();
                            form.Show();
                        }
                        else
                        {
                            AddUser(2);
                            MessageBox.Show("User addition successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                            Form form = new Login();
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Already Using!Try another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = string.Empty;
                    txtPasswordAgain.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Username,Password,PasswordAgain,FirstName and LastName Can Not Be Left Blank!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new Login();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
