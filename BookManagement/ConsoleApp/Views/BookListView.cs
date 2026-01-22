using ConsoleApp.Framework;
using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Views
{
    using Models;
    /// <summary>
    /// class để hiển thị danh sách Book
    /// </summary>
    public class BookListView
    {
        protected Book[] Model; // mảng của các object kiểu Book
        /// <summary>
        /// hàm tạo
        /// </summary>
        /// <param name="model">danh sách object kiểu Book</param>
        public BookListView(Book[] model)
        {
            Model = model;
        }
        /// <summary>
        /// in danh sách ra console
        /// </summary>
        public void Render()
        {
            if (Model.Length == 0)
            {
                ViewHelp.WriteLine("No book found!", ConsoleColor.Yellow);
                return;
            }
            ViewHelp.WriteLine("THE BOOK LIST", ConsoleColor.Green);
            int i = 0;
            while (i < Model.Length)
            {
                ViewHelp.Write($"[{Model[i].Id}]", ConsoleColor.Yellow);
                ViewHelp.WriteLine($" {Model[i].Title}", Model[i].Reading ? ConsoleColor.Cyan : ConsoleColor.White);
                i++;
            }
        }
    }
}

