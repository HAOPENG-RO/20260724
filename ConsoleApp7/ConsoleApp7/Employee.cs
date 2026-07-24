using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public abstract decimal CalculateSalary();

        public virtual void ShowProfile()
        {
            Console.WriteLine($"名前: {Name},  種別: {(this is FullTimeEmployee ? "正社員" : "アルバイト")}");
           
        }
    }
}
