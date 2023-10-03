/*1. Write a program to find the Sum and the Average points scored by the teams in the IPL.
 * Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) 
 * that takes no.of matches as input and accepts that many scores from the user.
 * The function should then display the Average and Sum of the scores.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseTest_3
{
    class Cricket
    {
        public void Pointscalculation(int[] scores)
        {
            int no_of_matches = scores.Length;
            int sum = 0;

            for (int i = 0; i < no_of_matches; i++)
            {
                sum += scores[i];
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average of score: {average}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of matches: ");
            if (int.TryParse(Console.ReadLine(), out int no_of_matches) && no_of_matches > 0)
            {
                int[] scores = new int[no_of_matches];
                for (int i = 0; i < no_of_matches; i++)
                {
                    Console.Write($"Enter score for match {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int score))
                    {
                        scores[i] = score;
                    }
                    else
                    {
                        Console.WriteLine("Your input is Invalid. Please enter a vaid score as input: ");
                        i--; // loop counter to re-enter the vaid score.
                    }
                }
                Cricket cricket = new Cricket();
                cricket.Pointscalculation(scores);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid no. of match: ");
            }
            Console.ReadLine();
        }
    }
}
