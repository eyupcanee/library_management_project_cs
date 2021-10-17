using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ChildForms.AdminChildForms.BorrowedBookManagementChildForms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms
{
    public partial class BorrowedBookManagement : Form
    {
        public BorrowedBookManagement()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Borrowed Book Management";
        }

        private void OpenForm(Form form)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(form);
        }

        private void btnListBBook_Click(object sender, EventArgs e)
        {
            OpenForm(new ListBorrowedBook());
        }

        private void btnAddBBook_Click(object sender, EventArgs e)
        {
            OpenForm(new AddBorrowedBook());
        }

        private void btnDeliverBBook_Click(object sender, EventArgs e)
        {
            OpenForm(new DeleteBorrowedBook());
        }

        private void btnUpdateBBook_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateBorrowedBook());
        }
    }
}
