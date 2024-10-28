using System;
using System.Linq;

class Program {
    public static void Main(string[] args) {

            // Problem: Create a number guessing game where the user has to guess a randomly generated number between 1 and 100. Give feedback if the guess is too high or too low.
            // Concepts Used: Random numbers, loops, conditionals.
        bool looping = true;
        while(looping) {
        Random random = new Random();

        int randomNum = random.Next(1, 101); //1-100, inclusive 101


            int attempt=0;
        while(true) {
        Console.Write("Guess the number from 1 to 100: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input < randomNum) {
            Console.WriteLine("More.");
            attempt++;
            continue;
        }
        else if (input > randomNum) {
            Console.WriteLine("Less.");
            attempt++;
            continue;
        }
        else if (input == randomNum) {
            Console.WriteLine("Yey! Congrats, you have guessed the number!");
            attempt++;
            Console.WriteLine("You have tried " + attempt + " times to guess the right number");
            break;
            }
        }
        Console.Write("Would you like to go for more? (Y/N): ");
        string response = Convert.ToString(Console.ReadLine()).ToUpper();
        if (response == "Y") {
            continue;
        }
        else {
            looping = false;
            }
        }
    }
}