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
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.rbRomance = new System.Windows.Forms.RadioButton();
            this.rbHorror = new System.Windows.Forms.RadioButton();
            this.rbFantasy = new System.Windows.Forms.RadioButton();
            this.cbEBook = new System.Windows.Forms.CheckBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.gbBookInfo.SuspendLayout();
            this.gbGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.Controls.Add(this.pbBook);
            this.gbBookInfo.Controls.Add(this.cbGenre);
            this.gbBookInfo.Controls.Add(this.btnCreateBook);
            this.gbBookInfo.Controls.Add(this.gbGenre);
            this.gbBookInfo.Controls.Add(this.cbEBook);
            this.gbBookInfo.Controls.Add(this.tbAuthor);
            this.gbBookInfo.Controls.Add(this.tbTitle);
            this.gbBookInfo.Controls.Add(this.tbISBN);
            this.gbBookInfo.Controls.Add(this.tbID);
            this.gbBookInfo.Controls.Add(this.label4);
            this.gbBookInfo.Controls.Add(this.label3);
            this.gbBookInfo.Controls.Add(this.label2);
            this.gbBookInfo.Controls.Add(this.label1);
            this.gbBookInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBookInfo.Location = new System.Drawing.Point(637, 0);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Size = new System.Drawing.Size(669, 827);
            this.gbBookInfo.TabIndex = 0;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Book Information:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Fantasy",
            "Horror",
            "Romance",
            "SciFi"});
            this.cbGenre.Location = new System.Drawing.Point(335, 460);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(242, 40);
            this.cbGenre.TabIndex = 11;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(49, 735);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(175, 46);
            this.btnCreateBook.TabIndex = 10;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // gbGenre
            // 
            this.gbGenre.Controls.Add(this.rbRomance);
            this.gbGenre.Controls.Add(this.rbHorror);
            this.gbGenre.Controls.Add(this.rbFantasy);
            this.gbGenre.Location = new System.Drawing.Point(49, 443);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(261, 236);
            this.gbGenre.TabIndex = 9;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Genre:";
            // 
            // rbRomance
            // 
            this.rbRomance.AutoSize = true;
            this.rbRomance.Location = new System.Drawing.Point(32, 162);
            this.rbRomance.Name = "rbRomance";
            this.rbRomance.Size = new System.Drawing.Size(143, 36);
            this.rbRomance.TabIndex = 2;
            this.rbRomance.TabStop = true;
            this.rbRomance.Text = "Romance";
            this.rbRomance.UseVisualStyleBackColor = true;
            // 
            // rbHorror
            // 
            this.rbHorror.AutoSize = true;
            this.rbHorror.Location = new System.Drawing.Point(32, 105);
            this.rbHorror.Name = "rbHorror";
            this.rbHorror.Size = new System.Drawing.Size(114, 36);
            this.rbHorror.TabIndex = 1;
            this.rbHorror.TabStop = true;
            this.rbHorror.Text = "Horror";
            this.rbHorror.UseVisualStyleBackColor = true;
            // 
            // rbFantasy
            // 
            this.rbFantasy.AutoSize = true;
            this.rbFantasy.Location = new System.Drawing.Point(32, 48);
            this.rbFantasy.Name = "rbFantasy";
            this.rbFantasy.Size = new System.Drawing.Size(124, 36);
            this.rbFantasy.TabIndex = 0;
            this.rbFantasy.TabStop = true;
            this.rbFantasy.Text = "Fantasy";
            this.rbFantasy.UseVisualStyleBackColor = true;
            // 
            // cbEBook
            // 
            this.cbEBook.AutoSize = true;
            this.cbEBook.Location = new System.Drawing.Point(154, 367);
            this.cbEBook.Name = "cbEBook";
            this.cbEBook.Size = new System.Drawing.Size(142, 36);
            this.cbEBook.TabIndex = 8;
            this.cbEBook.Text = "is E book";
            this.cbEBook.UseVisualStyleBackColor = true;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(154, 291);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(300, 39);
            this.tbAuthor.TabIndex = 7;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(154, 223);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(300, 39);
            this.tbTitle.TabIndex = 6;
            // 
            // tbISBN
            // 
            this.tbISBN.Location = new System.Drawing.Point(154, 151);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(300, 39);
            this.tbISBN.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(154, 82);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(126, 39);
            this.tbID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // pbBook
            // 
            this.pbBook.Image = global::OnGoingProject.Properties.Resources.book_image;
            this.pbBook.Location = new System.Drawing.Point(337, 525);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(254, 290);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBook.TabIndex = 12;
            this.pbBook.TabStop = false;
            // 
            // LibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 827);
            this.Controls.Add(this.gbBookInfo);
            this.Name = "LibraryMain";
            this.Text = "My Library";
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBookInfo;
        private GroupBox gbGenre;
        private RadioButton rbRomance;
        private RadioButton rbHorror;
        private RadioButton rbFantasy;
        private CheckBox cbEBook;
        private TextBox tbAuthor;
        private TextBox tbTitle;
        private TextBox tbISBN;
        private TextBox tbID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCreateBook;
        private ComboBox cbGenre;
        private PictureBox pbBook;
    }
}