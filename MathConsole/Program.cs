using MathLib;

using StringLib;

using System.Security.Cryptography;


namespace MathConsole;

public class Program {

    static void Main(string[] args) {

        var nbr = 6;
        var fact = MathLib.Math.Fact(nbr);
        Console.WriteLine($"Factorial of {nbr} is {fact}");

        var mod = MathLib.Math.Mod(8, 3);
        Console.WriteLine($"8 % 3 is {mod}");

        var sl = new StringLibrary();
        var newStr = sl.Concat("Hello,", "World!");
        Console.WriteLine(newStr);

        var converted = sl.ToUpperEveryOther("a1B2C3d4e5F6G7");
        Console.WriteLine(converted);

        var answer = MathLib.Math.Add(11, 22);
        Console.WriteLine(answer);

    }
}

