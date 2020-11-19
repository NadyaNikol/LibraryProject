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
    public partial class FormTable : Form
    {
        LibraryEntities db = null;

        public FormTable()
        {
            InitializeComponent();
            db = new LibraryEntities();

            FillDGVDecomisBooks();
            FillDGVPendBooks();
            FillDGVStocksBooks();
            FillDGVContinueBook();
        }

        private async void FillDGVDecomisBooks()
        {
            List<DecommissionedBooks> dec = await db.DecommissionedBooks.ToListAsync();

            var decom = dec.Join(db.Books, d => d.IdBook, b => b.Id, (d, b) => new
            {
                Name_of_book = b.NameOfBook,
                Date = d.DateOfDecommissioned.ToShortDateString()
            }).ToList();

            dgvDecomBooks.DataSource = null;
            dgvDecomBooks.DataSource = decom;
        }

        private void FillDGVPendBooks()
        {
            List<PendingBooks> pen = db.PendingBooks.ToList();

            var pend = (from p in pen
                         join b in db.Books on p.IdBook equals b.Id
                         join i in db.Info on p.IdInfo equals i.Id
                         select new
                         {
                            Login = i.Login,
                            Name_of_book = b.NameOfBook,
                            Date = p.ExpirationDate
                         }).ToList();

            dgvPendBooks.DataSource = null;
            dgvPendBooks.DataSource = pend;
        }

        private async void FillDGVContinueBook()
        {
            List<ContinuationBook> continuations = await db.ContinuationBook.ToListAsync();

            var fbook = (from c in continuations
                         join b1 in db.Books on c.IdBook equals b1.Id
                         join b2 in db.Books on c.IdBook2 equals b2.Id
                         select new
                         {
                             NameOfBook = b1.NameOfBook,
                             Continuation_book = b2.NameOfBook
                         }).ToList();

            dgvContinueBook.DataSource = null;
            dgvContinueBook.DataSource = fbook;

        }

        private async void FillDGVStocksBooks()
        {
            List<Stocks> stocks =await db.Stocks.ToListAsync();

            var fbook = stocks.Join(db.Books, s => s.IdBook, b => b.Id, (s, b) => new
            {
                NameOfBook = b.NameOfBook
            }).ToList();

            dgvStocksBooks.DataSource = null;
            dgvStocksBooks.DataSource = fbook;
        }
    }
}
