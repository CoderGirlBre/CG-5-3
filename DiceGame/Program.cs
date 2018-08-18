using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dice Game: ".ToUpper());
            Console.Write("Who will get to 20 first? (You VS Computer)");
            Console.ReadLine();

            
        }

        private static void DiceRolling()
        {
            
            int sum = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Press enter to roll the dice!");
                Console.ReadLine();

                Random dice = new Random();
                int rolled = dice.Next(2, 13);
                sum += rolled;

                Console.WriteLine("Dice: " + rolled);
                Console.WriteLine("Total: " + sum);

                if (sum == 20)
                {
                    Console.WriteLine("WINNER!");
                    Console.ReadLine();
                    incorrect = false;
                }
                else if (sum > 20)
                {
                    Console.WriteLine("WINNER!");
                    Console.ReadLine();
                    incorrect = false;
                }
                else
                incorrect = true;
               
        
            } while (incorrect);
        }
       

        
       
    }
}
