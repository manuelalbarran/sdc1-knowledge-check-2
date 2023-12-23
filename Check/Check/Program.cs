using Check;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Pump>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Pump = new Pump();
            Console.WriteLine("Enter name of the pump");
            Pump.Name = Console.ReadLine();
            Console.WriteLine("Enter the desciption of the pump");
            Pump.Description = Console.ReadLine();



            Console.WriteLine("Enter the value for Spump");
            Pump.Spump = decimal.Parse(Console.ReadLine());

            recordList.Add(Pump);
            Console.WriteLine("-------------------------");
        }

        // Print out the list of records using Console.WriteLine()
        IEnumerable<Pump> temp = recordList;
        temp = from v in temp
               orderby v.Name ascending
               select v;

        foreach (Pump item in temp)
        {
            Console.WriteLine(item.Name + "\n" + item.Description + "\n" + item.Spump);
            Console.WriteLine("---------------");
        }

        Console.ReadLine();
    }
}