namespace MathLib;

public static class Math {

    public static int Add(int x, int y) {
        return x + y; 
    }
    public static int Sub(int x, int y) {
        return x - y; 
    }
    public static int Mult(int x, int y) {
        return x * y; 
    }
    public static int Div(int x, int y) {
        if(y != 0) {
            return x / y; 
        }
        Console.WriteLine("Cannot divide by zero!");
        return 0;
    }

    public static int Mod(int x, int y) {
        return x - (x / y * y);
    }

    public static int Sqr(int x) {
        return x * x;
    }

    // Factorial(5) = 5 * 4 * 3 * 2 * 1
    public static int Fact(int x) {
        var sum = 1;
        for(int i = x; i > 1; i--) {
            sum *= i;
        }
        return sum;
    }

}
