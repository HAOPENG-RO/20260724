using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class PartTimeEmployee: Employee, IReportable
    {
        public decimal HourlyRate { get; set; }
        public decimal WorkedHour { get; set; }

       public PartTimeEmployee(string name, decimal hourlyRate, decimal monthlyRate)
            : base(name, 0)
        {
            HourlyRate = hourlyRate;
            WorkedHour = monthlyRate;
        }
        public override decimal CalculateSalary()
        {
            return HourlyRate * WorkedHour;
        }
        public string GenerateReport()
        {
            return $"【給与明細】\n" +
                       $"名前：{Name}\n" +
                       $"種別：アルバイト\n" +
                       $"支給額：{CalculateSalary()}円";
        }
    }
}
