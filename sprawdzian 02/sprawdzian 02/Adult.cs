using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_02
{
    public class Adult : Human
    {
        public List<Child> Children { get; set; } = new List<Child>();
            

        public override string EatSnack()
        {
            return "Cake";
        }
    }
}
