using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_2
{


    internal class employee : IPayable
    {
        
        public string Name { get; set; }
        public int Age { get; set; }

        public  float amount;

        public float salar;

        

        
        employee(string name,int age)
        {
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return $"Name : {Name} Age : {Age}";
        }

      public void  fa()
        {


            salar += amount;

          
        }
        



        public void ipaya()
        {

            Console.WriteLine($"salary {salar}");

        }
        
   


        static void Main(string[] args)
        {
            /*
            employee[] arr = new employee[2] {

               
                new Trainee(),
                new empandtrain() ,


            };
            */

            employee emp = new employee();
           Company company = new Company();
            emp.amount += company.p();

            emp.amount = 2;

            Console.WriteLine($"the salary {emp.amount}");
            Company a = new Company();
            a.Add(" ");



        }
    }
}
