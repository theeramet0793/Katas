using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzNamespace
{
    public class FizzBuzz
    {
        // input integer version
        public string FizzOrBuzz(int? num)
        {
            if (num == null) 
                return "null";
            else if(num > 0 && num < 101)
            {
                if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
                else if (num % 5 == 0) return "Buzz";
                else if (num % 3 == 0) return "Fizz";
                else return num.ToString();
            }
            else
            {
                return "number not in range";
            }
        }
        /// for input string version
        public string FizzOrBuzz(string? numStr)
        {
            if (numStr == null)
                return "null";
            if (int.TryParse(numStr, out var num))
            {
                if (num > 0 && num < 101)
                {
                    if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
                    else if (num % 5 == 0) return "Buzz";
                    else if (num % 3 == 0) return "Fizz";
                    else return num.ToString();
                }
                else
                {
                    return "number not in range";
                }
            }
            else
            {
                return "you must only enter integer";
            }
        }
    }
}
