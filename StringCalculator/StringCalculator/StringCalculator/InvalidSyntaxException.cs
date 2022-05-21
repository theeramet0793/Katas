using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorNamespace
{
    public class InvalidSyntaxException : Exception
    {
        public InvalidSyntaxException(string message) : base(message)
        {
        }
    }
}
