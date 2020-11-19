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
    public partial class FormPutOff : Form
    {
        LibraryEntities db = null;
        Books book = null;
        public FormPutOff(Books book)
        {
            InitializeComponent();

            db = new LibraryEntities();
            this.book = book;

            txtbNameOfBook.Text = book.NameOfBook;
           
            cmbLogin.DataSource = db.Info.ToList();
            cmbLogin.DisplayMember = "Login";
            cmbLogin.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtbNameOfBook.Text) && !String.IsNullOrEmpty(cmbLogin.Text) && !String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                PendingBooks pending = new PendingBooks();

                pending.IdBook = book.Id;
                pending.IdInfo = Convert.ToInt32(cmbLogin.SelectedValue);
                pending.ExpirationDate = dateTimePicker1.Value;

                try
                {
                    db.PendingBooks.Add(pending);
                    await db.SaveChangesAsync();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception) { MessageBox.Show("the specified date cannot be less than or equal to the current date", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else MessageBox.Show("Fields cannot be empty");


        }
    }
}
