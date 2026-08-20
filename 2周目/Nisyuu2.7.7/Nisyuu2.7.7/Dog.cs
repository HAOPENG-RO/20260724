using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu2._7._7
{
    internal class Dog :Animal,IPlayable
    {
        public Dog(string name, int age) : base(name, age) { }
        public void Run()
        {
            Console.WriteLine("トコトコ");
        }
        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }
        public override string ToString()
        {
            return "[Animal] 名前: " + Name + ", 年齢: " + Age;
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
            Console.WriteLine("走る");
        }
        public void Play()
        {
            Console.WriteLine("ボールで遊ぶ");
        }
    }
}
