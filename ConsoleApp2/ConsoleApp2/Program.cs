//int s = 0;
//int b = 0;


//while (s < 3 && b < 4)
//{
//    int sw = int.Parse(Console.ReadLine());
//    if (sw == 1)
//    {
//        s++;
//    }
//    else if (sw == 2)
//    {
//        b++;
//    }else if (sw == 3)
//    {
//        if (s < 2)
//        {
//            s++;
//        }
//    }

//}
//Console.WriteLine(s + "," + b);
//Console.WriteLine("---------------------");

//int[] numbers = new int[10];
//for (int i = 0; i < 10; i++)
//{
//numbers[i] = int.Parse(Console.ReadLine());
//}
//foreach (int num in numbers)
//{
//    Console.WriteLine(num*2);
//}
//List<int> gu = new List<int>();
//List<int> ki = new List<int>();
//for (int i = 0; i < 10; i++)
//{
//    int numbers = int.Parse(Console.ReadLine());
//    if (numbers % 2 == 0)
//    {
//        gu.Add(numbers);
//    }
//    else
//    {
//        ki.Add(numbers);
//    }
//}
//Console.Write("偶数：");
//foreach (int num in gu)
//{
//    Console.Write(num);
//}
//Console.WriteLine();
//Console.Write("奇数");
//foreach (int num in ki)
//{
//    Console.Write(num);
//}

//int[,] kuku = new int[9, 9];

////配列 kuku に値を代入する
//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        kuku[i, j] = (i + 1) * (j + 1);
//        Console.Write(" {0,2}", kuku[i, j]);

//    }
//    Console.WriteLine();
//}



//int[] numbers = new int[10];
//for (int i = 0; i < 10; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < 10; i++)
//{
//    for (int j = i+1; j < 10; j++)
//    {
//        if (numbers[i] > numbers[j])
//        {
//            int temp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = temp;
//        }
//    }
//}
//Console.WriteLine("-----------------------");
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}
using System;

class Program
{
    public static void Main()
    {
        int t= a(2);
        Console.WriteLine(t);
        int avg1 = avg(3, 4);
        Console.WriteLine(avg1);
        int max = Max2(1, 2, 3);
        Console.WriteLine(max);
        Console.WriteLine("---------------------------");
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int Max = Max1(numbers);
        Console.WriteLine("入力された最大値は" + numbers[Max]);
        int Min = Min1(numbers);
        Console.WriteLine("入力された最小値は" + numbers[Min]);
        int Avg = Average(numbers);
        Console.WriteLine("入力された平均値は" + Avg);
    }

    public static int a(int x) {
        return x*x;
    }
    public static int avg(int x, int y)
    {
        return (x+y) / 2;
    }

    public static int Max2(int x,int y, int z)
    {
        int max=0;
        if(x>y && x > z)
        {
            max= x;
        }else if (y>x && y>z)
        {
            max= y;
        }else if (z>x && z > y)
        {
            max= z;
        }
        return max;
    }
    public static int Max1(int[] num)
    {
        int max = 0;
        for (int i = 1; i < num.Length; i++) {
            if (num[max] < num[i]){
                max = i;
            }
        }
        return max;
    }

    public static int Min1(int[] num)
    {
        int min = 0;
        for (int i = 1; i < num.Length; i++)
        {
            if (num[min] > num[i])
            {
                min = i;
            }
        }
        return min;
    }
    public static int Average(int[] num)
    {
        int avg = 0;
        int sum = 0;
        for(int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        avg = sum / num.Length;
        return avg;
    }
}
