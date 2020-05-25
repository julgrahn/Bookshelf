namespace Bookshelf
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Type;

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
            type = "Novel";
        }
    }

    public class Journal : Book
    {
        public Journal(string title, string author, string type) : base(title, author, type)
        {
            type = "Journal";
        }
    }

    public class Poetry : Book
    {
        public Poetry(string title, string author, string type) : base(title, author, type)
        {
            type = "Poetry";
        }
    }
}
