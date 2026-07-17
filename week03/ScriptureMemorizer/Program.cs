using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart, and lean not unto thine own understanding.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press enter to continue, or type 'quit' to end: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}