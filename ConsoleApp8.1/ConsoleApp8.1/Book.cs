using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8._1
{
    internal class book
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Status { get; set; }
        private static int nextId = 1;
        public book(string title, string author, bool status)
        {
            Id = nextId++;
            Title = title;
            Author = author;
            this.Status = status;
        }
    }
}
