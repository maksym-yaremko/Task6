using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    public class Rational
    {
        private int a;
        private int b;

        public Rational(int _a, int _b)
        {

            this.a = _a;
            this.b = _b;
            CutDown();

        }

        public string Output()
        {
            return a + "/" + b;
        }

        public static Rational operator +(Rational _firstNumber, Rational _secondNumber)
        {
            if (_firstNumber.b == _secondNumber.b)
            {
                return new Rational(_firstNumber.a + _secondNumber.a, _firstNumber.b);
            }
            else
            {
                return new Rational(_firstNumber.a * _secondNumber.b + _secondNumber.a * _firstNumber.b,
                    _firstNumber.b * _secondNumber.b);
            }
        }

        public static Rational operator -(Rational _firstNumber, Rational _secondNumber)
        {
            if (_firstNumber.b == _secondNumber.b)
            {
                return new Rational(_firstNumber.a - _secondNumber.a, _firstNumber.b);
            }
            else
            {
                return new Rational(_firstNumber.a * _secondNumber.b - _secondNumber.a * _firstNumber.b,
                    _firstNumber.b * _secondNumber.b);
            }
        }

        public static Rational operator *(Rational _firstNumber, Rational _secondNumber)
        {
            return new Rational(_firstNumber.a * _secondNumber.a, _firstNumber.b * _secondNumber.b);
        }

        public static Rational operator /(Rational _firstNumber, Rational _secondNumber)
        {
            return new Rational(_firstNumber.a * _secondNumber.b, _firstNumber.b * _secondNumber.a);
        }

        public void CutDown()
        {
            int NSD = a;
            while (NSD >= 2)
            {
                if (a % NSD == 0 && b % NSD == 0)
                {
                    this.a /= NSD;
                    this.b /= NSD;
                    NSD = a;
                }
                NSD--;
            }
        }
    }


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
