using addresstyou;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    
    static string fileName = "address.csv";
    static void Main()
    {

        List<Person> persons = LoadData();
        while (true) {
            int a = 0;
            Console.WriteLine("1. 一覧表示");
            Console.WriteLine("2. 追加");
            Console.WriteLine("3. 検索");
            Console.WriteLine("4. 削除");
            Console.WriteLine("5. 終了");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowAll(persons);
                    break;
                case "2":
                    AddPerson(persons);
                    break;
                case "3":
                    SearchPerson(persons);
                    break;
                case "4":
                    DeletePerson(persons);
                    break;
                case "5":
                    SaveData(persons);
                    a = 1;
                    break;
                default:
                    Console.WriteLine("無効な選択肢です。");
                    break;
            }
            if (a == 1)
            {
                break;
            }
        }


    }
    //読み込み
    static List<Person> LoadData()
    {
        List<Person> persons = new List<Person>();
        
        if (!File.Exists(fileName))
        {
            File.Create(fileName).Close();
            return persons;
        }

        foreach (string line in File.ReadAllLines(fileName))
        {
            string[] parts = line.Split(',');

            persons.Add(new Person
            {
                Name = parts[0],
                Phone = parts[1],
                Email = parts[2]
            });
        }

        return persons;
    }

    //保存
    static void SaveData(List<Person> persons)
    {
        try
        {
            List<string> lines = new List<string>();
            foreach (Person p in persons)
            {
                lines.Add($"{p.Name},{p.Phone},{p.Email}");
            }

            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
        catch (Exception e)
        {
            Console.WriteLine("保存エラー: " + e.Message);
        }
    }
    //表示
    static void ShowAll(List<Person> persons)
    {
        foreach (Person p in persons)
        {
            Console.WriteLine(p);
        }
    }
    //追加
    static void AddPerson(List<Person> persons)
    {
        try
        {
            Console.Write("名前: ");
            string name = Console.ReadLine();

            Console.Write("電話番号: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Person person = new Person
            {
                Name = name,
                Phone = phone,
                Email = email
            };

            persons.Add(person);

            Console.WriteLine("追加しました。");
        }
        catch (Exception ex)
        {
            Console.WriteLine("追加エラー: " + ex.Message);
        }
    }
    //検索
    static List<Person> SearchPerson(List<Person> persons)
    {
        try
        {
            Console.Write("検索する名前: ");
            string keyword = Console.ReadLine();

            var results = persons
                .Where(p => p.Name.Contains(keyword))
                .ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("該当者なし");
                return new List<Person>(); ;
            }

            foreach (Person p in results)
            {
                Console.WriteLine(p);
            }
            return results;
        }
        catch (Exception ex)
        {
            Console.WriteLine("検索エラー: " + ex.Message);
            return new List<Person>();
        }
        
    }
    //削除
    static void DeletePerson(List<Person> persons)
    {
        try
        {
            List<Person> results = SearchPerson(persons);
            Console.Write("削除する名前: ");
            string name = Console.ReadLine();

            Person target =
                results.FirstOrDefault(p => p.Name == name);

            persons.Remove(target);

            Console.WriteLine("削除しました。");

        }
        catch (Exception ex)
        {
            Console.WriteLine("検索エラー: " + ex.Message);
        }
    }
}