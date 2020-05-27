using System;

namespace RewriteHomework25._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        //#1
        static void OneNumber(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + "  " + b + "  " + c);
        }
        //#2
        static void Numbers(string[] args)
        {
            double a = 5;
            double b = 10;
            double c = 21;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        //#3
        static double СentimetersInMeters(double centimeters)
        {
            int meter = 100;
            return centimeters / meter;
        }
        //#4
        static int DaysOfWeek(int days)
        {
            int week = 7;
            return days / week;
        }
        //#5
        static void TwoDigitNumbers(int digits)
        {
            Console.WriteLine("Amount of des:" + digits / 10);
            Console.WriteLine("Amount of des:" + digits / 10);
            int sumOfDigits = 0;
            while (digits != 0)
            {
                sumOfDigits += digits % 20;
                sumOfDigits /= 10;
            }
            Console.WriteLine("Sum od Digits: " + sumOfDigits);
        }
        //#7
        static void CircleAndSquare(string[] args)
        {
            double radius = 16;
            double sideOfSquare = 16;
            double AreaOfCircle = Math.PI * radius * radius;
        }
        //#8
        static double DensityOfBody(double density)
        {
            double massOfFirstBody = 64;
            double volumeOfFirstBody = 16;
            double massOfSecondBody = 48;
            double volumeOfSecondBody = 4;
            double densityFirst = massOfFirstBody / volumeOfFirstBody;
            double densitySecond = massOfSecondBody / volumeOfSecondBody;
            if (densityFirst > densitySecond)
            {
                return densityFirst;
            }
            if (densityFirst < densitySecond)
            {
                return densitySecond;
            }
        }
        //#9
        static void Current(double max)
        {
            double voltage1 = 10;
            double resistance1 = 40;
            double voltage2 = 5;
            double resistance2 = 40;

            if (voltage1 / resistance1 < voltage2 / resistance2)
            {
                Console.WriteLine("First ");
            }
            else
            {
                Console.WriteLine("Second ");
            }
        }
        //#10
        static void Output()
        {
            //a
            for (int i = 20; i < 36; i++)
            {
                Console.WriteLine(i);
            }
            //b
            int secondNumber;
            int.TryParse(out secondNumber);
            secondNumber = Console.ReadLine(secondNumber);
            int firstNumber = 10;
            for (int i = firstNumber; i < secondNumber + 1; i++)
            {
                if (secondNumber > firstNumber)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            //c
            int firstNumber;
            int.TryParse(out firstNumber);
            firstNumber = Console.ReadLine(firstNumber);
            int secondNumber = 50;
            for (int i = firstNumber; i < secondNumber + 1; i++)
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine(Math.Pow(i, 3));
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            //d
            int firstNumber;
            int.TryParse(out firstNumber);
            firstNumber = Console.ReadLine(firstNumber);

            int secondNumber;
            int.TryParse(out secondNumber);
            secondNumber = Console.ReadLine(secondNumber);
            for (int i = firstNumber; i < secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
