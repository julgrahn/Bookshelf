using System;
using System.Collections.Generic;

namespace Bookshelf
{
    class Program
    {
        private static readonly List<Book> bookshelf = new List<Book>();

#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            bool isRunning = true;
            while (isRunning)
            {
                
                Console.WriteLine("Welcome to the library.\n");
                Console.WriteLine("1. Register a book");
                Console.WriteLine("2. Print all books");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option: ");

                Int32.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        RegisterBook();
                        break;
                    case 2:
                        PrintBooks();
                        if(bookshelf.Count == 0)
                            Console.WriteLine("No books to be found!\n");
                        break;
                    case 3:
                        isRunning = false;
                        break;
                }
            }
        }

        private static void RegisterBook()
        {
            Console.Clear();

            Console.WriteLine("Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            Console.WriteLine("Is the book a 1. Novel, 2. Journal or 3. Poetry?");

            if (int.TryParse(Console.ReadLine(), out int bookType))
            {
                Console.WriteLine("\nSaved\n");
                switch (bookType)
                {
                    case 1:
                        var b1 = new Novel(title, author, "(novel)");
                        bookshelf.Add(b1);
                        Console.WriteLine(b1);
                        break;
                    case 2:
                        var b2 = new Journal(title, author, "(journal)");
                        bookshelf.Add(b2);
                        Console.WriteLine(b2);
                        break;
                    case 3:
                        var b3 = new Poetry(title, author, "(poetry)");
                        bookshelf.Add(b3);
                        break;
                }
            }
            /*else
            { 
                Console.WriteLine("Wrong entry\n"); //hade problem här med att få min if(tryparse) att fungera som tänkt. 
                                                    //vill att användaren ska få en ny chans utan att behöva börja om från början. 
                                                    //"wrong entry" matas även ut felaktigt fast man matar in rätt värde.
            }*/
        }

        private static void PrintBooks()
        {
            Console.Clear();

            foreach(Book b in bookshelf)
                Console.WriteLine(b.ToString() + "\n"); //försökte få PrintBooks() att iterera över alla böcker i listan men fick det inte att funka.
        }
    }
}
