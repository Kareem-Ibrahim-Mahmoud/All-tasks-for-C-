using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public internal class Animal 
    {
        public readonly int age = 10;         /* { get; set; }*/
        public string Name;

    }
    public class Mammal : Animal
    {
        public  string Name => "Mammal";

    }
    public class Bird : Animal
    {
        public  string Name => "Bird";

    }
    public class Lion : Mammal
    {
        public string Name => "Lion";
    }
    public class Elephant : Mammal
    {
        public string Name => "Elephant";
    }
    public class Sparrow : Bird
    {
        public string Name => "Sparrow";
    }

    public class Pigeon : Bird
    {
        public string Name => "Pigeon";
    }

    public class Zoo
    {
        List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>();
        }

        public void  Add(Animal animal)
        {
            if (animal.age<= 10)
            {
                animals.Add(animal);
            }
            else
            {
                throw new Exception("Sorry, the age is not appropriate...!");

            }
        }
        public void Remove(Animal animal)
        {
            animals.Remove(animal);
        }











        internal class Program : Animal
        {
            static void Main(string[] args)
            {
                Zoo zoo = new Zoo();

                zoo.Add(new Lion());
                zoo.Add(new Sparrow());
                zoo.Add(new Elephant());
                zoo.Add(new Pigeon());

                foreach (Animal bird in zoo.animals)
                {
                    Console.WriteLine(bird);
                }


                /*Dictionary<Animal,string > = new Dictionary<Animal,int>();*/


            }
        }




    }



}
