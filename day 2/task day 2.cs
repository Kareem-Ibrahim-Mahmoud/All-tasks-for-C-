using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_2
{
    
    internal class empl  <T> where T : class

    {
        public string Name { get; set; }
        public string Name1 { get; set; }
        public string salary { get; set; }
        public string role { get; set; }
        public int a;
         
       
        public bool asa {

            get {

                if(Name =="Ahmed")
                {
                    Console.WriteLine("hello Admin ...");
                    return true;
                    


                }
                else if(Name ==null)
                {
                    return false;

                }
                else
                {
                    Console.WriteLine("hello User ...");
                    return true;

                }
            
            
            }


            set
            {

            }
        
        }
        
        public void display()
        {
            
            
            Console.WriteLine("Enter your Name ...");
            Name1 = Console.ReadLine();
            if (Name1 =="Ahmed")
            {
                Console.WriteLine("Hello Admin ...");

                Console.WriteLine("creat  new user ... \t");
                Console.WriteLine("creat  new name : ");
                Name1 = Console.ReadLine();
                Console.WriteLine("creat  new salary : ");
                salary = Console.ReadLine();
                a = int.Parse(salary);

                Console.WriteLine("creat  new role for user : ");
                role = Console.ReadLine(); ;







            }

            else if (Name1 ==null)
            {
                throw new Exception("NO Access system");
            }
            else{

                Console.WriteLine("Hello  User");
                Console.WriteLine($"Name : ahmed kamal");
                Console.WriteLine($"Salary : 500");
                Console.WriteLine($"The Role : devolper");

            }

            


        }
       


       
        static void Main(string[] args)
        {
            empl em=new empl();
            em.display();




        }
    }
}
