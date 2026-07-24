using Console3;
internal class Program
{
    enum Season { Spring=0, Summer=1, Autumn=2, Winter=3 }
    public struct Point
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
            Console.WriteLine("("+X+","+Y+")");
        }
    }

    static void Main()
    {
        // Student student = new Student();

        //student.Name = "ro";
        //student.Age = 24;

        //student.ShowProfile();

        //Season se = Season.Summer;
        //Console.WriteLine(se);

        //int num = int.Parse(Console.ReadLine());
        //Season se = (Season)num;
        //Console.WriteLine(se);

        Point p = new Point(5,10);
        p.ShowPoint();






    }
}

