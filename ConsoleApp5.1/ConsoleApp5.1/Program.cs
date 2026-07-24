using ConsoleApp5._1;
using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;

class Program
{
    static void Main()
    {
        //using (StreamWriter writer = new StreamWriter("output.txt"))
        //{
        //    writer.WriteLine("呂浩鵬");
        //    writer.WriteLine("24歳");
        //    writer.WriteLine("中国人　");

        //}
        //Console.WriteLine("書き込みが完了しました");

        //string filePath = "output.txt";

        //if (File.Exists(filePath))
        //{
        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        string line;
        //        int lineNumber = 1;

        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            Console.WriteLine($"{lineNumber}: {line}");
        //            lineNumber++;
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("ファイルは存在しません。");
        //}

        //using (StreamWriter writer = new StreamWriter(path, append: false))
        //{
        //    writer.WriteLine("2026/06/18 10:21");

        //}

        //String path = Console.ReadLine();
        //if (File.Exists(path)) {
        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(path))
        //        {
        //            string line;
        //            while ((line = reader.ReadLine()) != null)
        //            {
        //                Console.WriteLine(line);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("ファイルは存在しません。");
        //}

        //string directoryPath = Path.Combine("data", "logs");
        //Directory.CreateDirectory(directoryPath);


        //string filePath = Path.Combine(directoryPath, "today.txt");


        //using (StreamWriter writer = new StreamWriter(filePath))
        //{
        //    writer.WriteLine("2026/06/18");
        //}

        //Console.WriteLine("ファイルを作成しました。");
        //using (StreamReader reader = new StreamReader(filePath))
        //{
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}


        //String filePath = "data";
        //string[] files = Directory.GetFiles(filePath, "*.txt");
        //if(files.Length == 0)
        //{
        //    Console.WriteLine("ファイルないぞ");
        //}
        //foreach(string file in files)
        //{
        //    FileInfo info = new FileInfo(file);
        //    Console.WriteLine(info.Name);
        //    Console.WriteLine(info.Length);
        //    Console.WriteLine(info.CreationTime);
        //}

        //string path = "quick.txt";
        //string[] lines = { "これは1行目のテキストです", "これは2行目のテキストです。", "これは3行目のテキストです。" };

        //File.WriteAllLines(path, lines);

        //string[] readLines = File.ReadAllLines("quick.txt");
        //foreach(string line in readLines)
        //{
        //    Console.WriteLine(line);
        //}

        //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        //string fileName = "users.csv";
        //List<User> Users = new List<User>();

        //string users = Console.ReadLine();


        //File.AppendAllText(fileName, users + Environment.NewLine,Encoding.GetEncoding("shift_jis"));
        //using (StreamReader reader =
        //    new StreamReader(fileName, Encoding.GetEncoding("shift_jis")))
        //{

        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        string[] columns = line.Split(',');
        //        if (columns.Length != 2)
        //        {
        //            Console.WriteLine("警告: 列数が不正です → " + line);
        //            continue;
        //        }
        //        string name = columns[0];
        //        string age = columns[1];

        //        Console.WriteLine($"Name={name}, Age={age}");
        //    }
        //}

        //using (StreamReader reader =
        //new StreamReader(fileName, Encoding.GetEncoding("shift_jis")))
        //{
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        string[] parts = line.Split(',');
        //        if (!int.TryParse(parts[1], out int age))
        //        {
        //            Console.WriteLine("警告: 年齢が不正 → " + line);
        //            continue;
        //        }

        //        User user = new User
        //        {
        //            Name = parts[0],
        //            Age = age
        //        };

        //        Users.Add(user);
        //    }
        //    foreach (var u in Users)
        //    {
        //        Console.WriteLine(u);
        //    }
        //    Console.WriteLine("-------------------");



        //    var sorted = Users
        //        .OrderByDescending(u => u.Age)
        //        .ToList();


        //    foreach (var u in sorted)
        //    {
        //        Console.WriteLine(u);
        //    }


        //}


        //Console.WriteLine("------------------------");
        //PrintUsersTable(Users);

        //string path = "utf8.txt";
        //using (StreamWriter writer =
        //   new StreamWriter(path, append: false, Encoding.UTF8))
        //{
        //    writer.WriteLine("あ");
        //    writer.WriteLine("い");
        //    writer.WriteLine("う");
        //    writer.WriteLine("え");
        //    writer.WriteLine("お");
        //}
        //using (StreamReader reader =
        //   new StreamReader(path, Encoding.UTF8))
        //{
        //    string line;

        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}
        try
        {
           
            Log("ro");
            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    static void PrintUsersTable(List<User> Users)
    {
        Console.WriteLine("Name/Age");
        Console.WriteLine(new string('-', 26));

        foreach (var u in Users)
        {
            Console.WriteLine($"{u.Name,-4}/ {u.Age,2}");
        }
    }
    static void Log(string  message)
    {
        string directoryPath = Path.Combine("data", "logs");
        Directory.CreateDirectory(directoryPath);
        string filePath = Path.Combine(directoryPath, "app.log");
        Console.WriteLine("起動");
        string logLine =
           $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss} {message}" ;
        
        File.AppendAllText(
            filePath,
            logLine + Environment.NewLine);

        Console.WriteLine("終了");

    }

}