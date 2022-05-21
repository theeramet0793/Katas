using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeComposite
{
    public class PrimeCompositeEvenChecker: PrimeNumber
    {
        public string Check(int num)
        {
            if (IsPrimeNumber(num)) return "prime";
            else if (num % 2 == 1) return "composite";
            else return num.ToString();
        }
    }
}
