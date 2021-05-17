using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSLELibrary.Exceptions
{
    public class IterationsSolutionNotFoundException : Exception
    {
        public IterationsSolutionNotFoundException(string msg)
            : base("Решение не может быть найдено: \r\n" + msg)
        {
        }
    }
}
