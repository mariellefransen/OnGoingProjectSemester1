namespace OnGoingProject
{
    public partial class LibraryMain : Form
    {
        Book selectedBook = null;
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

            genre = cbGenre.Text;
            newBook.SetGenre(genre);

            // add to listbox
            lbBooks.Items.Add(newBook); // only works when ToString is overriden
            //lbBooks.Items.Add(newBook.ToString());


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // check if a book is selected in the listbox
            // in that case the info is shown in the info panel -> TODO
            // if above is true then update the book 
            if (selectedBook != null)
            {
                selectedBook.SetGenre("succeeded");
                lbBooks.SelectedItem = selectedBook;
                lbBooks.Refresh();

            }

        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = (Book)lbBooks.SelectedItem;
        }
    }
}