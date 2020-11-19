using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections;

namespace Exam2
{
    public partial class FormLibrary : Form
    {
        LibraryEntities db = null;
        List<Books> books = null;

        public FormLibrary()
        {
            InitializeComponent();
        }

        private async void FormLibrary_Load(object sender, EventArgs e)
        {
            db = new LibraryEntities();

            VizualizationListView();

            books = await db.Books.ToListAsync();

            FillListView(books);
            FillComboboxPeriod();
            FillComboboxChoose();
            FillComboboxSearch();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvBooks.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvBooks.View = View.LargeIcon;
        }

        private void FillListView(List<Books> b)
        {

            lvBooks.Items.Clear();

            List<Authors> authors = db.Authors.ToList();
            List<Themes> themes =  db.Themes.ToList();
            List<PublishingHouses> publishings =  db.PublishingHouses.ToList();
            List<Sales> sales =  db.Sales.ToList();


            for (int i = 0; i < b.Count; i++)
            {
                ListViewItem li = new ListViewItem(b[i].NameOfBook);

                li.SubItems.Add(b[i].Id.ToString());

                var author = authors.Where(a => a.Id == b[i].IdAuthor).FirstOrDefault();
                if (author != null)
                    li.SubItems.Add(author.FirstName + " " + author.LastName);

                var theme = themes.Where(t => t.Id == b[i].IdTheme).FirstOrDefault();
                if (theme != null)
                    li.SubItems.Add(theme.NameOfTheme);

                li.SubItems.Add(b[i].Price.ToString());
                li.SubItems.Add(b[i].AmountPages.ToString());

                li.SubItems.Add(b[i].DateOfPublish.ToShortDateString());

                li.SubItems.Add(b[i].DravingOfBook.ToString());

                var sale = sales.Where(d => d.IdBook == b[i].Id).FirstOrDefault();
                if(sale!=null)
                li.SubItems.Add(sale.Quantity.ToString());
                else
                    li.SubItems.Add(Convert.ToString(0));

                li.ImageIndex = 0;

                lvBooks.Items.Add(li);
            }  

        }

        private void VizualizationListView()
        {
            ImageList il = new ImageList();
            il.ImageSize = new Size(70, 70);
            il.Images.Add(new Bitmap("book.bmp"));
            lvBooks.LargeImageList = il;

            List<string> listColumns = new List<string> { "Name of book", "Id Book", "FIO Author",
                "Theme", "Price", "Amount pages", "Date of publish", "Drawing of book","Quantity of sale"};

            for (int i = 0; i < listColumns.Count; i++)
            {
                lvBooks.Columns.Add(listColumns[i]);
                lvBooks.Columns[i].Width = 85;
            }
        }

        private void FillComboboxPeriod()
        {
            string[] name = { "all", "day", "week", "mounth", "year" };
            comboBoxPeriod.Items.AddRange(name);
            comboBoxPeriod.SelectedIndex = 0;
        }

        private void FillComboboxSearch()
        {
            string[] name = { "Name of book", "FIO Author", "Theme"};
            comboBoxSearch.Items.AddRange(name);
            comboBoxSearch.SelectedIndex = 0;
        }

        private void FillComboboxChoose()
        {
            string[] name = { "all", "popular" };
            cmbChoose.Items.AddRange(name);
            cmbChoose.SelectedIndex = 0;
        }

        private async void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            formAddNewBook fab = new formAddNewBook(book);

            if (fab.ShowDialog() == DialogResult.OK)
            {
                db.Books.Add(book);

                FormPublishBook pb = new FormPublishBook(book);
                if (pb.ShowDialog() == DialogResult.OK)
                {
                    await db.SaveChangesAsync();

                    if (fab.IdNextBook > 0)
                    {
                        ContinuationBook cbook = new ContinuationBook { IdBook = book.Id, IdBook2 = fab.IdNextBook };

                        db.ContinuationBook.Add(cbook);
                        await db.SaveChangesAsync();
                         
                    }

                    lvBooks.Update();
                    lvBooks.Refresh();
                    FillListView(books);
                }
            }
        }

        private async void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvBooks.SelectedIndices != null)
            {
               Books book = await FindBook();

                formAddNewBook fab = new formAddNewBook(book);

                if (fab.ShowDialog() == DialogResult.OK)
                {
                    // db.Books.Add(book);
                    db.SaveChanges();
                    lvBooks.Update();
                    lvBooks.Refresh();

                    FillListView(books);

                    MessageBox.Show("Book was changed");
                }
            }
        }

        private async Task<Books> FindBook()
        {
            bool isAll = false;

            int id = 0;

            for (int i = 0; i < lvBooks.Columns.Count; i++)
            {
                if (!isAll)
                {
                    if (lvBooks.Columns[i].Index == 1)
                    {
                        for (int j = 0; j < lvBooks.Items.Count; j++)
                        {
                            if (lvBooks.Items[j].Selected)
                            {
                                id = Convert.ToInt32(lvBooks.Items[j].SubItems[1].Text);
                                isAll = true;
                                break;
                            }


                        }

                    }
                }
                else break;


            }


            Books book = await db.Books.FindAsync(id);
            return book;
        }


        private void comboBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPeriod.SelectedIndex != -1)
            {

                switch (comboBoxPeriod.SelectedItem)
                {
                    case "all": FillListView(books); break;
                    case "day":
                        {
                            var book = books.Where(b => (DateTime.Now.Date - b.DateOfPublish).TotalDays <= 1).ToList();

                            FillListView(book);
                            break;
                        }
                    case "week":
                        {
                            var book = books.Where(b => (DateTime.Now.Date - b.DateOfPublish).TotalDays <= 7).ToList();

                            FillListView(book);
                            break;
                        }
                    case "mounth":
                        {
                            var book = books.Where(b => (DateTime.Now.Date - b.DateOfPublish).TotalDays <= 31).ToList();

                            FillListView(book);
                            break;
                        }
                    case "year":
                        {
                            var book = books.Where(b => (DateTime.Now.Date - b.DateOfPublish).TotalDays <= 365).ToList();

                            FillListView(book);
                            break;
                        }
                    default:
                        break;


                }
            }
        }


        private void FillLVPopular()
        {
            var items = (from b in db.Books
                         join s in db.Sales on b.Id equals s.IdBook
                         group s by new { b.NameOfBook, s.IdBook, b.IdAuthor, b.IdTheme, s.Price,
                             b.DateOfPublish, b.AmountPages, b.DravingOfBook } into gr
                         join a in db.Authors on gr.Key.IdAuthor equals a.Id
                         join t in db.Themes on gr.Key.IdTheme equals t.Id
                         select new
                         {
                             gr.Key.NameOfBook,
                             Id_book = gr.Key.IdBook,
                             FN = a.FirstName,
                             LN = a.LastName,
                             Theme = t.NameOfTheme,
                             Price = gr.Key.Price,
                             AmountPages = gr.Key.AmountPages,
                             Date_of_publish = gr.Key.DateOfPublish,
                             DrawingOfBook = gr.Key.DravingOfBook,
                             MaxSales = gr.Sum(g => g.Quantity)
                         }).OrderByDescending(x => x.MaxSales).Take(5).ToList();



            lvBooks.Items.Clear();


            for (int i = 0; i < items.Count; i++)
            {
                ListViewItem li = new ListViewItem(items[i].NameOfBook);

                li.SubItems.Add(items[i].Id_book.ToString());
                li.SubItems.Add(items[i].FN + " " + items[i].LN);
                li.SubItems.Add(items[i].Theme);
                li.SubItems.Add(items[i].Price.ToString());
                li.SubItems.Add(items[i].AmountPages.ToString());
                li.SubItems.Add(items[i].Date_of_publish.ToShortDateString());
                li.SubItems.Add(items[i].DrawingOfBook.ToString());
                li.SubItems.Add(items[i].MaxSales.ToString());

                li.ImageIndex = 0;

                lvBooks.Items.Add(li);
            }
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbChoose.SelectedItem)
            {
                case "all": { FillListView(books); break; }
                case "popular":{FillLVPopular(); break; }

                default:
                    break;
            }
        }


        private void txtbSearch_Click(object sender, EventArgs e)
        {
            comboBoxSearch.Visible = true;
        }

        private void infoAboutBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTable ft = new FormTable();
            ft.Show();
        }

        private async void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Books book = await FindBook();
            FormSaleBook fsb = new FormSaleBook(book);

            if(fsb.ShowDialog() == DialogResult.OK)
            {
                
                    lvBooks.Update();
                    lvBooks.Refresh();

                    FillListView(books);

                    MessageBox.Show("Book was sale");
            }
        }

        private async void putOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = await FindBook();
            FormPutOff fpo = new FormPutOff(book);

            if (fpo.ShowDialog() == DialogResult.OK)
            {

                  MessageBox.Show("Book was put off");
                
            }

        }

        private async void writeOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = await  FindBook();

            DecommissionedBooks dec = new DecommissionedBooks
            {
                IdBook = book.Id,
                DateOfDecommissioned = DateTime.Now.Date
            };

            db.DecommissionedBooks.Add(dec);
            await db.SaveChangesAsync();

            MessageBox.Show("Book was write off");
        }

        private async void addToChareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = await  FindBook();

            Stocks stock = new Stocks { IdBook = book.Id };

            try
            {
                db.Stocks.Add(stock);
                await db.SaveChangesAsync();

                MessageBox.Show("Book was added to share");
            }
            catch (Exception) { MessageBox.Show("This book was added early", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);}
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillListView(books);
            if (!String.IsNullOrEmpty(txtbSearch.Text))
            {
                for (int i = 0; i < lvBooks.Columns.Count; i++)
                {
                    if (comboBoxSearch.Text == lvBooks.Columns[i].Text)
                    {
                        for (int j = 0; j < lvBooks.Items.Count; j++)
                        {
                            if (lvBooks.Items[j].SubItems[i].Text != txtbSearch.Text)
                            {
                                lvBooks.Items.RemoveAt(j);
                                j--;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void lvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                if(menu.Text=="Book")
                {
                    foreach (ToolStripItem b in menu.DropDownItems)
                    {
                        if (b.Text != "Add new")
                            b.Enabled = true;
                    }
                    break;
                }
            }
        }

        private void lvBooks_Leave(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menu in menuStrip1.Items)
            {
                if (menu.Text == "Book")
                {
                    foreach (ToolStripItem b in menu.DropDownItems)
                    {
                        if (b.Text != "Add new")
                            b.Enabled = false;
                    }
                    break;
                }
            }
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbSearch.Text))
                FillListView(books);
        }
    }

}
