using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfKnownledge
{
    public partial class Form2 : Form
    {
        private readonly DataSet dataSet = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataSet.Clear();

            try
            {
                string connstring = String.Format("Server=packy.db.elephantsql.com;Port=5432;User Id=mmbibmjj;Password=bzRnqtDHp28n2VcJwRw8KjiU67v4WVse;Database=mmbibmjj;");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = SqlQueriesText.Text;
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql, conn);
                try
                {
                     da1.Fill(dataSet);
                }
                catch
                {
                    MessageBox.Show("Tabela nie istnieje!!", "Tabela nie istnieje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                if(dataSet.Tables[0].Rows.Count!=0)
                SqlQueriesText.Text = dataSet.Tables[0].Rows[0].ItemArray[0].ToString();
                conn.Close();
                MessageBox.Show("Udało się!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Nie udalo sie wyslac!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
}

        private void Button2_Click(object sender, EventArgs e)
        {
            if(fileNameTextBox.Text!="")
            UploadFile(fileNameTextBox.Text);
        }

        private void UploadFile(string fileName)
        {
            try
            {
                WebClient client = new WebClient();
                client.Credentials = new NetworkCredential($"cebul23@piotrkolodziejczyk.cln.servizza.it", "cicigwdk23");
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    client.UploadFile($"ftp://ftp.piotrkolodziejczyk.cln.servizza.it/e/{fileName}.txt", openFileDialog1.FileName);
                MessageBox.Show("Wyslano!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Nie udalo sie wyslac!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SqlQueriesText.Text = "";
            FocusAndSelect();
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            SqlQueriesText.Text = "CREATE TABLE ";
            FocusAndSelect();
        }

        private void InsertIntoButton_Click(object sender, EventArgs e)
        {
            SqlQueriesText.Text = "INSERT INTO ()VALUES('')";
            FocusAndSelect();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SqlQueriesText.Text = "SELECT line FROM ";
            FocusAndSelect();

        }

        private void FocusAndSelect()
        {
            SqlQueriesText.Focus();
            SqlQueriesText.Select(SqlQueriesText.Text.Length, SqlQueriesText.Text.Length);
        }

        private void SqlQueriesText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Button1_Click(sender, e);
                FocusAndSelect();
            }
                
        }
    }
}
