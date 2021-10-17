using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms
{
    public partial class WriterManagement : Form
    {     
        public WriterManagement()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Writer Management";
        }

        private void OpenForm(Form form)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(form);
        }

        private void btnListWriter_Click(object sender, EventArgs e)
        {
            OpenForm(new ListWriter());
        }

        private void btnAddWriter_Click(object sender, EventArgs e)
        {
            OpenForm(new AddWriter());
        }

        private void btnDeleteWriter_Click(object sender, EventArgs e)
        {
            OpenForm(new DeleteWriter());
        }

        private void btnUpdateWriter_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateWriter());
        }
    }
}
