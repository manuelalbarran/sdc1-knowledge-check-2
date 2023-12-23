using Check;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many Pumps do you want to add? ");
        var numberOfPumps = int.Parse(Console.ReadLine());

        var pumpList = new List<PumpValue>();
        for (int i = 0; i < numberOfPumps; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var PumpValue = new PumpValue();
            Console.WriteLine("Enter name of the pump: ");
            PumpValue.Name = Console.ReadLine();
            Console.WriteLine("Enter the desciption of the pump: ");
            PumpValue.Description = Console.ReadLine();
            Console.WriteLine("Enter the price of the pump: ");
            PumpValue.Price = decimal.Parse(Console.ReadLine());

            pumpList.Add(PumpValue);
            Console.WriteLine("-------------------------");
        }

        // Print out the list of records using Console.WriteLine()

        foreach (var item in pumpList)
        {
            Console.WriteLine(item.Name + "\n" + item.Description + "\n" + item.Price);
            Console.WriteLine("---------------");
        }

        Console.ReadLine();
    }
}