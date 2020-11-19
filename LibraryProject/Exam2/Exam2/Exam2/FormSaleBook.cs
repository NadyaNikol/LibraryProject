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
    public partial class FormSaleBook : Form
    {
        LibraryEntities db = null;
        Books book = null;
        public FormSaleBook(Books book)
        {
            InitializeComponent();

            db = new LibraryEntities();
            this.book = book;

            txtbNameOfBook.Text = book.NameOfBook;
            txtbPrice.Text = (book.Price * 1.5m).ToString();

            cmbNameOfShop.DataSource = db.Shops.ToList();
            cmbNameOfShop.DisplayMember = "NameOfShop";
            cmbNameOfShop.ValueMember = "Id";
            txtbQuantity.Text = book.DravingOfBook.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtbNameOfBook.Text) && !String.IsNullOrEmpty(txtbPrice.Text) && !String.IsNullOrEmpty(cmbNameOfShop.Text) &&
                !String.IsNullOrEmpty(txtbQuantity.Text))
            {
                Sales sales = new Sales();

                sales.IdBook = book.Id;
                sales.IdShop = Convert.ToInt32(cmbNameOfShop.SelectedValue);
                sales.Price = Convert.ToDecimal(txtbPrice.Text);
                sales.Quantity = Convert.ToInt32(txtbQuantity.Text);

                if (sales.Quantity <= book.DravingOfBook)
                {
                    db.Sales.Add(sales);
                    await db.SaveChangesAsync();

                    DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("The selling price of a book cannot be less than the price of a book", "error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Fields cannot be empty");

        }

    }
}
