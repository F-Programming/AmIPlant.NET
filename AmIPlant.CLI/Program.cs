using System;
using AmIPlant.Core.Entities;

namespace AmIPlant.CLI;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        float w = float.Parse(args[0]);
        float h = float.Parse(args[1]);
        DateOnly v = DateOnly.Parse(args[2]);

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