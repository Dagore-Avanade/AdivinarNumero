using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 101);
            int tries = 0;
            int maxNumberOfTries = 4;
            bool win = false;

            Console.WriteLine("ADIVINA EL NÚMERO");
            Console.WriteLine();
            do
            {
                int remaingsTries = maxNumberOfTries - tries;
                Console.WriteLine();
                Console.Write($"Te queda{(remaingsTries == 1 ? "" : "n")} {remaingsTries} intento{(remaingsTries == 1 ? "" : "s")}. Dime un número entre 1 y 100: ");
                if (int.TryParse(Console.ReadLine(), out int guessNumber))
                {
                    if (secretNumber == guessNumber)
                        win = true;
                    else if (secretNumber > guessNumber)
                        Console.WriteLine($"El número es mayor que {guessNumber}.");
                    else
                        Console.WriteLine($"El número es menor que {guessNumber}.");

                }
                else
                {
                    Console.WriteLine("Eso no era un número, pero te cuenta como intento igual.");
                }
                
                tries++;
            } while (!win && tries < maxNumberOfTries);

            Console.WriteLine();
            Console.WriteLine($"El número era {secretNumber}.");
            if (win)
            {
                Console.WriteLine($"¡Enhorabuena! Lo conseguiste en {tries} intentos.");
            }
            else
            {
                Console.WriteLine("Otra vez será.");
            }
            Console.ReadLine();
        }
    }
}
