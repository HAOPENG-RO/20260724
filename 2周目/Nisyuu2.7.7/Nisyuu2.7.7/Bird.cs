using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu2._7._7
{
    internal class Bird:Animal,IPlayable
    {
        public Bird(string name, int age) : base(name, age) { }
        public override void Speak()
        {
            Console.WriteLine("ピヨピヨ");
        }
        public void Fly()
        {
            Console.WriteLine("さよなら");
        }

        public override string Species
        {
            get { return "Bird"; }
        }

        protected override void MoveCore()
        {
            Console.WriteLine("飛ぶ");
        }
        public void Play()
        {
            Console.WriteLine("羽ばたいて遊ぶ");
        }
    }
}
