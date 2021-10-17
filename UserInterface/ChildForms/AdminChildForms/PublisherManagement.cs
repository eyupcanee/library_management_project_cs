using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.ChildForms.AdminChildForms.PublisherManagementChildForms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms
{
    public partial class PublisherManagement : Form
    {
        public PublisherManagement()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Publisher Management";
        }

        private void OpenForm(Form form)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            Close();
            mainForm.OpenChildForm(form);
        }

        private void btnListPublisher_Click(object sender, EventArgs e)
        {
            OpenForm(new ListPublisher());
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            OpenForm(new AddPublisher());
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            OpenForm(new DeletePublisher());
        }

        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdatePublisher());
        }
    }
}
