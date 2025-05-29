using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги:");
            string bookTitle = Console.ReadLine();

            Console.Write("Введите имя автора:");
            string authorName = Console.ReadLine();

            Console.Write("Введите содержание книги:");
            string bookContent = Console.ReadLine();

            Title title = new Title(bookTitle);
            Author author = new Author(authorName);
            Content content = new Content(bookContent);
            Book book = new Book(title, author, content);

            Console.WriteLine("\nИнформация о книге:\n");
            book.Show();
            Console.Read();



        }
    }
}
