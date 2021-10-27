using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    public partial class UpdateWriter : Form
    {
        public UpdateWriter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Update Writer";
        }


        private void FillDataGridView()
        {
            WriterManager writerManager = new WriterManager(new WriterDal());
            var writers = (from x in writerManager.GetAll()
                           select new
                           {
                               x.ID,
                               x.UserID,
                               x.Confirmation,
                               x.Status
                           }).ToList();
            dgvWriters.DataSource = writers;
        }

        private void UpdateWriter_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            //cbStatus&cbConfirmations
            List<bool> bools = new List<bool> { true, false };
            foreach(var item in bools)
            {
                cbStatus.Items.Add(item);
                cbConfirmations.Items.Add(item);
            }
            cbStatus.SelectedItem = null;
            cbConfirmations.SelectedItem = null;
            //cbStatus&cbConfirmationsEnd
        }

        private void dgvWriters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWriterID.Text = dgvWriters.CurrentRow.Cells[0].Value.ToString();
            WriterManager writerManager = new WriterManager(new WriterDal());
            var writer = writerManager.GetById(Convert.ToInt32(txtWriterID.Text));
            cbConfirmations.SelectedItem = writer.Confirmation;
            cbStatus.SelectedItem = writer.Status;
        }

        private void btnUpdateWriter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtWriterID.Text))
            {
                WriterManager writerManager = new WriterManager(new WriterDal());
                Writer writer = new Writer();
                writer = writerManager.GetById(Convert.ToInt32(txtWriterID.Text));
                writer.Confirmation = Convert.ToBoolean(cbConfirmations.SelectedItem);
                writer.Status = Convert.ToBoolean(cbStatus.SelectedItem);
                writerManager.Update(writer);
                UserManager userManager = new UserManager(new UserDal());
                var user = userManager.GetById(writer.UserID);
                user.Status = Convert.ToBoolean(cbStatus.SelectedItem);
                userManager.Update(user);
                MessageBox.Show("Writer Updating Succesful!", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView();
            }
            else
            {
                MessageBox.Show("You Must Select A Writer In Grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new WriterManagement());
        }

        private void btnUpdateWriterDetails_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWriterID.Text))
            {
                WriterManager writerManager = new WriterManager(new WriterDal());
                Writer writer = new Writer();
                writer = writerManager.GetById(Convert.ToInt32(txtWriterID.Text));
                Form form = new UpdateWriterDetails(writer.UserID);
                form.Show();
            }
            else
            {
                MessageBox.Show("You Must Select A Writer In Grid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
