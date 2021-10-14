using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ChildForms.AdminChildForms.UserManagamentChildForms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms
{
    public partial class UserManagament : Form
    {
        public UserManagament()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "User Management";
        }

        private void OpenForm(Form form)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(form);
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            OpenForm(new ListUser());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            OpenForm(new AddUser());
        }
    }
}
