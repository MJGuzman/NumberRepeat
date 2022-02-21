using System;

namespace NumberRepeat
{
    internal class Program
    {
        private static char NumberRequired = '1';
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el  primer número");

            var number1 = Console.ReadLine();
            Console.WriteLine("Introduzca el  segundo número");

            var number2 = Console.ReadLine();
            NumberRepect(int.Parse(number1), int.Parse(number2));
        }


        private static void NumberRepect(int number1, int number2)
        {
            var total = 0;

            if (number2 < 0)
            {
                for (int i = number1; i >= number2; i--)
                {
                    total += Repetitions(i);
                }
            }
            else
            {
                for (int i = number1; i <= number2; i++)
                {
                    total += Repetitions(i);
                }
            }


            Console.WriteLine($"Total de repeticiones del {NumberRequired} es: {total}");

        }

        private static int Repetitions(int number)
        {
            var total = 0;
            var stringNumber = number.ToString();
            char[] ch = new char[stringNumber.Length];

            for (int x = 0; x < stringNumber.Length; x++)
            {
                ch[x] = stringNumber[x];
            }


            foreach (char c in ch)
            {

                if (c == NumberRequired)
                {
                    total += 1;
                    Console.WriteLine($"{stringNumber} contiene el número 1");
                }
            }

            return total;
        }
    }
}
