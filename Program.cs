using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add to the soda library? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

      

        var recordList = new BeverageRepo();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new Soda();

            Console.WriteLine("Enter the value for grams of sugar");
            myClass.GramsOfSugar = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the beverage");
            myClass.Name = Console.ReadLine();


            recordList.Add(myClass);
            recordList.Save();
            

        }
    }
}

// Print out the list of records using Console.WriteLine()

public class Beverage
{
    public string Name { get; set; }

    public override string ToString() => $"Name : {Name}";
}

public class Soda : Beverage
{
    public int GramsOfSugar { get; set; }
    public override string ToString() => $"Name : {Name}, Grams of sugar : {GramsOfSugar}";
}

public class BeverageRepo
{
    private readonly List<Soda> _sodas = new List<Soda>();
    public void Add(Soda soda)
    {
        _sodas.Add(soda);
    }

    public void Save()
    {
        foreach (var soda in _sodas)
        {
            Console.WriteLine(soda);
        }
    }
}