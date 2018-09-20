using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafe_DB_Uploader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "hex-File (*.hex)|*.hex|zip-File (*.zip)|*.zip";
            OFD.RestoreDirectory = true;

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = OFD.FileName;
            }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            if (tbVersion.Text == "")
                return;
            if (tbChangelog.Text == "")
                return;
            if (tbFile.Text == "")
                return;

            frmLoginMySQL frmLogin = new frmLoginMySQL();

            if(frmLogin.ShowDialog() == DialogResult.OK)
            {
                FileInfo FI = new FileInfo(tbFile.Text);
                if (FI.Extension.ToUpper() == ".HEX")
                    UploadFirmwareFile(tbVersion.Text, tbChangelog.Text, FI, frmLogin.Username, frmLogin.Password);
                else if (FI.Extension.ToUpper() == ".ZIP")
                    UploadWindowsVersion(tbVersion.Text, tbChangelog.Text, FI, frmLogin.Username, frmLogin.Password);
            }
        }

        private void UploadWindowsVersion(string Version, string Changelog, FileInfo File, string Username, string Password)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "dedivirt134.your-server.de";
                builder.Database = "cruisesafe";
                builder.UserID = Username;
                builder.Password = Password;
                builder.ConnectionTimeout = 10;

                MySqlConnection conn = new MySqlConnection(builder.ToString());

                string sqlCMD = "INSERT INTO WIN_VERSIONS (VERSION_NO, CHANGELOG, PAYLOAD, DATE_OF_RELEASE) " +
                    "VALUES (@VERSION_NO, @CHANGELOG, @PAYLOAD, @DATE_OF_REALEASE)";

                MySqlCommand CMD = new MySqlCommand(sqlCMD, conn);
                CMD.Parameters.Add("@VERSION_NO", MySqlDbType.VarChar);
                CMD.Parameters["@VERSION_NO"].Value = Version;
                CMD.Parameters.Add("@CHANGELOG", MySqlDbType.VarChar);
                CMD.Parameters["@CHANGELOG"].Value = Changelog;
                CMD.Parameters.Add("@PAYLOAD", MySqlDbType.MediumBlob);
                CMD.Parameters["@PAYLOAD"].Value = System.IO.File.ReadAllBytes(File.FullName);
                CMD.Parameters.Add("@DATE_OF_REALEASE", MySqlDbType.DateTime);
                CMD.Parameters["@DATE_OF_REALEASE"].Value = DateTime.Now;

                conn.Open();
                CMD.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UploadFirmwareFile(string Version, string Changelog, FileInfo File, string Username, string Password)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "dedivirt134.your-server.de";
                builder.Database = "cruisesafe";
                builder.UserID = Username;
                builder.Password = Password;
                builder.ConnectionTimeout = 10;

                MySqlConnection conn = new MySqlConnection(builder.ToString());

                string sqlCMD = "INSERT INTO FIRM_VERSIONS (VERSION_NO, CHANGELOG, PAYLOAD, DATE_OF_RELEASE) " +
                    "VALUES (@VERSION_NO, @CHANGELOG, @PAYLOAD, @DATE_OF_REALEASE)";

                MySqlCommand CMD = new MySqlCommand(sqlCMD, conn);
                CMD.Parameters.Add("@VERSION_NO", MySqlDbType.VarChar);
                CMD.Parameters["@VERSION_NO"].Value = Version;
                CMD.Parameters.Add("@CHANGELOG", MySqlDbType.VarChar);
                CMD.Parameters["@CHANGELOG"].Value = Changelog;
                CMD.Parameters.Add("@PAYLOAD", MySqlDbType.MediumBlob);
                CMD.Parameters["@PAYLOAD"].Value = System.IO.File.ReadAllBytes(File.FullName);
                CMD.Parameters.Add("@DATE_OF_REALEASE", MySqlDbType.Date);
                CMD.Parameters["@DATE_OF_REALEASE"].Value = DateTime.Now;

                conn.Open();
                CMD.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
