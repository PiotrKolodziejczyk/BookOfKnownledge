using BookOfKnownledge.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookOfKnownledge
{
    public partial class Form1 : Form
    {
        #region Zmienne
        public DataSet Ds => ds;
        private readonly DataSet ds = new DataSet();
        private List<Book> bookList;
        private List<Note> noteList;
        private Mode mode;
        private readonly string path = Directory.GetCurrentDirectory();
        private DownloadFileIfDontExist downloadFileIfDontExist;
        private string dataFromDatabase = null;
        

        #endregion

        public Form1()
        {
            InitializeComponent();
            
        }
        
        public void InitializeFile(string fileName, Mode mode)
        {
            switch (mode)
            {
                case Mode.RegexBook:
                    {
                        CreateBook(dataFromDatabase,Mode.RegexBook.ToString());
                        return;
                    }
                case Mode.RegexBookNote:
                    {
                        CreateNote(dataFromDatabase,Mode.RegexBookNote.ToString());
                        return;
                    }
                case Mode.DataStructureBook:
                    {
                        CreateBook(dataFromDatabase,Mode.DataStructureBook.ToString());
                        return;
                    }
                case Mode.WebBook:
                    {
                        CreateBook(dataFromDatabase, Mode.WebBook.ToString());
                        return;
                    }
                case Mode.WebBookNote:
                    {
                        CreateNote(dataFromDatabase, Mode.WebBookNote.ToString());
                        return;
                    }
                case Mode.ConcurrencyBook:
                    {
                        CreateBook(dataFromDatabase, Mode.ConcurrencyBook.ToString());
                        return;
                    }
                case Mode.Git:
                    {
                        CreateNote(dataFromDatabase, Mode.Git.ToString());
                        return;
                    }
            }
        }
        #region Zdarzenia
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.RegexBook:
                    AssignBookToSelectedIndex(mode,bookList);
                    return;
                case Mode.RegexBookNote:
                    AssignNoteToSelectedIndex(mode, noteList);
                    return;
                case Mode.DataStructureBook:
                    AssignBookToSelectedIndex(mode, bookList);
                    return;
                case Mode.WebBook:
                    AssignBookToSelectedIndex(mode, bookList);
                    return;
                case Mode.WebBookNote:
                    AssignNoteToSelectedIndex(mode, noteList);
                    return;
                case Mode.ConcurrencyBook:
                    AssignBookToSelectedIndex(mode, bookList);
                    return;
                case Mode.Git:
                    AssignNoteToSelectedIndex(mode, noteList);
                    return;
            }
            
        }

        private void RegexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.RegexBook);
        }

        private void RegexNoteStructure_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.RegexBookNote);
        }

        private void DataStructureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.DataStructureBook);
        }
        private void WebBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.WebBook);
        }

        private void WebBookNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.WebBookNote);
        }

        private void ConccurencyBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.ConcurrencyBook);
        }

        private void GitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseWhereFromTheData(Mode.Git);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            downloadFileIfDontExist = new DownloadFileIfDontExist(progressText, this); //1
            RegexToolStripMenuItem_Click(sender, e);

        }

        #endregion
        private void ChooseWhereFromTheData(Mode mode)
        {
            listBox1.Items.Clear();
            ClearAllTextBoxes();
            this.mode = mode;
            if (!File.Exists((path + $"//{mode.ToString()}.txt")))
            {
                if (!downloadFileIfDontExist.DownloadDataFromFtpServer(mode.ToString(), mode))
                {
                    dataFromDatabase = downloadFileIfDontExist.DownloadDataFromDatabase(mode.ToString(), mode.ToString(), mode);
                    InitializeFile(mode.ToString(), mode);
                }
            }
            else
            {
                InitializeFile(mode.ToString(), mode);
            }
        }
        private void ClearAllTextBoxes()
        {
            description.Text = "";
            expression.Text = "";
            page.Text = "";
            recipe.Text = "";
        }
        private void AssignBookToSelectedIndex(Mode mode, List<Book> list)
        {
            try
            {
                page.Text = list[listBox1.SelectedIndex].Page.ToString();
                recipe.Text = list[listBox1.SelectedIndex].Recipe;
                description.Text = list[listBox1.SelectedIndex].Description;
                expression.Text = list[listBox1.SelectedIndex].Expression;
            }
            catch
            {
                
            }
        }
        private void AssignNoteToSelectedIndex(Mode mode , List<Note> list)
        {
            description.Text = noteList[listBox1.SelectedIndex].Info;
        }
       
        #region Metody Tworzenia
        private void CreateNote(string text, string name)
        {
            if (text == null)
            {
                noteList = Knownledge.CreateNote(path + $"\\{name}.txt", null);
            }
            else
            {
                noteList = Knownledge.CreateNote(null, text);
            }
                

            foreach (var item in noteList)
            {
                if (item.Info.Length > 50)
                {
                    string result = item.Info.Substring(0, 50);
                    listBox1.Items.Add(result);
                }
                else
                {
                    listBox1.Items.Add(item.Info);
                }

            }
            
        }
        private void CreateBook(string text, string name)
        {
            if (text == null)
            {
                bookList = Knownledge.CreateBook(path + $"\\{name}.txt", null);
            }
            else
            {
                bookList = Knownledge.CreateBook(null, text);
            }

            foreach (var item in bookList)
            {
                listBox1.Items.Add(item.Title);
            }
            return;
        }


        #endregion

        private void AddData_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void ScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@";");
            description.Text= regex.Replace(description.Text, "\r\n");
        }

        private void Parse2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@";");
            expression.Text = regex.Replace(expression.Text, "\r\n");
        }
    }

    public enum Mode
    {
        RegexBook,
        RegexBookNote,
        DataStructureBook,
        WebBook,
        WebBookNote,
        ConcurrencyBook,
        Git
    }

}
