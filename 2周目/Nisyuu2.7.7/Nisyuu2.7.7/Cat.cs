using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu2._7._7
{
    internal class Cat :Animal,IPlayable
    {
        public Cat(string name,int age) : base(name,age) { }
      
        public void sleep()
        {
            Console.WriteLine("スースー");
          
        }
        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
        public override string ToString()
        {
            return "[Animal] 名前: " + Name + ", 年齢: " + Age;
        }
        public override string Species
        {
            get { return "Cat"; }
        }
        public new void ShowKind()
        {
            Console.WriteLine("猫です");
        }
        protected override void MoveCore()
        {
            Console.WriteLine("歩く");
        }
        public void Play()
        {
            Console.WriteLine("じゃれる");
        }
    }
}
