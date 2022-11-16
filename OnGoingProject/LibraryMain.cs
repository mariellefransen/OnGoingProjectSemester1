namespace OnGoingProject
{
    public partial class LibraryMain : Form
    {
        Book selectedBook = null;
        public LibraryMain()
        {
            InitializeComponent();
            // add some books while initializing the document
            AddSomeBooks();
        }


        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string genre = "";

            Book newBook = new Book();
            newBook.SetBook(id, title, author);

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
                int id = Convert.ToInt32(tbID.Text);
                string title = tbTitle.Text;
                string author = tbAuthor.Text;
                string genre = cbGenre.Text;
                selectedBook.SetBook(id, title, author);
                selectedBook.SetEBook(cbEBook.Checked);
                selectedBook.SetGenre(genre);
                //lbBooks.SelectedItem = selectedBook; // will not work
                lbBooks.Items[lbBooks.SelectedIndex] = selectedBook;
                lbBooks.Refresh();

            }

        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedIndex == -1)
            {
                //set textboxes empty
                tbID.Text = "";
                tbTitle.Text = "";
                tbAuthor.Text = "";
                cbGenre.Text = "";
                cbEBook.Checked = false;
            }
            else
            {
                selectedBook = (Book)lbBooks.SelectedItem;
                tbID.Text = selectedBook.GetID().ToString();
                tbTitle.Text = selectedBook.GetTitle();
                tbAuthor.Text = selectedBook.GetAuthor();
                cbGenre.Text = selectedBook.GetGenre();
                cbEBook.Checked = selectedBook.GetIsEBook();
            }
        }

        #region InitBooks
        private void AddSomeBooks()
        {
            Book newBook;
            newBook = new Book();
            newBook.SetBook(1, "The Adventures of Huckleberry Finn", "Mark Twain");
            newBook.SetGenre("Classic");
            lbBooks.Items.Add(newBook);

            newBook = new Book();
            newBook.SetBook(2, "Anna Karenina", "Leo Tolstoy");
            newBook.SetGenre("Classic");
            lbBooks.Items.Add(newBook);

            newBook = new Book();
            newBook.SetBook(3, "Great Expectations", "Charles Dickens");
            newBook.SetGenre("Classic");
            lbBooks.Items.Add(newBook);

            newBook = new Book();
            newBook.SetBook(4, "Life of Pi ", "Yann Martel");
            newBook.SetGenre("Classic");
            lbBooks.Items.Add(newBook);

            newBook = new Book();
            newBook.SetBook(5, "The Lazarus Project", "Aleksandar Hemon");
            newBook.SetGenre("Novel");
            lbBooks.Items.Add(newBook);
        }
        #endregion
    }
}