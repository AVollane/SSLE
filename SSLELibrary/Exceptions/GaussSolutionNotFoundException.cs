using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLELibrary.Exceptions
{
    public class GaussSolutionNotFoundException : Exception
    {
        public GaussSolutionNotFoundException(string msg)
            : base("Решение не может быть найдено: \r\n" + msg)
        {
        }
    }
}
