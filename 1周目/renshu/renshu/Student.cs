using System;
using System.Collections.Generic;
using System.Text;

namespace renshu
{
    internal class _3
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
