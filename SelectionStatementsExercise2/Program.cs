using System.Collections;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string subject;
            Console.WriteLine("What is your favorite school subject?");
            subject = Console.ReadLine();
            string subjectToLower = subject.ToLower();

            switch (subjectToLower) 
            {
                case "math":
                    Console.WriteLine($"I'm not a big fan of {subjectToLower}.");
                    break;
                case "spelling":
                    Console.WriteLine($"I guess {subjectToLower} is okay.");
                    break;
                case "history":
                    Console.WriteLine($"I think {subjectToLower} should stay in the past.");
                    break;
                case "reading":
                    Console.WriteLine($"I think {subjectToLower} is VERY important.");
                    break;
                case "biology":
                    Console.WriteLine($"I think {subjectToLower} is AWESOME!!!.");
                    break;
                default:
                    Console.WriteLine("I have no idea what that subject is. Do you?");
                    break;
            }
        }
    }
}