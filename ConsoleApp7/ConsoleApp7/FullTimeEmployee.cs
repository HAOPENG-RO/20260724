using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class FullTimeEmployee: Employee, IOvertimeEligible,IReportable
    {
        int overtimeHours;
        public FullTimeEmployee(string name, decimal baseSalary) 
            : base(name, baseSalary)
        {
            
        }
        public override decimal CalculateSalary()
        {
            decimal overtimePay = overtimeHours * (BaseSalary / 160) * 1.25m;
            return BaseSalary + overtimePay;
        }
        public void AddOvertimeHours(int hours)
        {
            overtimeHours += hours;
        }
        public int GetOvertimeHours()
        {
            return overtimeHours;
        }
        public string GenerateReport()
        {
            return $"【給与明細】\n" +
                       $"名前：{Name}\n" +
                       $"種別：正社員\n" +
                       $"残業時間：{GetOvertimeHours()}時間\n" +
                       $"支給額：{CalculateSalary()}円";
        }
       
    }
}
