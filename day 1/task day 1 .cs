using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_one_c_sharp
{


    internal class emp
    {
       
      
        static void Main(string[] args)
        {
            int r;
            int r1;
            string c;
            
            String num= Console.ReadLine();
            
            r = int.Parse(num);


            String num1 = Console.ReadLine();
            r1 = int.Parse(num1);
            c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    Console.WriteLine($"{r} + {r1} ={r+r1} ");
                        break;
                case  "-":
                    Console.WriteLine($"{r} - {r1} ={r - r1}");                       
                    break;
                case "*":
                    Console.WriteLine($"{r} * {r1} ={r * r1}");
                    break;

                case "/":
                    Console.WriteLine($"{r} / {num1} ={r / r1} ");
                    break;


                default:
                    Console.Error.WriteLine("Repeat the process again ...");
                    break;

            }

            Console.ReadKey();




        }
    }
}