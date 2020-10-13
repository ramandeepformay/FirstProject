using System;
namespace FirstProject
{
    public class sum
    {
         static void Main2(string[] args)
        {
            System.Console.WriteLine("Enter the two nos. to get the sum");
            var num1 = gatherInput();
            var num2 = gatherInput();
            var sum = summationGenerator(num1, num2);
            print(sum);


        }
        public static int gatherInput()
        {
            System.Console.WriteLine("=================");
            System.Console.WriteLine("Enter the no.");
            var inputVal = Console.ReadLine();
            var number = -1;
            bool success = Int32.TryParse(inputVal, out number);
            if (success)
            {
                return number;
            }
            else
            {
                return -1;
            }

        }
        public static int summationGenerator(int a, int b)
        {
            var summation = a;
            for (int i = a + 1; i <= b; i++)
            {
                summation += i;
            }
            return summation;
        }

        public static void print(int a)
        { 
            if (a == -1)
            {
                System.Console.WriteLine("Please enter the valid i/p :)");
                return;
            }
            System.Console.WriteLine("So the sum is" + " " + a);
        }

    
    }
}