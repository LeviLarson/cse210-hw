using System;

class Program
{
    static void Main(string[] args)
    {
        string cont = "yes";
        while(cont == "yes"){
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            int guess = 0;
            while(guess != magicNumber){
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                if(guess == magicNumber){
                    Console.WriteLine("Congrats, that was correct!");
                }
                else{
                    Console.WriteLine("Try Again");
                }
            
            
            }
            Console.WriteLine("Would you like to keep playing? (yes or no)");
            cont = Console.ReadLine();
        }
    }
}