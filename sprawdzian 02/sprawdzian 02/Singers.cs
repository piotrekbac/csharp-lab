using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian_02
{
    public class Singers<T> : List<T> where T : ISinger
    {

    }
}
