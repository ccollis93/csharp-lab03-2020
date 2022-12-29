using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {

        static void Main(string[] args)
        {

            Random rnd = new Random();

            Console.WriteLine("Enter '1' for rock, '2' for paper, or '3' for scissors");
            int uChoice = int.Parse(Console.ReadLine());

            int cChoice = rnd.Next(1, 3);

            if (uChoice == 1 && cChoice == 1)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");
            }

            else if (uChoice == 2 && cChoice == 2)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");
            }

            else if (uChoice == 3 && cChoice == 3)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("TIE!");
            }

            else if (uChoice == 1 && cChoice == 3)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 1 && cChoice == 2)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE");
            }

            else if (uChoice == 2 && cChoice == 1)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 2 && cChoice == 3)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE!");
            }


            else if (uChoice == 3 && cChoice == 2)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU WIN!");
            }

            else if (uChoice == 3 && cChoice == 1)
            {
                Console.Write("You Played " + uChoice + " "); Console.WriteLine("The Computer Played " + cChoice);
                Console.WriteLine("YOU LOSE!");
            }

            else
                Console.WriteLine("ERROR, Invalid Input!");

            Console.ReadLine();
        }
        

    }
}
