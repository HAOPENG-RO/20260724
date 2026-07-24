using ConsoleApp6;
using System.Globalization;

class Program
{
    static void Main()
    {
        //List<int> list = new List<int>();
        //for (int i = 1; i < 6; i++)
        //{
        //    Console.WriteLine(i+"番目の数字を入力");
        //    int num = int.Parse(Console.ReadLine());
        //    list.Add(num);
        //}
        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine(list.Sum());
        //List<string> list = new List<string>();
        //list.Add("リング");
        //list.Add("バナナ");
        //list.Add("みかん");

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}
        //string key = Console.ReadLine();
        //if (list.Contains(key))
        //{
        //    Console.WriteLine("いる");
        //}
        //else
        //{
        //    Console.WriteLine("ないす");
        //}
        //Dictionary<string, int>dic = new Dictionary<string, int>();
        //dic.Add("Japan",125);
        //dic.Add("USA", 331);
        //dic.Add("France", 67);
        //foreach (var item in dic)
        //{
        //    Console.WriteLine(item.Key + "の人口は" + item.Value + "万人です");
        //}
        // string key = Console.ReadLine();
        //var results = dic
        //        .Where(p => p.Key.Contains(key))
        //        .ToList();
        //if (results.Count == 0)
        //{
        //    Console.WriteLine("ないす");
        //}
        //else
        //{
        //    Console.WriteLine(results[0].Key + "の人口は" + results[0].Value + "万人です");
        //}

        //List<Student> list = new List<Student>();
        //list.Add(new Student { Name = "呂", Score = 80 });
        //list.Add(new Student { Name = "清田", Score = 800 });
        //list.Add(new Student { Name = "木田川", Score = 8 });
        //list.Add(new Student { Name = "Animal", Score = 80 });
        //list.Add(new Student { Name = "Anime", Score =8 });
        //foreach (var item in list)
        //{
        //    Console.WriteLine(item.Name + "の点数は" + item.Score + "点です");
        //}

        //List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //var gusu = num.Where(p => p % 2 == 0);
        //foreach (var item in gusu)
        //{
        //    Console.WriteLine(item);
        //}

        //List<string> list = new List<string> { "apple", "banana", "cherry", "date" };
        //var adults = list.OrderBy(p => p);

        //foreach (var p in adults)
        //{
        //    Console.WriteLine(p);
        //}

        //List<int> num = new List<int> { 1, 2, 3, 4, 5 };
        //var doubled = num.Select(n => n * 2).ToList();
        //foreach (var item in doubled)
        //{
        //    Console.WriteLine(item);
        //}
        //List<int> num = new List<int> { 80, 92, 75, 60, 45 };
        //Console.WriteLine(num.Average());
        //var ok = num.Count(n => n>= 70);
        //Console.WriteLine(ok);

        //var ok = list.Where(p => p.Score >= 70 && p.Name.StartsWith("A"));
        //foreach (var item in ok)
        //{
        //    Console.WriteLine(item.Name + "の点数は" + item.Score + "点です");
        //}

        //List < Student > list = new List<Student> () ;
        //list.Add(new Student { Name = "Alice", Score = 80 });
        //list.Add(new Student { Name = "Bob", Score = 75 });
        //list.Add(new Student { Name = "Charlie", Score = 80 });
        //list.Add(new Student { Name = "Dave", Score = 60 });

        //var grouped = list.GroupBy(e => e.Score);
        //foreach (var group in grouped)
        //{
        //    Console.WriteLine($"Score: {group.Key}");
        //    foreach (var student in group)
        //    {
        //        Console.WriteLine($"  Name: {student.Name}");
        //    }

        //List<Product> pr = new List<Product>();
        //pr.Add(new Product { Name = "AirPods", Price = 100, Category = "イヤホン" });
        //pr.Add(new Product { Name = "AirPods", Price = 150000, Category = "イヤホン" });
        //pr.Add(new Product { Name = "AirPods", Price = 500, Category = "イヤホン" });
        //pr.Add(new Product { Name = "AirPods", Price = 20000, Category = "イヤホン" });
        //pr.Add(new Product { Name = "AirPods", Price = 300, Category = "イヤホン" });

        //var grouped = pr
        //        .Where(p => p.Price >= 1000)
        //        .GroupBy(p => p.Category);

        //foreach (var group in grouped)
        //{
        //    Console.WriteLine(group.Key);
        //    Console.WriteLine(group.Count());

        //    foreach (var product in group.OrderByDescending(p => p.Price))
        //    {
        //        Console.WriteLine($"  {product.Name} : {product.Price}円");
        //    }

        //}
        int s = 0;
        int b = 0;
        int sw = int.Parse(Console.ReadLine());
        while(s>=3 || b >= 4)
        {
            if (sw == 1)
            {
                s++;
            }else if (sw == 2)
            {
                b++;
            }

        }
        Console.WriteLine(s + "," + b);
    }
}