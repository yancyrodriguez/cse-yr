using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        int action = 0;
        Console.WriteLine("Welcome to the Journal!");
        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();

        while (action != 5)
        {
            action = Choices();

            switch (action)
            {
                string entryId = GetEntryId();
                string dateInfo = GetDateTime();
                string prompt = jp.GetPrompt();

                Console.Write($"{prompt}");
                Console.Write($" ");
                string userEntry = Console.ReadLine();
                entry._journalEntry = userEntry;

                journal._journal.Add(entry);

                journal.Display();

                journal.LoadJournalFile();
            }

        }
    }
}