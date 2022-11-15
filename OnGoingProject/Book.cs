using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnGoingProject
{
    public class Book
    {
        //instance variables / fields
        private int id;
        private string isbn;
        private string title;
        private string author;
        private string genre;
        private bool eBook = false;

        public void AddBook(int id, string isbn, string title, string author)
        {
            this.id = id;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }
        public void SetGenre(string genre)
        {
            this.genre = genre;
        }

        public void SetEBook(bool isEBook = true)
        {
            this.eBook = isEBook;
        }

        public string ToString()
        {
            string returnValue = $"{title}, {author} - {genre}";
            if (this.eBook)
                return $"{returnValue} (ebook)";
            return returnValue;
        }

    }
}
