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
    public partial class FormPublishBook : Form
    {
        LibraryEntities db = null;
        Books book = null;

        public FormPublishBook(Books b)
        {
            InitializeComponent();

            db = new LibraryEntities();
            book = b;

            FillComboboxPublishing();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbNamePubHouse.Text) && !String.IsNullOrEmpty(dtpDatePublishing.Text))
            {
                book.IdPublishingHouses = Convert.ToInt32(cmbNamePubHouse.SelectedValue);
                book.DateOfPublish = dtpDatePublishing.Value;
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Fields cannot be empty");
        }

        private async void FillComboboxPublishing()
        {
            await db.PublishingHouses.LoadAsync();
            List<PublishingHouses> publishings = db.PublishingHouses.Local.ToList();
            cmbNamePubHouse.DataSource = null;
            cmbNamePubHouse.DataSource = publishings;
            cmbNamePubHouse.DisplayMember = "NameOfPublishingHouse";
            cmbNamePubHouse.ValueMember = "Id";

            cmbNamePubHouse.SelectedIndex = 0;
        }

    }
}
