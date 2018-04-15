using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
    class Program
    {
        static void Main(string[] args)
        {
            List<Rational> array = new List<Rational>();
            string aInput;
            string bInput;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} Number", i + 1);
                aInput = Console.ReadLine();
                bInput = Console.ReadLine();
                array.Add(new Rational(Convert.ToInt32(aInput), Convert.ToInt32(bInput)));
            }

            Rational result = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                result += array[i];
            }
            Console.WriteLine(result.Output());

            result = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                result -= array[i];
            }
            Console.WriteLine(result.Output());

            result = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result.Output());

            result = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                result /= array[i];
            }
            Console.WriteLine(result.Output());

            Console.ReadKey();
        }
    }
}
