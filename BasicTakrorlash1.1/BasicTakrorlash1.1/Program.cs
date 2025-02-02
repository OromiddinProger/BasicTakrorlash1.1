using System;

class Program
{
    static void Main1()
    {
        int son = 0;

        for (int i = 0; i <= 1000; i++)
        {
            son += i;
        }
        Console.WriteLine(son);
    }
    static void Main2()
    {
        int[] myArray = { 3, 5, 7, 2, 8, 1 };

        int max = myArray[0];
        
        int min = myArray[0];

        for (int i = 1; i < myArray.Length; i++)
        {
            if (myArray[i] > max) max = myArray[i];

            if (myArray[i] < min) min = myArray[i];
        }
        int result = max * min;

        Console.WriteLine("Eng katta va eng kichik qiymatlarning ko'paytmasi: " + result);
    }
    static void Main()
    {
        Console.Write("Sonni kiriting: ");

        int x = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;

        for (int i = 1; i <= x; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(x + "! = " + factorial);
    }

}
