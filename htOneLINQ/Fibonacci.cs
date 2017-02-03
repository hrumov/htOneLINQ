using htOneLINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace htOneLINQ
{
    public class Fibonacci
    {
        public List<BigInteger> fibRow;

        public Fibonacci()
        {
            List<BigInteger> fibRow = new List<BigInteger>();

            if (Int32.Parse(ResourceFile.numberOfFibRowElements) > 2)
            {
                fibRow.Add(1);
                fibRow.Add(1);
                for (int i = 2; i <= int.Parse(ResourceFile.numberOfFibRowElements); i++)
                {
                    fibRow.Add(fibRow[i - 1] + fibRow[i - 2]);
                }
            }
            this.fibRow = fibRow;
        }

        public void show()
        {
            foreach (BigInteger element in fibRow)
            {
                Console.WriteLine(element);
            }
        }

        public static List<string> lastTwoNumbersIsDivideOnThreeList(List<BigInteger> obj)
        {
            List<BigInteger> first = obj.Where(i => i.IsDivideOnThree() == true).ToList();
            List<string> forBig = first.Where(i => i.ToString().Length > 2).Select(i => i.ToString().Substring(i.ToString().Length - 2)).ToList();
            List<string> forSmall = first.Where(i => i.ToString().Length < 3).Select(i => i.ToString()).ToList();
            List<string> result = forBig;
            result.AddRange(forSmall);
            result.ForEach(Console.WriteLine);
            return result;
        }

        public static string CountNumberWithMaxSum(List<BigInteger> obj)
        {
            BigInteger result;

            List<KeyValuePair<BigInteger, double>> b = new List<KeyValuePair<BigInteger, double>>();
            obj.ForEach(i => b.Add(i.FindElementsAndSumPows()));
            result = b.OrderBy(i => i.Value).ToList().Last().Key;
            Console.WriteLine(result);
            return result.ToString();
        }

        public static string AverageZero(List<BigInteger> obj)
        {
            double result;
            result = (double)obj.Select(i => { return i.CountZeros(); }).Sum() / 200;
            Console.WriteLine(result);
            return result.ToString();
        }
    }
}
