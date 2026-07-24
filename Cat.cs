using System;
using System.Collections.Generic;
using System.Text;

namespace renshu
{
     class Cat : Animal,IPlayable
    {
        public Cat(string name,int age) : base(name, age)
        {
        }
        
        public void Sleep()
        {
            Console.WriteLine("スースー");
        }
        public override void Speak()
        {
            Console.WriteLine("ニャー");
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
            Console.WriteLine("猫走る");
        }
        public void Play()
        {
            Console.WriteLine("じゃれる");
        }
    }
    

}
