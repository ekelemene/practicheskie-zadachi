using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    class Title
    {
        string title;
        public Title(string title)
        {
            this.title = title; 
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Название книги: " + title);
            Console.ResetColor();
        }
    }
}
