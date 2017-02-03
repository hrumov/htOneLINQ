using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using htOneLINQ;

namespace htOneLINQ
{
    [TestFixture]
    class TestClass
    {
        [TestCase]
        public void test()
        {
            Fibonacci fib = new Fibonacci();
            fib.show();

            int counter = 0;
            int counterSum = 0;

            foreach (BigInteger element in fib.fibRow)
            {
                if (element.IsSimple())
                {
                    counter++;
                }

                if (element.IsDivideOnSum())
                {
                    counterSum++;
                }
            }
            Console.WriteLine("number of simple numbers = {0}", counter);
            Console.WriteLine("number of divided on sum = {0}", counterSum);
            Console.WriteLine("------");

            var a = fib.fibRow.Where(s => s.IsSimple()).Count();
            Console.WriteLine("number of simple numbers = {0}", a);

            var b = fib.fibRow.Where(s => s.IsDivideOnSum()).Count();
            Console.WriteLine("number of divided on sum = {0}", b);

            var c = fib.fibRow.Where(s => s % 5 == 0).Count();
            Console.WriteLine("number of divided on 5 = {0}", c);

            var sqrList = fib.fibRow.Where(s => s.ToString().Contains("2")).Select(s => s * s).ToList();
            Console.WriteLine("square of numbers, which contains 2");
            //sqrList.ForEach(Console.WriteLine);

            var sortedBySecondNumberList = fib.fibRow.Where(s => s > 9).OrderBy(s => s.ToString()[1]).Reverse().ToList();
            Console.WriteLine("---" + sortedBySecondNumberList);

            Fibonacci.lastTwoNumbersIsDivideOnThreeList(fib.fibRow);

            Fibonacci.CountNumberWithMaxSum(fib.fibRow);

            Fibonacci.AverageZero(fib.fibRow);
        }
    }
}