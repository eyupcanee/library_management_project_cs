using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Interfaces;

namespace UserInterface.ChildForms.AdminChildForms.BookManagementChildForms
{
    public partial class ListBook : Form
    {
        public ListBook()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "List Book";
        }

        int selectedProcess = 4;

        private void FillDataGridView(int process = 4, string searchText = null)
        {
            if (!string.IsNullOrEmpty(searchText))
            {
                searchText.ToLower();
                BookManager bookManager = new BookManager(new BookDal());
                WriterManager writerManager = new WriterManager(new WriterDal());
                PublisherManager publisherManager = new PublisherManager(new PublisherDal());
                UserManager userManager = new UserManager(new UserDal());
                if (process == 0)
                {
                    var books = (from x in bookManager.GetByStatus(false)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books.Where(x => x.Name.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
                }
                else if (process == 1)
                {
                    var books = (from x in bookManager.GetByStatus(true)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books.Where(x => x.Name.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
                }
                else if (process == 2)
                {
                    Writer writer = new Writer();
                    writer = writerManager.GetByUserId(Convert.ToInt32(cbWriters.SelectedValue));
                    var books = (from x in bookManager.GetByWriter(writer)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books.Where(x => x.Name.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
                }
                else if (process == 3)
                {
                    Publisher publisher = new Publisher();
                    publisher.ID = Convert.ToInt32(cbPublishers.SelectedValue);
                    var books = (from x in bookManager.GetByPublisher(publisher)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books.Where(x => x.Name.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
                }
                else
                {
                    var books = (from x in bookManager.GetAll()
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books.Where(x => x.Name.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(searchText))).ToList();
                }
            }
            else
            {
                BookManager bookManager = new BookManager(new BookDal());
                WriterManager writerManager = new WriterManager(new WriterDal());
                PublisherManager publisherManager = new PublisherManager(new PublisherDal());
                UserManager userManager = new UserManager(new UserDal());
                if (process == 0)
                {
                    var books = (from x in bookManager.GetByStatus(false)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books;
                }
                else if (process == 1)
                {
                    var books = (from x in bookManager.GetByStatus(true)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books;
                }
                else if (process == 2)
                {
                    Writer writer = new Writer();
                    writer = writerManager.GetByUserId(Convert.ToInt32(cbWriters.SelectedValue));
                    var books = (from x in bookManager.GetByWriter(writer)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books;
                }
                else if (process == 3)
                {
                    Publisher publisher = new Publisher();
                    publisher.ID = Convert.ToInt32(cbPublishers.SelectedValue);
                    var books = (from x in bookManager.GetByPublisher(publisher)
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books;
                }
                else
                {
                    var books = (from x in bookManager.GetAll()
                                 select new
                                 {
                                     x.ID,
                                     x.Name,
                                     Writer = userManager.GetById(writerManager.GetById(x.WriterID).UserID).FirstName + " " + userManager.GetById(writerManager.GetById(x.WriterID).UserID).LastName,
                                     Publisher = publisherManager.GetById(x.PublisherID).PName,
                                     x.Page,
                                     x.Status
                                 }).ToList();
                    dgvBooks.DataSource = books;
                }
            }
        }

        private void ListBook_Load(object sender, EventArgs e)
        {
            FillDataGridView();

            //cbStatus
            List<bool> boolVeriables = new List<bool> { true, false };
            foreach (var item in boolVeriables)
            {
                cbStatus.Items.Add(item);
            }
            cbStatus.SelectedItem = null;
            //cbStatusEnd

            //cbWriters
            UserManager userManager = new UserManager(new UserDal());
            var writers = (from x in userManager.GetByAuthority(3)
                           select new
                           {
                               x.ID,
                               Name = x.FirstName + " " + x.LastName
                           }).ToList();
            cbWriters.DataSource = writers;
            cbWriters.ValueMember = "ID";
            cbWriters.DisplayMember = "Name";
            cbWriters.SelectedItem = null;
            //cbWritersEnd

            //cbPublishers
            PublisherManager publisherManager = new PublisherManager(new PublisherDal());
            var publishers = (from x in publisherManager.GetAll()
                              select new
                              {
                                  x.ID,
                                  x.PName
                              }).ToList();
            cbPublishers.DataSource = publishers;
            cbPublishers.ValueMember = "ID";
            cbPublishers.DisplayMember = "PName";
            cbPublishers.SelectedItem = null;
            //cbPublishersEnd
        }

        private void btnListByWriter_Click(object sender, EventArgs e)
        {
            if(cbWriters.SelectedItem != null)
            {
                selectedProcess = 2;
                FillDataGridView(selectedProcess);
            }
            else
            {
                MessageBox.Show("You Haven't Selected an Writer!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnListByPublisher_Click(object sender, EventArgs e)
        {
            if(cbPublishers.SelectedItem != null)
            {
                selectedProcess = 3;
                FillDataGridView(selectedProcess);
            }
            else
            {
                MessageBox.Show("You Haven't Selected an Publisher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListByStatus_Click(object sender, EventArgs e)
        {
            if(cbStatus.SelectedItem != null)
            {
                if(Convert.ToBoolean(cbStatus.SelectedItem) == false)
                {
                    selectedProcess = 0;
                    FillDataGridView(selectedProcess);
                }
                else
                {
                    selectedProcess = 1;
                    FillDataGridView(selectedProcess);
                }
            }
            else
            {
                MessageBox.Show("You Haven't Selected an Status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            selectedProcess = 4;
            FillDataGridView();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<AdminInterface>().Single();
            mainForm.OpenChildForm(new BookManagement());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView(selectedProcess, txtSearch.Text);
        }
    }
}
