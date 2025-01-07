using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_02
{
    public class Child : Human, ISinger
    {
        public string Sing()
        {
            return "Baby shark doo doo doo doo";
        }


        public void Singinging()
        {
            Console.WriteLine($"{Name} is singing!");
        }

    }

}
