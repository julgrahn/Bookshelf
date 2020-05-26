using System;
using System.Collections.Generic;

namespace Bookshelf
{
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }

        public Book(string title, string author, string type)
        {
            Title = title;
            Author = author;
            Type = type;
        }
    }

    public class Novel : Book
    {
        public Novel(string title, string author, string type) : base(title, author, type)
        {
            Type = "novel";
        }

        public override string ToString()
        {
            return "the name of the book is " + Title + " written by " + Author + " and is of the type " + Type;
        }
    }

    public class Journal : Book
    {
        public Journal(string title, string author, string type) : base(title, author, type)
        {
            Type = "journal";
        }

        public override string ToString()
        {
            return "the name of the book is " + Title + " written by " + Author + " and is of the type " + Type;
        }
    }

    public class Poetry : Book
    {
        public Poetry(string title, string author, string type) : base(title, author, type)
        {
            Type = "poetry";
        }

        public override string ToString()
        {
            return "the name of the book is " + Title + " written by " + Author + " and is of the type " + Type;
        }
    }
}
