using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Book
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }

        public Book(Title title, Author author, Content content)
        {
            Title = title;
            Author = author;
            Content = content;
        }
        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }




    }
}
