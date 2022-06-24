namespace Library_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.authorToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.bOOKToolStripMenuItem,
            this.bookCategoryToolStripMenuItem,
            this.bookBorrowedToolStripMenuItem,
            this.positionToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("School Times", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 33);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.userToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.authorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.studentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.studentsToolStripMenuItem.Text = "Student";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // bOOKToolStripMenuItem
            // 
            this.bOOKToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.bOOKToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bOOKToolStripMenuItem.Name = "bOOKToolStripMenuItem";
            this.bOOKToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.bOOKToolStripMenuItem.Text = "BOOK";
            this.bOOKToolStripMenuItem.Click += new System.EventHandler(this.bOOKToolStripMenuItem_Click);
            // 
            // bookCategoryToolStripMenuItem
            // 
            this.bookCategoryToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.bookCategoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookCategoryToolStripMenuItem.Name = "bookCategoryToolStripMenuItem";
            this.bookCategoryToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.bookCategoryToolStripMenuItem.Text = "Book  Category";
            this.bookCategoryToolStripMenuItem.Click += new System.EventHandler(this.bookCategoryToolStripMenuItem_Click);
            // 
            // bookBorrowedToolStripMenuItem
            // 
            this.bookBorrowedToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.bookBorrowedToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bookBorrowedToolStripMenuItem.Name = "bookBorrowedToolStripMenuItem";
            this.bookBorrowedToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.bookBorrowedToolStripMenuItem.Text = "Book Borrowed";
            this.bookBorrowedToolStripMenuItem.Click += new System.EventHandler(this.bookBorrowedToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.positionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

