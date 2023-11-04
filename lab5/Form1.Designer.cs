
namespace lab5
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dekoratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kompresjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editField = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setPasswordButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.dekoratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.odczytajToolStripMenuItem,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // odczytajToolStripMenuItem
            // 
            this.odczytajToolStripMenuItem.Name = "odczytajToolStripMenuItem";
            this.odczytajToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.odczytajToolStripMenuItem.Text = "Odczytaj";
            this.odczytajToolStripMenuItem.Click += new System.EventHandler(this.odczytajToolStripMenuItem_Click);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // dekoratorToolStripMenuItem
            // 
            this.dekoratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kompresjaToolStripMenuItem,
            this.szyfrowanieToolStripMenuItem});
            this.dekoratorToolStripMenuItem.Name = "dekoratorToolStripMenuItem";
            this.dekoratorToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.dekoratorToolStripMenuItem.Text = "Dekorator";
            // 
            // kompresjaToolStripMenuItem
            // 
            this.kompresjaToolStripMenuItem.CheckOnClick = true;
            this.kompresjaToolStripMenuItem.Name = "kompresjaToolStripMenuItem";
            this.kompresjaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kompresjaToolStripMenuItem.Text = "Kompresja";
            this.kompresjaToolStripMenuItem.Click += new System.EventHandler(this.kompresjaToolStripMenuItem_Click);
            // 
            // szyfrowanieToolStripMenuItem
            // 
            this.szyfrowanieToolStripMenuItem.CheckOnClick = true;
            this.szyfrowanieToolStripMenuItem.Name = "szyfrowanieToolStripMenuItem";
            this.szyfrowanieToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.szyfrowanieToolStripMenuItem.Text = "Szyfrowanie";
            this.szyfrowanieToolStripMenuItem.Click += new System.EventHandler(this.szyfrowanieToolStripMenuItem_Click);
            // 
            // editField
            // 
            this.editField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editField.Location = new System.Drawing.Point(0, 46);
            this.editField.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.editField.Multiline = true;
            this.editField.Name = "editField";
            this.editField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.editField.Size = new System.Drawing.Size(800, 423);
            this.editField.TabIndex = 2;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTextBox.Location = new System.Drawing.Point(63, 27);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(665, 20);
            this.pathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ścieżka:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(725, 26);
            this.searchButton.MaximumSize = new System.Drawing.Size(75, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Przeglądaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(157, 1);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Klucz:";
            // 
            // setPasswordButton
            // 
            this.setPasswordButton.Location = new System.Drawing.Point(263, 0);
            this.setPasswordButton.Name = "setPasswordButton";
            this.setPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.setPasswordButton.TabIndex = 8;
            this.setPasswordButton.Text = "Ustaw";
            this.setPasswordButton.UseVisualStyleBackColor = true;
            this.setPasswordButton.Click += new System.EventHandler(this.setPasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.setPasswordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.editField);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Edytor tekstu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dekoratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kompresjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrowanieToolStripMenuItem;
        private System.Windows.Forms.TextBox editField;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setPasswordButton;
    }
}

