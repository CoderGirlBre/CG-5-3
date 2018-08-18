using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //The two lines serve as the title.
            Console.Write("Dice Game: ");
            Console.Write("Who will get to 20 first? (You VS Computer)");
           
            //Calling the method created below.
            DiceRolling(); 
        }
        //New method.
        private static void DiceRolling()
        {
            //Two new integer variables created for later use.
            int total = 0;
            int sum = 0;

            //New bool (true/false) variable created and initial value set to true.
            bool incorrect = true;

            do //Everthing below will continue to execute until the false condition is met.
            {
                Console.WriteLine(); //Creates line of space after the title.
                Console.WriteLine("Press enter to roll the dice!"); //Tells user what to do.
                Console.ReadLine(); //Makes the line above stay until the user does what they're told.

                //New random created. This is the dice for the user.
                Random dice = new Random();
                int rolled = dice.Next(2, 12);

                sum += rolled; //The sum is set to equal the total of the values the user got on the dice.

                //This keep track of what the dice rolled and the total of the rolls for the user.
                Console.WriteLine("You");
                Console.WriteLine("Dice: " + rolled);
                Console.WriteLine("Total: " + sum);

                Console.WriteLine(""); //Creates a line of space after the user's turn.
                
                //Another random created as the dice for the computer.
                Random pcDice = new Random();
                int pcRolled = dice.Next(2, 12);
                total += pcRolled;

                //This keeps track of what the dice rolled and the total of the rolls for the computer.
                Console.WriteLine("Computer");
                Console.WriteLine("Dice: " + pcRolled);
                Console.WriteLine("Total: " + total);

                //When the totals add up to 20 for the user or computer, that person (or machine) wins.
                //It will print who won to the console and then the false condition is finally met.
                //Game over.
                if (sum >= 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("YOU WIN!");
                    Console.ReadLine();
                    incorrect = false;
                } 
                else if (total >= 20)
                {
                    Console.WriteLine();
                    Console.WriteLine("COMPUTER WINS!");
                    Console.ReadLine();
                    incorrect = false;
                }

            } while (incorrect); 
        }

    }
}
