using ConsoleApp8._1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class Program
{
    static void Main()
    {
        //8.1
        //    try
        //    {
        //        Console.Write("数値1を入力してください：");
        //        double num1 = double.Parse(Console.ReadLine());

        //        Console.Write("演算子（+, -, *, /）を入力してください：");
        //        string op = Console.ReadLine();

        //        Console.Write("数値2を入力してください：");
        //        double num2 = double.Parse(Console.ReadLine());

        //        double result = 0;

        //        switch (op)
        //        {
        //            case "+":
        //                result = num1 + num2;
        //                break;

        //            case "-":
        //                result = num1 - num2;
        //                break;

        //            case "*":
        //                result = num1 * num2;
        //                break;

        //            case "/":
        //                if (num2 == 0)
        //                {
        //                    throw new DivideByZeroException();
        //                }
        //                result = num1 / num2;
        //                break;

        //            default:
        //                throw new ArgumentException("演算子が不正です。");
        //        }

        //        Console.WriteLine($"計算結果：{result}");
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("数字を正しく入力してください。");
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("0では割れません。");
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //8.2

        //    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        //    string fileName = "words.csv";
        //    Dictionary<string, string> words = new Dictionary<string, string>();

        //    if (File.Exists(fileName))
        //    {
        //        foreach (string line in File.ReadAllLines(fileName, Encoding.GetEncoding("shift_jis")))
        //        {
        //            string[] data = line.Split(',');

        //            if (data.Length == 2)
        //            {
        //                words[data[0]] = data[1];
        //            }
        //        }
        //    }

        //    while (true)
        //    {
        //        Console.WriteLine("===== 単語帳 =====");
        //        Console.WriteLine("1. 登録");
        //        Console.WriteLine("2. 一覧表示");
        //        Console.WriteLine("3. 検索");
        //        Console.WriteLine("4. 終了");
        //        Console.Write("選択：");

        //        string menu = Console.ReadLine();

        //        switch (menu)
        //        {
        //            case "1":
        //                Console.Write("単語：");
        //                string word = Console.ReadLine();

        //                Console.Write("意味：");
        //                string meaning = Console.ReadLine();

        //                words[word] = meaning;

        //                File.AppendAllText(
        //                    fileName,
        //                    $"{word},{meaning}{Environment.NewLine}",
        //                    Encoding.GetEncoding("shift_jis"));

        //                Console.WriteLine("登録しました。");
        //                break;

        //            case "2":
        //                Console.WriteLine("----- 一覧 -----");

        //                foreach (var item in words)
        //                {
        //                    Console.WriteLine($"{item.Key} : {item.Value}");
        //                }

        //                break;

        //            case "3":
        //                Console.Write("検索する単語：");
        //                string search = Console.ReadLine();

        //                if (words.ContainsKey(search))
        //                {
        //                    Console.WriteLine($"意味：{words[search]}");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("ない");
        //                }

        //                break;

        //            case "4":
        //                return;

        //            default:
        //                Console.WriteLine("番号を入力してください。");
        //                break;
        //        }

        //        Console.WriteLine();
        //    }

        List<Product> products = new List<Product>();
        products.Add(new Product("りんご",100,"果物"));
        products.Add(new Product("バナナ", 150, "果物"));
        products.Add(new Product("にんじん", 80, "野菜"));
        Console.WriteLine("商品一覧");
        foreach (var product in products)
        {
            Console.WriteLine($"商品名: {product.Name}, 価格: {product.Price}, カテゴリ: {product.Category}");
        }




        }
}