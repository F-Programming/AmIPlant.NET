using AmIPlant.Core.Entities;

namespace AmIPlant.CLI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        var w = float.Parse(args[0]);
        var h = float.Parse(args[1]);
        var v = DateOnly.Parse(args[2]);

        Person person = new()
        {
            Gender = Gender.Male,
            Height = h,
            Weight = w,
            WentVegan = v
        };

        if (args[3][0] == 'f')
        {
            person.Gender = Gender.Female;
        }
    }
}