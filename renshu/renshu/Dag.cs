using System;
using System.Collections.Generic;
using System.Text;

namespace renshu
{
    class Dag : Animal,IPlayable
    {
        public Dag(string name, int age) : base(name, age)
        {
        }
       
        public void Run()
        {
            Console.WriteLine("トコトコ");
        }
        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }

        public override void Walk()
        {
            Console.WriteLine("尻尾を振りながら歩く");
        }
        public override string Species
        {
            get { return "Dog"; }
        }

        protected override void MoveCore()
        {
            Console.WriteLine("犬走る");
        }

        public void Play()
        {
            Console.WriteLine("ボールで遊ぶ");
        }
    }
}
