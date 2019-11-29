using BookOfKnownledge.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookOfKnownledge
{
    public partial class Form3 : Form
    {
        List<string> list;
        public Form3()
        {
            InitializeComponent();
            WebClient client = new WebClient();
            
            client.Credentials= new NetworkCredential($"cebul23@piotrkolodziejczyk.cln.servizza.it", "cicigwdk23");
            FtpUtility ftp = new FtpUtility { Password = "cicigwdk23", UserName = "cebul23@piotrkolodziejczyk.cln.servizza.it", Path = $"ftp://ftp.piotrkolodziejczyk.cln.servizza.it/Scripts/" };
            list = ftp.ListFiles();

            try
            {
                foreach (var file in list)
                {
                    if (!File.Exists($"{Directory.GetCurrentDirectory()}/Scripts/{file.ToString()}"))
                    {
                        client.DownloadFile($"ftp://ftp.piotrkolodziejczyk.cln.servizza.it/Scripts/{file.ToString()}", file.ToString());
                        File.Move($"{Directory.GetCurrentDirectory()}/{file.ToString()}", $"{Directory.GetCurrentDirectory()}/Scripts/{file.ToString()}");
                    }

                    Match match = Regex.Match(file, @"(.*)\.cs");
                    listBox1.Items.Add(match.Groups[1].Value);
                }
            }
            catch
            {
                MessageBox.Show("Nie mozna zaladowac plikow!", "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText($"{Directory.GetCurrentDirectory()}/Scripts/{list[listBox1.SelectedIndex]}");
        }

        private void Open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{Directory.GetCurrentDirectory()}/Scripts/{list[listBox1.SelectedIndex]}");
        }
    }
}
