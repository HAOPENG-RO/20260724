using System;
using System.Collections.Generic;
using System.Text;

namespace addresstyou
{
    internal class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"名前: {Name}, 電話: {Phone}, Email: {Email}";
        }
    }
}
