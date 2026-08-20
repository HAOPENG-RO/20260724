using System;

namespace Nisyuu3
{
    enum Season {Spring,Summer,Autumn,Winter}
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ShowPoint()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
    class Program
    {
        static void Main()
        {
            Student student = new Student();
            student.Name = "木田川";
            student.Age = 20;
            student.ShowProfile();

            //Season season = Season.Summer;
            //Console.WriteLine(season);

            Console.Write("0～3の整数を入力してください：");
            int number = int.Parse(Console.ReadLine());
            Season season = (Season)number;
            Console.WriteLine(season);

            Point point = new Point(5, 10);

            point.ShowPoint();

            Counter counter1 = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();
            Console.WriteLine(Counter.GetCount());

            Console.WriteLine("--------------------------");
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}