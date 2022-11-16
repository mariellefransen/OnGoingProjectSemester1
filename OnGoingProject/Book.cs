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
        private string title;
        private string author;
        private string genre;
        private bool eBook = false;

        #region GetMethods
        public int GetID()
        {
            return this.id;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetAuthor()
        {
            return this.author;
        }

        public string GetGenre()
        {
            return this.genre;
        }

        public bool GetIsEBook()
        {
            return this.eBook;
        }
        #endregion

        public void SetBook(int id,  string title, string author)
        {
            this.id = id;
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

        public override string  ToString()
        {
            string returnValue = $"{title}, {author} - {genre}";
            if (this.eBook)
                return $"{returnValue} (ebook)";
            return returnValue;
        }

    }
}
