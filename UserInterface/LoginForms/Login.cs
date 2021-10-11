using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
using UserInterface.Interfaces;

namespace UserInterface.LoginForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public static int nowId;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnHidePassword.Visible = false;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btnHidePassword.Visible = true;
            btnShowPassword.Visible = false;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            btnHidePassword.Visible = false;
            btnShowPassword.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text) & !string.IsNullOrEmpty(txtPassword.Text))
            {
                UserManager userManager = new UserManager(new UserDal());
                var users = userManager.GetAll();
                bool isThere = false;

                foreach(var user in users)
                {
                    if(txtUsername.Text == user.Username & txtPassword.Text == user.Password)
                    {
                        isThere = true;
                        nowId = user.ID;
                        break;
                    }
                }
                
                if(isThere)
                {
                    var nowUser = userManager.GetById(nowId);
                    if(nowUser.Status)
                    {
                        if(nowUser.AuthorityID == 1)
                        {
                            Hide();
                            Form form = new AdminInterface();
                            form.Show();
                        }
                        else if(nowUser.AuthorityID == 2)
                        {
                            Hide();
                            Form form = new AUserInterface();
                            form.Show();
                        }
                        else if(nowUser.AuthorityID == 3)
                        {
                            WriterManager writerManager = new WriterManager(new WriterDal());
                            var writers = writerManager.GetAll();
                            bool wControl = false;
                            int nowWriterID = 0;

                            foreach (var writer in writers)
                            {
                                if (nowUser.ID == writer.UserID)
                                {
                                    wControl = true;
                                    nowWriterID = Convert.ToInt32(writer.ID);
                                    break;
                                }
                            }

                            if (wControl)
                            {
                                var nowWriter = writerManager.GetById(nowWriterID);
                                if (nowWriter.Confirmation == true)
                                {
                                    Hide();
                                    Form form = new WriterInterface();
                                    form.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Your Writer Subscription Has Not Been Approved Yet. Please Try Again After Confirmation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your membership has been deleted or deactivated. Contact Admin", "We Are Sorry...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect.Try Again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Username or Password cannot be left blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Hide();
            Form form = new SignUp();
            form.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
