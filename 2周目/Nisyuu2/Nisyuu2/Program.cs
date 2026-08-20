//Console.WriteLine("Hello, World!");
//int x = 11;
//Console.WriteLine("x="+x);
//int x=13+17;
//Console.WriteLine(x);
//Console.WriteLine(13*17);
using System.Diagnostics;

namespace Nisyuu2
{
    internal class Program()
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //Console.WriteLine(s);
            //int x =int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine((x + y)/2);
            //Console.WriteLine("年齢を入力してください");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age*365+"日");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //if (x > y)
            //{
            //    Console.WriteLine("xの方が大きいです");
            //}
            //else if (x < y)
            //{
            //    Console.WriteLine("yの方が大きいです");

            //}
            //else
            //{
            //    Console.WriteLine("xとyは同じです");
            //}
            //int x = int.Parse(Console.ReadLine());
            //if(x%2==0)
            //{
            //    Console.WriteLine("偶数です");
            //}
            //else
            //{
            //    Console.WriteLine("奇数です");
            //}

            //Console.WriteLine("点数を入力してください");
            //int score = int.Parse(Console.ReadLine());
            //if(score >= 60)
            //{
            //    Console.WriteLine("合格");
            //}
            //else
            //{
            //    Console.WriteLine("不合格");
            //}
            //if (score >= 80)
            //{
            //    Console.WriteLine("たいへんよくできました");
            //}
            //else if(score >= 60)
            //{
            //    Console.WriteLine("よくできました");
            //}else
            //{
            //    Console.WriteLine("ざんねんでした");
            //}
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //if (x<y && x%2==0 && y%2==0)
            //{
            //    Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
            //}
            //if (x==y && x<0)
            //{
            //    Console.WriteLine("xとyは等しく、かつ、負の数である。");
            //}
            //if (x<y || x%2==0)
            //{
            //    Console.WriteLine("xはyより小さい、または、xは偶数である。");
            //}

            //if ((x<=10 || x>=100) && (y>=10 && y<=100))
            //{
            //    Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
            //}
            //if (!(x<0 && y<0))
            //{
            //    Console.WriteLine("xもyも負の数である、ではない。");
            //}

            //Console.WriteLine("1：まぐろ　2：えび　3：こはだ...");
            //Console.WriteLine("番号を入力してください");
            //int i = int.Parse(Console.ReadLine());
            //switch (i)
            //{
            //    case 1:
            //        Console.WriteLine("まぐろ");
            //        break;
            //    case 2:
            //        Console.WriteLine("えび");
            //        break;
            //    case 3:
            //        Console.WriteLine("こはだ");
            //        break;
            //    default:
            //        break;
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("SPAM");
            //}
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("3*"+i+"="+(3*i));
            //}
            //Console.WriteLine("整数を入力してください");
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //   sum+=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(sum / 5);

            //int k = 0;
            //int h = 0;

            //for (int i = 1; i < 5; i++)
            //{
            //    Console.Write(i+"回目、巨人の得点は");
            //    k += int.Parse(Console.ReadLine());
            //    Console.Write(i+"回目、阪神の得点は");
            //    h += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("巨人の合計得点は" + k+"点");
            //Console.WriteLine("阪神の合計得点は" + h+"点");
            //if(k>h)
            //{
            //    Console.WriteLine("巨人の勝ち");
            //}
            //else if(k<h)
            //{
            //    Console.WriteLine("阪神の勝ち");
            //}
            //else
            //{
            //    Console.WriteLine("引き分け");
            //}

            //int s = 0;
            //int b = 0;
            //while(s<3 && b < 4)
            //{
            //    Console.WriteLine("1：ストライク　2：ボール 3 :ファウル");
            //    int i = int.Parse(Console.ReadLine());
            //    if (i == 1)
            //    {
            //        s++;
            //        Console.WriteLine("ストライク" + s + "ボール" + b);

            //    }
            //    else if (i == 2)
            //    {
            //        b++;
            //        Console.WriteLine("ストライク" + s + "ボール" + b);
            //    }else if (i == 3 && s<2)
            //    {
            //        s++;
            //        Console.WriteLine("ストライク" + s + "ボール" + b);
            //    }
            //}

            //int[] num =new int[5];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int i in num)
            //{
            //    Console.WriteLine(i*2);
            //}
            //int[] num = new int[5];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int i in num)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + "は偶数です");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + "は奇数です");
            //    }
            //}
            //int[,] kuku = new int[9, 9];

            // 配列 kuku に値を代入する

            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        kuku[i, j] = (i + 1) * (j + 1);
            //        Console.Write(" {0,2}", kuku[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            // int[] num = new int[5];
            // for (int i = 0; i < num.Length; i++)
            // {
            //     num[i] = int.Parse(Console.ReadLine());
            // }

            //for (int i = 0; i < num.Length; i++)
            // {
            //     for (int j = i + 1; j <num.Length; j++)
            //     {
            //         if (num[i] > num[j])
            //         {
            //             int temp = num[i];
            //             num[i] = num[j];
            //             num[j] = temp;
            //         }
            //     }
            // }
            // foreach (int i in num)
            // {
            //     Console.WriteLine(i);
            // }
            //Console.WriteLine( Ni(int.Parse(Console.ReadLine())));
            //Console.WriteLine(avg(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            //Console.WriteLine("整数を入力してください");
            //int[] num = new int[5];
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("平均値は" + avg(num));
            //Console.WriteLine("最大値は" + Max(num));
            //Console.WriteLine("最小値は" + Min(num));

            //2.7
            //Dog dog1 = new Dog("柴犬");
            //dog1.Name = "ポチ";
            //dog1.Age = 3;
            //dog1.ShowProfile();
            //Dog dog2 = new Dog("");
            //dog2.Name = "ハチ";
            //dog2.Age = 5;
            //dog2.ShowProfile();

            CoinCase coinCase = new CoinCase();
            int a = 0;
            while (a == 0)
            {
                Console.WriteLine("操作を入力");
                Console.WriteLine("1:コインを入れる、２コイン精算、３金額精算、４終了");
                switch (int.Parse(Console.ReadLine())) {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("コインの種類を入力してください");
                            int coin = int.Parse(Console.ReadLine());
                            Console.WriteLine("枚数を入力してください");
                            int count = int.Parse(Console.ReadLine());
                            coinCase.AddCoin(coin, count);
                            
                        }
                        Console.WriteLine("500円：" + coinCase.GetCoin(500) + "枚");
                        Console.WriteLine("100円：" + coinCase.GetCoin(100) + "枚");
                        Console.WriteLine("50円：" + coinCase.GetCoin(50) + "枚");
                        Console.WriteLine("10円：" + coinCase.GetCoin(10) + "枚");
                        Console.WriteLine("5円：" + coinCase.GetCoin(5) + "枚");
                        Console.WriteLine("1円：" + coinCase.GetCoin(1) + "枚");
                        Console.WriteLine("総合枚数" + coinCase.GetCount());
                        break;
                    case 2:
                        Console.WriteLine(coinCase.GetCoin(int.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        Console.WriteLine(coinCase.GetAmount());
                        break;
                    case 4:
                        a = 1;
                        break;
                    default:
                        break;

                }
            }

        }
    }
    //public static int Ni(int x)
    //{
    //    return x * x;
    //}
    //public static int avg(int[] num)
    //{
    //    int sum = 0;
    //    foreach (int x in num)
    //    {
    //      sum+= x;  
    //    }
    //    return sum/num.Length;
    //}
    //public static int Max(int[] num)
    //{
    //   int max= num[0];
    //    for (int i = 1; i < num.Length; i++)
    //    {
    //        if(num[i]>max)
    //        {
    //            max = num[i];
    //        }
    //    }
    //    return max;
    //}
    //public static int Min(int[] num)
    //{
    //    int min = num[0];
    //    for (int i = 1; i < num.Length; i++)
    //    {
    //        if (num[i] < min)
    //        {
    //            min = num[i];
    //        }
    //    }
    //    return min;
    //}

    
}