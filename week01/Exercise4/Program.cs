using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        double avg = 0;
        int lgstNum = 0;

        List<int> numbers;
        numbers = new List<int>();

        int answer = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(answer != 0){
            Console.WriteLine("Enter a Number: ");
            answer = int.Parse(Console.ReadLine());
            numbers.Add(answer);
        }

        sum = numbers.Sum();

        avg = numbers.Average();

        lgstNum = numbers.Max();

        Console.WriteLine("The sum of all the numbers in the list is: " + sum);

        Console.WriteLine("Teh average of all the numbers in the list is: " + avg);

        Console.WriteLine("The largest number in the list is: " + lgstNum);
    }
}