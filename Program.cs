using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("provide 1 number to perform the addition operation");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("provide a number to add to " + num1 +".");
        int num2 = int.Parse (Console.ReadLine());
        Console.WriteLine(num1 + num2);

        Console.WriteLine("provide 1 number to perform the subtraction operation");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("provide a number to subtract to " + num3 +".");
          int num4 = int.Parse (Console.ReadLine());
          Console.WriteLine(num3 - num4);

          Console.WriteLine("provide 1 number to perform the multiplication operation");
        int num5 = int.Parse(Console.ReadLine());
        Console.WriteLine("provide a number to multiplication to " + num5 +".");
          int num6 = int.Parse (Console.ReadLine());
          Console.WriteLine(num5 * num6);

          Console.WriteLine("provide 1 number to perform the integer division operation");
        int num7 = int.Parse(Console.ReadLine());
        Console.WriteLine("provide a number to integer division  to " + num7 +".");
          int num8 = int.Parse (Console.ReadLine());
          Console.WriteLine(num7 / num8);

        Console.WriteLine("provide 1 number to perform the Floating Point/Decimal division operation");
        float num9 = float.Parse(Console.ReadLine());
        Console.WriteLine("provide a number to Floating Point/Decimal to " + num9 +".");
          float num10 = float.Parse (Console.ReadLine());
          Console.WriteLine(num9 / num10);

           Console.WriteLine("provide 1 number to perform the Modulus operation");
           int num11 = int.Parse(Console.ReadLine());
           Console.WriteLine("provide a number to Modulus to " + num11 +".");
           int num12 = int.Parse (Console.ReadLine());
           Console.WriteLine(num11 % num12);


          
    }
}