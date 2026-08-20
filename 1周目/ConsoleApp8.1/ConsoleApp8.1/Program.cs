using ConsoleApp8._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


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
        //8.3
        //List<Product> products = new List<Product>();
        //products.Add(new Product("りんご",100,"果物"));
        //products.Add(new Product("バナナ", 150, "果物"));
        //products.Add(new Product("にんじん", 80, "野菜"));
        //products.Add(new Product("じゃがいも", 120, "野菜"));
        //Console.WriteLine("商品一覧");
        //foreach (var product in products)
        //{
        //    Console.WriteLine($"商品名: {product.Name}, 価格: {product.Price}, カテゴリ: {product.Category}");
        //}
        //var sorted = products
        //    .OrderByDescending(P => P.Price)
        //    .GroupBy(P => P.Category)
        //    .ToList();
        //foreach (var u in sorted)
        //{
        //    Console.WriteLine(u);
        //}
        //8.4
        //    List<book> books = new List<book>();
        //    string filePath = "books.csv";
        //    books.Add(new book("吾輩は猫である", "夏目漱石", true));
        //    books.Add(new book("羅生門", "芥川龍之介", false));
        //    books.Add(new book("人間失格", "太宰治", true));
        //    LoadBooksFromCsv(filePath);
        //    Console.WriteLine("操作一覧");
        //    Console.WriteLine("1:本一覧");
        //    Console.WriteLine("2:本追加");
        //    Console.WriteLine("3:本貸出");
        //    Console.WriteLine("4:本返却");
        //    Console.WriteLine("5:終了");
        //    int a = 0;
        //    while (a==0)
        //    {
        //        Console.Write("操作を選択してください：");
        //        int input = int.Parse(Console.ReadLine());
        //        switch (input)
        //        {
        //            case 1:
        //                ShowBooks(books);
        //                break;
        //            case 2:
        //                AddBook(books);
        //                break;
        //            case 3:
        //                LendBook(books);
        //                break;
        //            case 4:
        //                ReturnBook(books);
        //                break;
        //            case 5:
        //                SaveBooksToCsv(books, filePath);
        //                a = 1;
        //                break;
        //            default:
        //                Console.WriteLine("無効な操作です。");
        //                break;
        //        }
        //    } 
        //}
        //public static void SaveBooksToCsv(List<book> books, string filePath)
        //{
        //    using (var writer = new StreamWriter(filePath, false, Encoding.GetEncoding("shift_jis")))
        //    {
        //        foreach (var book in books)
        //        {
        //            writer.WriteLine($"{book.Id},{book.Title},{book.Author},{book.Status}");
        //        }
        //    }
        //}
        //public static List<book> LoadBooksFromCsv(string filePath)
        //{
        //    List<book> books = new List<book>();
        //    if (File.Exists(filePath))
        //    {
        //        using (var reader = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                var line = reader.ReadLine();
        //                var values = line.Split(',');
        //                if (values.Length == 4)
        //                {
        //                    int id = int.Parse(values[0]);
        //                    string title = values[1];
        //                    string author = values[2];
        //                    bool status = bool.Parse(values[3]);
        //                    books.Add(new book(title, author, status));
        //                }
        //            }
        //        }
        //    }
        //    return books;
        //}
        //public static void ShowBooks(List<book> books)
        //{
        //    Console.WriteLine("本一覧");
        //    foreach (var book in books)
        //    {
        //        Console.WriteLine($"ID:{book.Id},タイトル: {book.Title}, 作者: {book.Author},貸出状況 : {(book.Status ? "貸出可能" : "貸出中")}");
        //    }
        //}
        //public static void AddBook(List<book> books)
        //{
        //    Console.Write("タイトルを入力してください：");
        //    string title = Console.ReadLine();
        //    Console.Write("作者を入力してください：");
        //    string author = Console.ReadLine();
        //    books.Add(new book(title, author, true));
        //    Console.WriteLine("本を追加しました。");
        //}
        //public static void LendBook(List<book> books)
        //{
        //    Console.Write("貸出する本のIDを入力してください：");
        //    int id = int.Parse(Console.ReadLine());
        //    var book = books.FirstOrDefault(b => b.Id == id);
        //    if (book != null && book.Status)
        //    {
        //        book.Status = false;
        //        Console.WriteLine($"本「{book.Title}」を貸出しました。");
        //    }
        //    else
        //    {
        //        Console.WriteLine("貸出できません。");
        //    }
        //}
        //public static void ReturnBook(List<book> books)
        //{
        //    Console.Write("返却する本のIDを入力してください：");
        //    int id = int.Parse(Console.ReadLine());
        //    var book = books.FirstOrDefault(b => b.Id == id);
        //    if (book != null && !book.Status)
        //    {
        //        book.Status = true;
        //        Console.WriteLine($"本「{book.Title}」を返却しました。");
        //    }
        //    else
        //    {
        //        Console.WriteLine("返却できません。");
        //    }
        //}
        Console.WriteLine("商品一覧");
        List<Vending> vendingList = new List<Vending>
        {
            new Vending(1, "コーラ", 120, 10),
            new Vending(2, "お茶", 100, 5),
            new Vending(3, "水", 80, 0),
            new Vending(4, "コーヒー", 150, 3),
            new Vending(5, "ジュース", 130, 7)
        };
        foreach (var vending in vendingList)
        {
            Console.WriteLine($"番号: {vending.Number}, 商品名: {vending.Name}, 価格: {vending.Price}, 在庫: {vending.Stock}");
        }
        int money = 0;
        int sales = 0;
        while (true)
        {
            Console.WriteLine("操作を選択してください：");
            Console.WriteLine("1: 商品一覧");
            Console.WriteLine("2: お金を入れる");
            Console.WriteLine("   現在金額：" + money);
            Console.WriteLine("3: 商品を購入する");
            Console.WriteLine("4: 返金する");
            Console.WriteLine("5: 終了");
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("入力エラー");
                continue;
            }
            switch (input)
            {
                case 1:
                    foreach (var vendings in vendingList)
                    {
                        Console.WriteLine($"番号: {vendings.Number}, 商品名: {vendings.Name}, 価格: {vendings.Price}, 在庫: {vendings.Stock}");
                    }
                    break;
                case 2:
                    int a = int.Parse(Console.ReadLine());
                    if(a!= 10 && a != 50 && a != 100 && a != 500 && a != 1000)
                    {
                        Console.WriteLine("無効な金額です。");
                        break;
                    }
                    else
                    {
                        money += a;
                    }
                    break;
                case 3:
                    Console.Write("購入する商品の番号を入力してください：");
                    int number = int.Parse(Console.ReadLine());
                    Vending vending = vendingList
                        .FirstOrDefault(p => p.Number == number);
                    if (vending == null)
                    {
                        Console.WriteLine("商品がありません");
                        break;
                    }
                    if (vending.Stock <= 0)
                    {
                        Console.WriteLine("在庫切れです");
                        break;
                    }
                    if (money < vending.Price)
                    {
                        Console.WriteLine("お金が不足しています");
                        break;
                    }
                    Console.WriteLine($"商品「{vending.Name}」を購入しました。");
                    sales += vending.Price;
                    vending.Stock--;
                    money = money - vending.Price;
                    break;
                case 4:
                    Console.WriteLine($"返金額：{money}");
                    money = 0;
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("無効な操作です。");
                    break;
            }
            Console.WriteLine("-----------------------------------");
        }
    }
    //static void ShowVendingList(List<Vending> vendingList)
    //{
    //    foreach (var vending in vendingList)
    //    {
    //        Console.WriteLine($"番号: {vending.Number}, 商品名: {vending.Name}, 価格: {vending.Price}, 在庫: {vending.Stock}");
    //    }
    //}
}