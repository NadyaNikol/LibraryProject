using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class formAddNewBook : Form
    {
        LibraryEntities db = null;
        Books book = null;
        public int IdNextBook { get; set; }

        public formAddNewBook(Books book)
        {
            InitializeComponent();

            this.book = book;

            db = new LibraryEntities();


            FillComboboxAuthors();
            FillComboboxThemes();



            txtbNameOfBook.Text = book.NameOfBook;
            txtbPrice.Text = book.Price.ToString();
            txtbAmountPages.Text = book.AmountPages.ToString();
            cmbTheme.SelectedText = book.IdTheme.ToString();
            cmbAuthor.SelectedText = book.IdAuthor.ToString();
            txtbDrawingOfBook.Text = book.DravingOfBook.ToString();
                     

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtbNameOfBook.Text) && !String.IsNullOrEmpty(txtbPrice.Text) && !String.IsNullOrEmpty(txtbAmountPages.Text) &&
                !String.IsNullOrEmpty(cmbAuthor.Text) && !String.IsNullOrEmpty(cmbTheme.Text) && !String.IsNullOrEmpty(txtbDrawingOfBook.Text))
            {
                book.NameOfBook = txtbNameOfBook.Text;
                book.Price = Convert.ToDecimal(txtbPrice.Text);
                book.AmountPages = Convert.ToInt32(txtbAmountPages.Text);
                book.IdTheme = Convert.ToInt32(cmbTheme.SelectedValue);
                book.IdAuthor = Convert.ToInt32(cmbAuthor.SelectedValue);
                book.DravingOfBook = Convert.ToInt32(txtbDrawingOfBook.Text);

                if (cbNextBook.Checked)
                    IdNextBook = Convert.ToInt32(cbBookContinue.SelectedValue);
                else IdNextBook = -1;

                DialogResult = DialogResult.OK;

            }
            else MessageBox.Show("Fields cannot be empty");
        }

        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            Authors author = new Authors();
            FormAddNewAuthor faa = new FormAddNewAuthor(author);

            if (faa.ShowDialog() == DialogResult.OK)
            {
                db.Authors.Add(author);
                await db.SaveChangesAsync();

                FillComboboxAuthors();

                cmbAuthor.Update();
                cmbAuthor.Refresh();
            }
            else return;
        }

        private void FillComboboxAuthors()
        {
            db.Authors.Load();
            List<Authors> authors = db.Authors.Local.ToList();
            cmbAuthor.DataSource = null;
            cmbAuthor.DataSource = authors;
            cmbAuthor.DisplayMember = "FirstName";
            cmbAuthor.ValueMember = "Id";
        }

        private void FillComboboxThemes()
        {
            db.Themes.Load();
            List<Themes> themes = db.Themes.Local.ToList();
            cmbTheme.DataSource = null;
            cmbTheme.DataSource = themes;
            cmbTheme.DisplayMember = "NameOfTheme";
            cmbTheme.ValueMember = "Id";
        }

        private async void cbNextBook_CheckedChanged(object sender, EventArgs e)
        {
            if(cbNextBook.Checked)
            {
                cbBookContinue.Visible = true;
                lblNameNextBook.Visible = true;
                cbBookContinue.DataSource = null;
                cbBookContinue.DataSource =await db.Books.ToListAsync();
                cbBookContinue.DisplayMember = "NameOfBook";
                cbBookContinue.ValueMember = "Id";
            }
            else
            {
                cbBookContinue.Visible = false;
                lblNameNextBook.Visible = false;
            }
        }
    }
}
