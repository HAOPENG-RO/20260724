using System;
using System.Collections.Generic;
using System.Text;

namespace Nisyuu2
{
    internal class Dog
    {
        private string mName = "";    // 名前
        private int mAge = 0;        // 年齢
        private string mBreed; // 種類

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public int Age
        {
            get { return mAge; }
            set { mAge = value; }
        }

        public Dog(string breed)
        {
           mBreed = breed;
        }


        public void ShowProfile()
        {
            Console.WriteLine(mName);
            Console.WriteLine(mAge);
            
        }

    }
}
