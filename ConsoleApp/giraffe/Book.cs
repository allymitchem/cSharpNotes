using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace giraffe
{
     class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle,string aAuthor, int aPages) //constructor
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}