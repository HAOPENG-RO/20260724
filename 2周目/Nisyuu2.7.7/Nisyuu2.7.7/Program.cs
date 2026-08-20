using Nisyuu2._7._7;
using System;

namespace Nisyuu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("cat", 3);
            Dog dog = new Dog("dog", 10);
            Bird bird = new Bird("bird", 2);
            //cat.ShowProfile();
            //cat.sleep();
            //dog.ShowProfile();
            //dog.Run();
            //cat.Speak();
            //dog.Speak();
            //Console.WriteLine("-----------------------");
            //Animal[] animals = new Animal[4];
            //animals[0] = new Cat("cat1", 1);
            //animals[1] = new Dog("dog1", 1);
            //animals[2] = new Cat("cat2", 1);
            //animals[3] = new Dog("dog2", 1);
            //foreach (Animal c in animals)
            //{
            //    c.ShowProfile();
            //    c.Speak();
            //}
            //Animal obj;
            //obj = new Dog("dog1", 1);
            //Console.WriteLine(obj);
            //obj = new Cat("cat1", 2);
            //Console.WriteLine(obj);

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("dog1", 1));
            animals.Add(new Dog("dog2", 2));
            animals.Add(new Cat("cat1", 1));
            animals.Add(new Bird("bird1", 2));
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(bird);

            foreach (Animal animal in animals)
            {
                animal.Speak();
                if (animal is Bird b)
                {
                    b.Fly();
                }
                animal.DoDaily();
                Console.WriteLine(animal.Species);

            }
            Console.WriteLine("----------------");

            Animal dog1 = new Dog("dog1", 2);
            dog1.Walk();
            dog1.Walk(3);
            Console.WriteLine("------------------");

            Cat cat1 = new Cat("cat2", 2);
            Animal animal1 = new Cat("cat3", 4);
            cat1.ShowKind();
            animal1.ShowKind();

            Dog d1 = (Dog)dog;
            d1.Run();
            Dog d2 = dog as Dog;
            if (d2 != null)
            {
                d2.Run();
            }
            if (dog is Dog d3)
            {
                d3.Run();
            }
            Console.WriteLine("-------------------");
            List<IPlayable> play = new List<IPlayable>();
            play.Add(dog);
            play.Add(cat);
            play.Add(bird);

            foreach (IPlayable i in play)
            {
                i.Play();
            }
            Console.WriteLine("--------------------");


            List<Animal> animalss = new List<Animal>();
            Dictionary<string, int> counts = new Dictionary<string, int>();

           
            Console.Write("動物の数：");
            int n = int.Parse(Console.ReadLine());

        
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string kind = input[0];
                string name = input[1];
                int age = int.Parse(input[2]);

                Animal animal = null;

                
                switch (kind)
                {
                    case "Dog":
                        animal = new Dog(name, age);
                        break;

                    case "Cat":
                        animal = new Cat(name, age);
                        break;

                    case "Bird":
                        animal = new Bird(name, age);
                        break;

                    default:
                        Console.WriteLine("不明な種類です。");
                        continue;
                }

               
                animalss.Add(animal);

                if (counts.ContainsKey(kind))
                {
                    counts[kind]++;
                }
                else
                {
                    counts[kind] = 1;
                }
            }

    
            Console.WriteLine("動物一覧 ");

            foreach (Animal animal in animalss)
            {
                animal.ShowProfile();
                animal.Speak();

          
                if (animal is IPlayable playable)
                {
                    playable.Play();
                }

                Console.WriteLine();
            }

          
            Console.WriteLine(" 種類別頭数 ");

            foreach (KeyValuePair<string, int> pair in counts)
            {
                Console.WriteLine(pair.Key + "：" + pair.Value + "匹");
            }
        }
    
    }
}
