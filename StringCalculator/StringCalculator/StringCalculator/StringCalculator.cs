
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorNamespace
{
    public class StringCalculator
    {
        public int Add(string str)
        {
            if (str == string.Empty) return 0;
            else if ( !IsSyntaxTrue(str))
            {
                Console.WriteLine($"Your string is not corrected syntax");
                return -2;
            }

            var numList = PickNumberOut(str);
            if (numList.Min() >= 0) return numList.Where(x => x > 0 && x < 1000).Sum();
            else 
            {
                List<int> negList = numList.Where(x => x < 0).ToList();
                Console.Write($" Negatives not allowed: ");
                negList.ForEach(x => Console.Write($"{x} "));
                return -1;
            }           
        }

        public List<int> PickNumberOut(string str)
        {
            List<int> numlist = new List<int>();
            string strNumTemp = string.Empty;

            for (int i=0; i < str.Length; i++)
            {
                if (str[i] != '-')
                {
                    if (Char.IsDigit(str[i])) 
                        strNumTemp += (str[i]);
                    if ( !Char.IsDigit(str[i]) || i == str.Length-1 )
                    {
                        if (int.TryParse(strNumTemp, out int num))
                            numlist.Add(num);
                        strNumTemp = string.Empty;
                    }    
                }
                else strNumTemp = "-";

            }
            return numlist;
        }
        
        public bool IsSyntaxTrue(string str) 
        {
            if( str[0] == '/' && str[1] == '/' )
            {
                if( str[2] == '[' && str.Where(x => x == '[').Count() > 1)
                    return IsDefinedDelimiterCorrectFormat(str, '\n');
                else if (str[2] == '[')
                    return IsDefinedDelimiterCorrectFormat(str, ']');
                else if( str[3] == '\n' )
                {
                    char[] delimiter = {',','\n', str[2] };
                    string newStr = str.Substring(4);
                    string[] number = newStr.Split(delimiter);
                    return IsAllInteger(number);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(!Char.IsDigit(str[0]) && str[0]!= '-') return false;
                else
                {
                    char[] delimiter = { ',', '\n' };
                    string[] number = str.Split(delimiter);
                    return IsAllInteger(number);
                }
            }
            
        }

        public bool IsAllInteger(string[] str)
        {
            foreach (string num in str)
            {
                if (num.Contains("\n")) return false;
                if (!int.TryParse(num, out _)) return false;
            }
            return true;
        }

        public bool IsDefinedDelimiterCorrectFormat(string str,char ch)
        {
            if (str.IndexOf(ch) == -1) return false;
            string subStr = str.Substring(2, str.IndexOf(ch) - 2);
            string[] delimiter = subStr.Split('[', ']');
            string newStr = str.Substring(str.IndexOf(ch) + 1);
            string[] number = newStr.Split(delimiter, StringSplitOptions.None);
            return IsAllInteger(number);
        }

        // version 2
        public double Calculate(string str)
        {
            if( !IsPatternTrue(str)) throw new InvalidSyntaxException("Invalid Syntax");
            else
            {
                var number = SplitNumber(str);
                var symbols = SplitSymbols(str);   
                var expression = ConcatString(number, symbols);
                var afterMultAndDiv = MultAndDivCompute(expression);
                var afterAddAndSub = AddAndSubCompute(afterMultAndDiv);
                if ( afterAddAndSub.Count == 1)
                {
                    //Console.WriteLine(afterMultAndDiv.Count);
                    return double.Parse(afterAddAndSub[0]);
                }
            }
            return 10;
        }
        public List<double> SplitNumber(string str)
        {
            List<double> result = new List<double>();
            var split = str.Split(new char[] { '+','-','*','/' }, StringSplitOptions.None);
            foreach(var number in split)
            {
                if( double.TryParse(number, out double num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        public List<string> SplitSymbols(string str)
        {
            List<string> list = new List<string>();
            char[] mathSymbols = { '+', '-', '*', '/' };
            foreach (char symbol in str)
            {
                if (mathSymbols.Contains(symbol))
                {
                    list.Add(symbol.ToString());
                }
            }
            return list;
        }

        public bool IsPatternTrue(string str)
        {
            char[] mathSymbols = { '+', '-', '*', '/' };

            if( !Char.IsDigit(str[0]) ) return false;
            for(int i = 1; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]))
                {
                    if (!mathSymbols.Contains(str[i])) return false;
                    else if (!Char.IsDigit(str[i - 1])) return false;
                    else if (i == str.Length-1 )return false;
                }
            }
            return true;
        }

        public List<string> MultAndDivCompute(List<string> expression)
        {
            for(int i=0; i<expression.Count-1; i++)
            {
                if(expression[i] == "*" || expression[i] == "/")
                {
                    var a = double.Parse(expression[i - 1]);
                    var b = double.Parse(expression[i + 1]);
                    var symbol  = expression[i];
                    var res = BasicCompute(a, b, symbol);
                    expression.RemoveAt(i);
                    expression.Insert(i, res.ToString());
                    expression.RemoveAt(i + 1);
                    expression.RemoveAt(i - 1);
                    MultAndDivCompute(expression);
                }
                else
                {
                    if (i == expression.Count - 1) return expression;
                }
            }
            return expression;
        }

        public List<string> AddAndSubCompute(List<string> expression)
        {
            for(int i=0; i<expression.Count; i++)
            {
                if (expression[i] == "+" || expression[i] == "-")
                {
                    var a = double.Parse(expression[i - 1]);
                    var b = double.Parse(expression[i + 1]);
                    var symbol = expression[i];
                    var res = BasicCompute(a, b, symbol);
                    expression.RemoveAt(i);
                    expression.Insert(i, res.ToString());
                    expression.RemoveAt(i + 1);
                    expression.RemoveAt(i - 1);
                    AddAndSubCompute(expression);
                }
                else
                {
                    if (i == expression.Count - 1) return expression;
                }
            }
            return expression;
        }

        public double BasicCompute(double a, double b, string symbol)
        {
            switch (symbol)
            {
                case "+": return a+b;
                case "-": return a-b;
                case "*": return a*b;
                case "/": return a/b;
                 default: throw new Exception("Cannot compute invalid math symbols");
            }
        }
        public List<string> ConcatString(List<double> number, List<string> symbols)
        {
            List<string> result = new List<string>();
            result.Add(number[0].ToString());
            for(int i=0; i< symbols.Count; i++)
            {
                result.Add(symbols[i].ToString());
                result.Add(number[i+1].ToString());
            }
            return result;
        }

        
    }
}
