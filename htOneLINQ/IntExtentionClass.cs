using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace htOneLINQ
{
    public static class IntExtentionClass
    {
        public static bool IsSimple(this BigInteger number)
        {
            for (int i = 2; i < (number / 2 + 1); i++)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsDivideOnSum(this BigInteger number)
        {
            char[] ch = number.ToString().ToArray();
            int sum = 0;
            foreach (char c in ch)
            {
                sum = sum + Int32.Parse(c.ToString());
            }
            if (number % sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDivideOnThree(this BigInteger n)
        {
            if (n % 3 != 0)
            {
                return false;
            }
            return true;
        }

        public static KeyValuePair<BigInteger, double> FindElementsAndSumPows(this BigInteger n)
        {
            KeyValuePair<BigInteger, double> resultInt = new KeyValuePair<BigInteger, double>();
            Dictionary<BigInteger, double> resultDict = new Dictionary<BigInteger, double>();
            double tempSum = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                tempSum += Math.Pow(((double)n.ToString()[i]), 2);
            }
            resultDict.Add(n, tempSum);
            resultInt = resultDict.First();
            return resultInt;
        }

        public static int CountZeros(this BigInteger n)
        {
            int counterZero = 0;
            for (int i = 0; i < n.ToString().Length; i++)
            {
                if (n.ToString()[i] == '0')
                {
                    counterZero++;
                }
            }
            return counterZero;
        }
    }
}
