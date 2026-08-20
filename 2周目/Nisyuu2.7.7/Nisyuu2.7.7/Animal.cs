using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nisyuu2._7._7
{
    internal abstract class Animal
    {
        public string Name { get; private set; }    // 名前
        public int Age { get; private set; }        // 年齢

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return "[Animal] 名前: " + Name + ", 年齢: " + Age;
        }

        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }

        public abstract void Speak();

        public virtual void Walk()
        {
            Console.WriteLine("トコトコ歩く");
        }
        public void Walk(int steps)
        {
            Console.WriteLine(steps + "歩歩いた");
        }
       public virtual string Species 
       {
            get { return "Anime"; }
       }
        public void ShowKind()
        {
            Console.WriteLine("動物です");
        }

        protected abstract void MoveCore();
        public void DoDaily()
        {
            ShowProfile();
            Speak();
            MoveCore();
        }

    }
}
