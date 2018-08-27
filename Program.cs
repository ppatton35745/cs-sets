using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        HashSet<string> showroom = new HashSet<string>() {
            "Viper",
            "Corvette",
            "Dodge",
            "Camry"
        };

        Console.WriteLine($"there are {showroom.Count} cars in the showroom");

        DisplaySet(showroom);

        showroom.Add("Viper");

        DisplaySet(showroom);

        HashSet<string> usedLot = new HashSet<string>() {
            "Van",
            "Truck",
        };

        showroom.UnionWith(usedLot);

        DisplaySet(showroom);

        showroom.Remove("Camry");

        DisplaySet(showroom);

        HashSet<string> junkyard = new HashSet<string>() {
            "Van",
            "Truck",
            "Tonka",
            "BigTonka"
        };

        HashSet<string> clone = new HashSet<string>(showroom);

        clone.IntersectWith(junkyard);

        Console.WriteLine("Clone:");
        DisplaySet(clone);

        showroom.UnionWith(junkyard);

        Console.WriteLine("My showroom with junkyard:");
        DisplaySet(showroom);

    }

    private static void DisplaySet(HashSet<string> set)
    {
        foreach (string item in set)
        {
            Console.WriteLine(item);
        }

    }
}

