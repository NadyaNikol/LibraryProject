using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class FormAddNewAuthor : Form
    {
        Authors authors = null;
        public FormAddNewAuthor( Authors authors)
        {
            InitializeComponent();
            this.authors = authors;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtbFN.Text) && !String.IsNullOrEmpty(txtbLN.Text))
            {
                authors.FirstName = txtbFN.Text;
                authors.LastName = txtbLN.Text;
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Fields cannot be empty");
        }
    }
}
