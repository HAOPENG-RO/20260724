using System;
using System.Collections.Generic;
using System.Text;

namespace Console3
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowProfile()
        {
            Console.WriteLine($"名前: {Name}");
            Console.WriteLine($"年齢: {Age}");
        }
    }
}
