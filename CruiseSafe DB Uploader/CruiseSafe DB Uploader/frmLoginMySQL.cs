using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafe_DB_Uploader
{
    public partial class frmLoginMySQL : Form
    {
        public string Username = "";
        public string Password = "";

        public frmLoginMySQL()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Username = tbUsername.Text;
            Password = tbPassword.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
