using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsCalculatorAPI.Exceptions
{
    public class MarsCalcException : Exception
    {
        public MarsCalcException(string message):base(message)
        {

        }
    }
}
