using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.Write("num1---");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("num2---");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Simvollar (/,+,-,*):");
            string simvol = Console.ReadLine();

            switch (simvol)
            {
                case "+":
                    sum = num1 + num2;
                    Console.WriteLine(sum);
                    break;

                case "-":
                    sum = num1 - num2;
                    Console.WriteLine(sum);
                    break;

                case "/":
                    sum = num1 / num2;
                    Console.WriteLine(sum);
                    break;

                case "*":
                    sum = num1 * num2
                    ; Console.WriteLine(sum);
                    break;

                default:
                    Console.WriteLine("Yeniden cehd edin");
                    break;
            }
            Console.ReadLine();
            Console.Write("Tesekkur");
        }

        

}
