using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ChildForms.AdminChildForms.BookManagementChildForms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms
{
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Book Management";
        }

        private void OpenForm(Form form)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(form);
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {
            OpenForm(new ListBook());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            OpenForm(new AddBook());
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            OpenForm(new DeleteBook());
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateBook());
        }
    }
}
