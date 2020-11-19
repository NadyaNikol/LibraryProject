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
    public partial class FormAddNewUser : Form
    {
        Info info = null;
        public FormAddNewUser(Info info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtbLogin.Text) && !String.IsNullOrEmpty(txtbPassword.Text))
            {
                info.Login = txtbLogin.Text;
                info.Password = txtbPassword.Text;
                DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("Fields cannot be empty");
        }
    }
}
