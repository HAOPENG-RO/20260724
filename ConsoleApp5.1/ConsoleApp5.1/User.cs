using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5._1
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name={Name}, Age={Age}";
        }
    }
}
