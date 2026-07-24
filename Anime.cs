using System;
using System.Collections.Generic;
using System.Text;

namespace renshu
{
    abstract class Animal
    {

        public string Name { get; private set; }    // 名前
        public int Age { get; private set; }        // 年齢

        public virtual string Species
        {
            get { return "Animal"; }
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
           
        }
        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }

        public override string ToString()
        {
            return $"{Species} 名前: {Name}, 年齢: {Age}";
        }

        public abstract void Speak();

        public virtual void Walk()
        {
            Console.WriteLine("トコトコ歩く");
        }
       
        public void Walk(int steps)
        {
            Console.WriteLine(steps+ "歩いた");
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
