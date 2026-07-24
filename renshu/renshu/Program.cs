using renshu;
internal class Program() {
    static void Main()
    {
        Cat cat = new Cat("猫", 1);
        Dag dag = new Dag("犬", 2);
        Bird bird=new Bird("鳥", 3);
        //cat.ShowProfile();
        //cat.Sleep();
        //cat.Speak();
        //dag.ShowProfile();
        //dag.Run();
        //dag.Speak();
        //Console.WriteLine(cat);
        //Console.WriteLine(dag);
        List<Animal> animal = new List<Animal>();
        //animal.Add(new Cat("猫", 1));
        //animal.Add(new Dag("犬", 2));
        //animal.Add(new Bird("鳥", 3));

        animal.Add(cat);
        animal.Add(dag);
        animal.Add(bird);

        Animal animaldag = new Dag("犬2", 3);
        animaldag.Walk();
        animaldag.Walk(3);

        foreach (Animal animals in animal)
        {
            animals.Speak();
            animals.DoDaily();
            Console.WriteLine(animals);

            if(animals is Bird b)
            {
                b.Fly();
            }
        }
        Cat cat1 = new Cat("1", 1);
        cat1.ShowKind();

        Animal a2 = cat1;
        a2.ShowKind();

        Animal a = new Dag("2", 2);
        ((Dag)a).Run();

        (a as Dag).Run();

        if (a is Dag d) d.Run();

        List<IPlayable> playables = new List<IPlayable>
        {
            cat,
            dag,    
            bird
        };
       
        foreach (IPlayable p in playables)
        {
            p.Speak();
            p.Play();
        }

        int dags = 0;
        int cats = 0;
        int birds = 0;


        List<Animal> Animals = new List<Animal>();
        while (true) {
            string input = Console.ReadLine();
            string[] data = input.Split(' ');

            if (input == "end")
            {
                break;
            }

            string kind = data[0];
            string name = data[1];
            int age = int.Parse(data[2]);

            Animal animales = null;
            
            

            switch (kind)
            {
                case "dag":
                    animales = new Dag(name, age);
                    dags++;
                    break;

                case "cat":
                    animales = new Cat(name, age);
                    cats++;
                    break;

                case "bird":
                    animales = new Bird(name, age);
                    birds++;
                    break;
                
            }

            Animals.Add(animales);
            Console.WriteLine(animales);


            
        }
        Console.WriteLine("----------------");
        foreach (Animal a1 in Animals)
        {

            a1.ShowProfile();
            a1.Speak();
            if (a1 is IPlayable b)
            {
                b.Play();

            }
            Console.WriteLine("----------------");
        }
        Console.WriteLine("dag:" + dags);
        Console.WriteLine("cat:" + cats);
        Console.WriteLine("dag:" + birds);
        Console.WriteLine("----------------");

    }
}