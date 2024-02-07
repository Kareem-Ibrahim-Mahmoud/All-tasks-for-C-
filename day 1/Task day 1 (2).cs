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

            String x = Console.ReadLine();
            String y="";
            int r;
            int r1=1;

            r = int.Parse(x);
            r1 = int.Parse(y);

            for(int i=1;i<=r;i++)
            {
                r1 = r1 * i;
                Console.WriteLine($"Factroial = {r1}");

            }


            



        }
    }
}