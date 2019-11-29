using BookOfKnownledge.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BookOfKnownledge
{
    public class DownloadFileIfDontExist 
    {
        private readonly TextBox progressText;
        private readonly Form1 form;
        private readonly DataSet ds = new DataSet();
        public DownloadFileIfDontExist(TextBox textbox,Form1 form)
        {
            this.progressText = textbox;
            this.form = form;
        }

        
        public bool DownloadDataFromFtpServer(string fileName,Mode mode)
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFileCompleted += (sender, e) =>
                {
                    form.InitializeFile(fileName, mode);
                    progressText.Text = "Pobrano";
                };
                client.Credentials = new NetworkCredential($"cebul23@piotrkolodziejczyk.cln.servizza.it", "cicigwdk23");
                FtpUtility ftp = new FtpUtility { Password = "cicigwdk23", UserName = "cebul23@piotrkolodziejczyk.cln.servizza.it", Path = $"ftp://ftp.piotrkolodziejczyk.cln.servizza.it/e/" };
                List<string> list = ftp.ListFiles();
                if (list.Contains(fileName + ".txt"))
                {
                    client.DownloadFileTaskAsync(new Uri($"ftp://ftp.piotrkolodziejczyk.cln.servizza.it/e/{fileName}.txt"), $"{fileName}.txt");
                    return true;
                }
                  else
                {
                    MessageBox.Show("Plik nie istnieje na serwerze!! Rozpoczynanie próby ściągnięcia z bazy danych", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            catch
            {
                MessageBox.Show("Nie udalo sie pobrac z serwera ftp!! Rozpoczynanie próby ściągnięcia z bazy danych", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public string DownloadDataFromDatabase(string table, string fileName, Mode mode)
        {
            try
            {
                string connstring = String.Format("Server=packy.db.elephantsql.com;Port=5432;User Id=mmbibmjj;Password=bzRnqtDHp28n2VcJwRw8KjiU67v4WVse;Database=mmbibmjj;");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = $"SELECT line FROM {table}";
                NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(sql, conn);
                da1.Fill(ds);
                conn.Close();
                progressText.Text = "Pobrano";
                return ds.Tables[0].Rows[0].ItemArray[0].ToString();

            }
            catch
            {
                MessageBox.Show("Nie udalo sie pobrac z Bazy Danych!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
