using System.Runtime;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    {
                        Console.WriteLine("Math is hard");
                        break;
                    }
                case "science":
                    {
                        Console.WriteLine("Hello Einstein!");
                        break;
                    }
                case "gym":
                    {
                        Console.WriteLine("Everyone loves to run");
                        break;
                    }
                case "history":
                    {
                        Console.WriteLine("We are doomed to repeat it");
                        break;
                    }
                case "art":
                    {
                        Console.WriteLine("Are you the next Van Gogh?");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Never heard of it.");
                        break;
                    }
                   
            }
                
        }
    }
}