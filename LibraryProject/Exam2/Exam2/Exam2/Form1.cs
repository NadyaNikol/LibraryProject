using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Exam2
{
    public partial class Form1 : Form
    {
        LibraryEntities db = null;
        public Form1()
        {
            InitializeComponent();

            db = new LibraryEntities();

        }

        private void checkBoxRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnAddNewUser.Visible)
                btnAddNewUser.Visible = true;
            else
                btnAddNewUser.Visible = false;
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {

            var isLogin = await db.Info.Where(i => i.Login == txtbLogin.Text && i.Password == txtbPassword.Text).FirstOrDefaultAsync();

            if (isLogin != null)
            {
                FormLibrary fl = new FormLibrary();
                fl.ShowDialog();

            }
            else MessageBox.Show("Incorrect login or password", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void btnAddNewUser_Click(object sender, EventArgs e)
        {

            Info info = new Info();
            FormAddNewUser fau = new FormAddNewUser(info);

            if (fau.ShowDialog() == DialogResult.OK)
            {
                db.Info.Add(info);
                await db.SaveChangesAsync();

                MessageBox.Show("User was added");
            }
            else return;

        }
    }

   
}


