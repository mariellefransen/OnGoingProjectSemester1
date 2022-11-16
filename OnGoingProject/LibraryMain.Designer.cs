namespace OnGoingProject
{
    partial class LibraryMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbBookInfo = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.cbEBook = new System.Windows.Forms.CheckBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.gbBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.Controls.Add(this.btnUpdate);
            this.gbBookInfo.Controls.Add(this.label5);
            this.gbBookInfo.Controls.Add(this.cbGenre);
            this.gbBookInfo.Controls.Add(this.btnCreateBook);
            this.gbBookInfo.Controls.Add(this.cbEBook);
            this.gbBookInfo.Controls.Add(this.tbAuthor);
            this.gbBookInfo.Controls.Add(this.tbTitle);
            this.gbBookInfo.Controls.Add(this.tbID);
            this.gbBookInfo.Controls.Add(this.label4);
            this.gbBookInfo.Controls.Add(this.label3);
            this.gbBookInfo.Controls.Add(this.label1);
            this.gbBookInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBookInfo.Location = new System.Drawing.Point(490, 0);
            this.gbBookInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBookInfo.Size = new System.Drawing.Size(515, 646);
            this.gbBookInfo.TabIndex = 0;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Book Information:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 563);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 48);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update Book";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Genre";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Fantasy",
            "Horror",
            "Romance",
            "SciFi"});
            this.cbGenre.Location = new System.Drawing.Point(118, 227);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(187, 33);
            this.cbGenre.TabIndex = 11;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(38, 563);
            this.btnCreateBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(154, 48);
            this.btnCreateBook.TabIndex = 10;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // cbEBook
            // 
            this.cbEBook.AutoSize = true;
            this.cbEBook.Location = new System.Drawing.Point(118, 274);
            this.cbEBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEBook.Name = "cbEBook";
            this.cbEBook.Size = new System.Drawing.Size(111, 29);
            this.cbEBook.TabIndex = 8;
            this.cbEBook.Text = "is E book";
            this.cbEBook.UseVisualStyleBackColor = true;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(118, 170);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(232, 31);
            this.tbAuthor.TabIndex = 7;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(118, 117);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(232, 31);
            this.tbTitle.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(118, 64);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(98, 31);
            this.tbID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 25;
            this.lbBooks.Location = new System.Drawing.Point(22, 33);
            this.lbBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(446, 579);
            this.lbBooks.TabIndex = 1;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // LibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 646);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.gbBookInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LibraryMain";
            this.Text = "My Library";
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBookInfo;
        private CheckBox cbEBook;
        private TextBox tbAuthor;
        private TextBox tbTitle;
        private TextBox tbID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCreateBook;
        private ComboBox cbGenre;
        private ListBox lbBooks;
        private Label label5;
        private Button btnUpdate;
    }
}