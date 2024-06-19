using MathLib;

using StringLib;

using System.Security.Cryptography;


namespace MathConsole;

public class Program {

    static void Main(string[] args) {

        var fact = MathLib.Math.Fact(5);
        Console.WriteLine(fact);

        var mod = MathLib.Math.Mod(8, 3);
        Console.WriteLine($"8 % 3 is {mod}");

        var sl = new StringLibrary();
        var newStr = sl.Concat("Hello,", "World!");
        Console.WriteLine(newStr);

        var converted = sl.ToUpperEveryOther("aBCdeFG");
        Console.WriteLine(converted);

        var answer = MathLib.Math.Add(11, 22);
        Console.WriteLine(answer);

    }
}

