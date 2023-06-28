using System;
using System.Diagnostics;

//ref link:https://www.youtube.com/watch?v=QUhI2BbP8VA&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=14
// Debug > Window > Watch > Watch1

[DebuggerDisplay("{Name}, Amount of meat: {Weight}")]
class Cow
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
}

class MainClass
{
    static void Main()
    {
        var cow = new Cow { Name = "Betsy", Age = 5, Weight = 1500 };
        Console.WriteLine(cow);
    }
}