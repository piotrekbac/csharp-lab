using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_02
{
    public abstract class Human
    {
        

        public string Name { get; set; }
        public Human Mother { get; set; }
        public Human Father { get; set; }
        

        public virtual string EatSnack()
        {
            return "Ice cream!";
        }



    }
}
