using System;
using System.Linq;

namespace RemakeSolbCalc
{
    class Program
    {
        static readonly char[] operList = { '+', '-', '*', '/' };
        static string result = "";

        static void Main(string[] args)
        {
            Run();
        }

        static string Calculation(double A, double B, char oper) //method for calculations
        {
            {

            }
            switch (oper)
            {
                case '+':
                    return Convert.ToString(A + B);
                case '-':
                    return Convert.ToString(A - B);
                case '*':
                    return Convert.ToString(A * B);
                case '/':

                    if (B != 0)
                    {
                        return Convert.ToString(A / B);
                    }
                    else
                    {                  
                        Console.WriteLine("Can't divide by 0, try new calculation");
                        return "0";
                    }                  

                default: return "";
            }
        }

        static string TakeArgs() //method for assigning values to arguments
        {
            string input = Console.ReadLine();

            if (input == "C" || input == "С")
            {
                Console.Clear();
                return result = "0";
            }

            else if (!char.IsDigit(input[0]))
            {
                double[] arg = input.Split(operList, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToDouble(n)).ToArray();
                char oper = operList.FirstOrDefault(input.Contains);
                result = Calculation(Convert.ToDouble(result), arg[0], oper);
                return result;
            }

            else
            {
                double[] argList = input
                    .Split(operList, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(n => Convert.ToDouble(n)).ToArray();  // parsing user input in 2 arguments

                char oper = operList.FirstOrDefault(input.Contains);
                result = argList[0].ToString();
                result = Calculation(Convert.ToDouble(result), argList[1], oper);
                return result;
            }
        }

        static void Run() //method that runs a cycle of the programm
        {
            do
            {
                Console.WriteLine(TakeArgs());
            }
            while (true);
        }
    }
}
