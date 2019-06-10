using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        //Number 1 as method
        public static int Number1(IEnumerable<int> input) => input.Sum();
        //Number 2 as method
        public static int Number2(IEnumerable<int> input) => input.Aggregate((x, y) => (x + y));
        //Number 3 as method
        public static IEnumerable<int> Number3(IEnumerable<int> input) => input.ToList();
        //Number 4 as method
        public static IEnumerable<int> Number4(IEnumerable<int> input) => input.Select(x => x * 2);
        //Number 5 as method
        public static long Number5(IEnumerable<int> input, IEnumerable<int> input2) => input.Zip(input2, (x, y) => (long)x + y).Aggregate((x, y) => (x * y));



        static void Main(string[] args)
        {
            // Made the evaluations into methods above ^^

            var L1 = Enumerable.Range(0, 10);
            var L2 = Enumerable.Range(10, 10);

            // Number 1
            Console.WriteLine("Number 1");
            var number1 = L1.Sum();
            Console.WriteLine(number1);
            Console.WriteLine("_______________________________________");
            // Number 2
            Console.WriteLine("Number 2");
            var number2 = L1.Aggregate((x, y) => (x + y));

            Console.WriteLine(number2);
            Console.WriteLine("_______________________________________");
            // Number 3
            Console.WriteLine("Number 3");
            L2.ToList().ForEach(Console.WriteLine);
            Console.WriteLine("_______________________________________");
            // Number 4
            Console.WriteLine("Number 4");
            L2.Select(x => x * 2).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("_______________________________________");
            // Number 5
            Console.WriteLine("Number 5");
            var number5 = L1.Zip(L2, (x, y) => (long)x + y).Aggregate((x, y) => (x * y));

            Console.WriteLine(number5);
        }
    }
}
