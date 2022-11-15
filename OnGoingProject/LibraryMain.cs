namespace OnGoingProject
{
    public partial class LibraryMain : Form
    {
        public LibraryMain()
        {
            InitializeComponent();
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            string isbn = tbISBN.Text;
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string genre = "";

            Book newBook = new Book();
            newBook.AddBook(id, isbn, title, author);

            newBook.SetEBook(cbEBook.Checked);

            if (rbFantasy.Checked)
                genre = "Fantasy";
            else
                if (rbHorror.Checked)
                    genre = "Horror";
                else
                    if (rbRomance.Checked)
                        genre = "Romance";
            newBook.SetGenre(genre);

            // show what we did:
            MessageBox.Show(newBook.ToString());
        }
    }
}