namespace BookOfKnownledge
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SqlQueriesText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.InsertIntoButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SqlQueriesText
            // 
            this.SqlQueriesText.Location = new System.Drawing.Point(12, 35);
            this.SqlQueriesText.Multiline = true;
            this.SqlQueriesText.Name = "SqlQueriesText";
            this.SqlQueriesText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SqlQueriesText.Size = new System.Drawing.Size(549, 245);
            this.SqlQueriesText.TabIndex = 2;
            this.SqlQueriesText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SqlQueriesText_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL queries";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(587, 260);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File Name";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(281, 305);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(587, 71);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(103, 23);
            this.CreateTableButton.TabIndex = 8;
            this.CreateTableButton.Text = "Create Table";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // InsertIntoButton
            // 
            this.InsertIntoButton.Location = new System.Drawing.Point(587, 100);
            this.InsertIntoButton.Name = "InsertIntoButton";
            this.InsertIntoButton.Size = new System.Drawing.Size(103, 23);
            this.InsertIntoButton.TabIndex = 9;
            this.InsertIntoButton.Text = "Insert Into";
            this.InsertIntoButton.UseVisualStyleBackColor = true;
            this.InsertIntoButton.Click += new System.EventHandler(this.InsertIntoButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(587, 35);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(103, 23);
            this.SelectButton.TabIndex = 10;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.InsertIntoButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SqlQueriesText);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SqlQueriesText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button InsertIntoButton;
        private System.Windows.Forms.Button SelectButton;
    }
}