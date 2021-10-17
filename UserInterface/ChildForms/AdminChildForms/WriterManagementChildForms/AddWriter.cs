using Business.Concrete;
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

namespace UserInterface.ChildForms.AdminChildForms.WriterManagementChildForms
{
    public partial class AddWriter : Form
    {
        public AddWriter()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Text = "Add Writer";
        }

        

        private void AddWriter_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
