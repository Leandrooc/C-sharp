using System;

namespace firstProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escreva um número inteiro");
            int inputUser = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome");
            string name = Console.ReadLine();
            getOddNumbers(inputUser, name);
        }
        static void getOddNumbers(int number, string name)
        {
            int odds = 0;
            for (int a = 1; a <= number; a++)
            {
                if ((a / 2) * 2 != a)
                {
                    Console.WriteLine(a);
                    odds++;
                }
            }
            Console.WriteLine(name + ", Existem " + odds + " números impares: ");
        }
    }
}