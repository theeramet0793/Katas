using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeComposite
{
    public class PrimeNumber
    {
        public List<int>? FindPrimeNumberInRange(int first, int last)
        {
            var primeList = new List<int>();
            for (int i = first; i <= last; i++)
            {
                if (IsPrimeNumber(i)) primeList.Add(i);
            }
            return primeList;
        }

        public  bool IsPrimeNumber(int num)
        {
            if(num == 2 || num == 3 ) return true;  
            var sqrt = Math.Sqrt(num);
            var intSqrt = (int) Math.Floor(sqrt);
            var primeList = FindPrimeNumberFrom1To(intSqrt);
            if( primeList != null)
            {
                foreach(var prime in primeList)
                {
                    if( num%prime == 0 ) return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int>? FindPrimeNumberFrom1To(int max)
        {
            if( max <= 1) return null;
            else
            {
                var numlist = Enumerable.Range(1, max).ToList();
                numlist.RemoveAt(0);
                int index = 0;

                while (numlist.ElementAt(index) <= Math.Floor(Math.Sqrt(max)))
                {
                    var divisor = numlist.ElementAt(index);
                    numlist.RemoveAll(x => x % divisor == 0 && x != divisor);
                    index += 1;
                }
                return numlist;
            }

            
        }
    }
}
