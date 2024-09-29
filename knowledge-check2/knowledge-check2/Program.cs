using knowledge_check2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Records>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            Console.WriteLine($"Enter the description for record {i + 1}:");
            // In this loop, populate the object's properties using Console.ReadLine()
            Console.WriteLine("Records entered:");
            var Music = new Records();

            Console.WriteLine("Enter the value for ");
            Music.Description = Console.ReadLine();

            recordList.Add(Music);
          
        }
    }
}

// Print out the list of records using Console.WriteLine()
