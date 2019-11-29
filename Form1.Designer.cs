namespace BookOfKnownledge
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.recipe = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.expression = new System.Windows.Forms.TextBox();
            this.page = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegexNoteStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStructureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBookNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conccurencyBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressText = new System.Windows.Forms.TextBox();
            this.AddData = new System.Windows.Forms.Button();
            this.scriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parse = new System.Windows.Forms.Button();
            this.Parse2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // recipe
            // 
            this.recipe.Location = new System.Drawing.Point(376, 44);
            this.recipe.Multiline = true;
            this.recipe.Name = "recipe";
            this.recipe.ReadOnly = true;
            this.recipe.Size = new System.Drawing.Size(96, 27);
            this.recipe.TabIndex = 1;
            // 
            // description
            // 
            this.description.AcceptsReturn = true;
            this.description.AcceptsTab = true;
            this.description.AllowDrop = true;
            this.description.Location = new System.Drawing.Point(376, 95);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.description.Size = new System.Drawing.Size(398, 157);
            this.description.TabIndex = 4;
            // 
            // expression
            // 
            this.expression.Location = new System.Drawing.Point(376, 258);
            this.expression.Multiline = true;
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(398, 154);
            this.expression.TabIndex = 5;
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(491, 44);
            this.page.Multiline = true;
            this.page.Name = "page";
            this.page.ReadOnly = true;
            this.page.Size = new System.Drawing.Size(86, 27);
            this.page.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regexToolStripMenuItem,
            this.RegexNoteStructure,
            this.dataStructureToolStripMenuItem1,
            this.webBookToolStripMenuItem,
            this.webBookNoteToolStripMenuItem,
            this.conccurencyBookToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.scriptsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regexToolStripMenuItem
            // 
            this.regexToolStripMenuItem.Name = "regexToolStripMenuItem";
            this.regexToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.regexToolStripMenuItem.Text = "Regex";
            this.regexToolStripMenuItem.Click += new System.EventHandler(this.RegexToolStripMenuItem_Click);
            // 
            // RegexNoteStructure
            // 
            this.RegexNoteStructure.Name = "RegexNoteStructure";
            this.RegexNoteStructure.Size = new System.Drawing.Size(76, 20);
            this.RegexNoteStructure.Text = "RegexNote";
            this.RegexNoteStructure.Click += new System.EventHandler(this.RegexNoteStructure_Click);
            // 
            // dataStructureToolStripMenuItem1
            // 
            this.dataStructureToolStripMenuItem1.Name = "dataStructureToolStripMenuItem1";
            this.dataStructureToolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.dataStructureToolStripMenuItem1.Text = "DataStructure";
            this.dataStructureToolStripMenuItem1.Click += new System.EventHandler(this.DataStructureToolStripMenuItem1_Click);
            // 
            // webBookToolStripMenuItem
            // 
            this.webBookToolStripMenuItem.Name = "webBookToolStripMenuItem";
            this.webBookToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.webBookToolStripMenuItem.Text = "WebBook";
            this.webBookToolStripMenuItem.Click += new System.EventHandler(this.WebBookToolStripMenuItem_Click);
            // 
            // webBookNoteToolStripMenuItem
            // 
            this.webBookNoteToolStripMenuItem.Name = "webBookNoteToolStripMenuItem";
            this.webBookNoteToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.webBookNoteToolStripMenuItem.Text = "WebBookNote";
            this.webBookNoteToolStripMenuItem.Click += new System.EventHandler(this.WebBookNoteToolStripMenuItem_Click);
            // 
            // conccurencyBookToolStripMenuItem
            // 
            this.conccurencyBookToolStripMenuItem.Name = "conccurencyBookToolStripMenuItem";
            this.conccurencyBookToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.conccurencyBookToolStripMenuItem.Text = "ConccurencyBook";
            this.conccurencyBookToolStripMenuItem.Click += new System.EventHandler(this.ConccurencyBookToolStripMenuItem_Click);
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.gitToolStripMenuItem.Text = "Git";
            this.gitToolStripMenuItem.Click += new System.EventHandler(this.GitToolStripMenuItem_Click);
            // 
            // progressText
            // 
            this.progressText.Location = new System.Drawing.Point(597, 44);
            this.progressText.Multiline = true;
            this.progressText.Name = "progressText";
            this.progressText.ReadOnly = true;
            this.progressText.Size = new System.Drawing.Size(86, 27);
            this.progressText.TabIndex = 8;
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(701, 48);
            this.AddData.Name = "AddData";
            this.AddData.Size = new System.Drawing.Size(73, 23);
            this.AddData.TabIndex = 9;
            this.AddData.Text = "Add";
            this.AddData.UseVisualStyleBackColor = true;
            this.AddData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // scriptsToolStripMenuItem
            // 
            this.scriptsToolStripMenuItem.Name = "scriptsToolStripMenuItem";
            this.scriptsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.scriptsToolStripMenuItem.Text = "Scripts";
            this.scriptsToolStripMenuItem.Click += new System.EventHandler(this.ScriptsToolStripMenuItem_Click);
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(780, 95);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(54, 34);
            this.Parse.TabIndex = 10;
            this.Parse.Text = "Parse";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.Parse_Click);
            // 
            // Parse2
            // 
            this.Parse2.Location = new System.Drawing.Point(780, 258);
            this.Parse2.Name = "Parse2";
            this.Parse2.Size = new System.Drawing.Size(54, 34);
            this.Parse2.TabIndex = 11;
            this.Parse2.Text = "Parse";
            this.Parse2.UseVisualStyleBackColor = true;
            this.Parse2.Click += new System.EventHandler(this.Parse2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.Parse2);
            this.Controls.Add(this.Parse);
            this.Controls.Add(this.AddData);
            this.Controls.Add(this.progressText);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.page);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.description);
            this.Controls.Add(this.recipe);
            this.Controls.Add(this.listBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox recipe;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegexNoteStructure;
        private System.Windows.Forms.TextBox progressText;
        private System.Windows.Forms.ToolStripMenuItem dataStructureToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem webBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webBookNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conccurencyBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.Button AddData;
        private System.Windows.Forms.ToolStripMenuItem scriptsToolStripMenuItem;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.Button Parse2;
    }
}

