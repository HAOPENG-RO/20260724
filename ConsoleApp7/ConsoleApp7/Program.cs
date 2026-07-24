using ConsoleApp7;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee emp1 = new FullTimeEmployee("清田", 300000);
        FullTimeEmployee emp2 = new FullTimeEmployee("木田川", 30000);
        PartTimeEmployee emp3 = new PartTimeEmployee("呂", 1000, 100);
        PartTimeEmployee emp4 = new PartTimeEmployee("守永", 12000, 100);

        List<Employee> emp = new List<Employee>
        {
          emp1,emp2,emp3,emp4
        };

        List<IReportable> reportables = new List<IReportable>()
        {
          emp1,emp2,emp3,emp4
        };

        ((FullTimeEmployee)emp[0]).AddOvertimeHours(10);
        ((FullTimeEmployee)emp[1]).AddOvertimeHours(100);

        Employee emps = new FullTimeEmployee("安達",10);
        Console.WriteLine( emps.CalculateSalary());
        ((FullTimeEmployee)emps).AddOvertimeHours(10);
        Console.WriteLine($"残業時間: {((FullTimeEmployee)emps).GetOvertimeHours()}時間");

        FullTimeEmployee f = emps as FullTimeEmployee;
        if (f != null)
        {
            f.AddOvertimeHours(5);
            Console.WriteLine($"残業時間: {f.GetOvertimeHours()}時間");
        }

        int num = 0;
        while (num != 3)
        {
            Console.Write("1:残業時間を表示 ");
            Console.Write("2:給与明細を表示 ");
            Console.Write("3:終了");
            num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                foreach (Employee empes in emp)
                {
                    empes.ShowProfile();
                   
                    if (empes is FullTimeEmployee full)
                    {
                        Console.WriteLine($"残業時間: {full.GetOvertimeHours()}時間");
                    }
                    Console.WriteLine($" 月給: {empes.CalculateSalary()}円");
                    Console.WriteLine("--------------------");
                }
            }
            else if (num == 2)
            {
                foreach (IReportable report in reportables)
                {
                    Console.WriteLine(report.GenerateReport());
                    Console.WriteLine();

                }
            }
            else if (num == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("1か2を入力してください");
            }
        }

    }
    
}
