using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_2
{
    internal class Company : employee
    {
       public string namecompany;
       public float Budget;
       public string nameemp;
        public List<employee> Employees { get; set; }
        public event Action <object,string> msg;

        public void Add(string info)
        {


        }

        public void p(float am)
        {
            Console.WriteLine($"el zeada = {am}");

        }
        /*
        public float descom()
        {
            float a = Budget - amount;

            Console.WriteLine($"the mony descound from elsherka {a}");

            return a;

        }
        */
        public void IncreaseSalary()
        {
           
            Budget -= amount;
        }



       




    }
}
