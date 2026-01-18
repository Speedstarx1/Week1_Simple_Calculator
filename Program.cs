using System;
namespace Calculator
{
    class Program
    {   
        

        static void Main(string[] args)
        {

            int firstNumber ;
            int secondNumber ;
            int result ;
            Console.WriteLine("Hello, I'm a simple calculator able to perform arithmetic functions with any two numbers you give me.");
            
            while (true)
            {
                Console.WriteLine("Input First Number: ");
                string firstNumberInput = Console.ReadLine();
                
                if (int.TryParse(firstNumberInput, out firstNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            while (true)
            {
                Console.WriteLine("Input Second Number: ");
                string secondNumberInput = Console.ReadLine();
                
                if (int.TryParse(secondNumberInput, out secondNumber))
                {
                    break;
                }

                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }


            while (true)
            {
                Console.WriteLine("Select the operation you wish to perform \n 1. Addition (+) \n 2. Subtraction (-) \n 3. Multiplication (*) \n 4. Division (/) \n");
                Console.WriteLine("Select By Operation Number(1-4): ");
                string operationInput = Console.ReadLine();
                
                if (int.TryParse(operationInput, out int operation) && operation >= 1 && operation <= 4)
                {
                    if (operation == 1)
                    {
                        result = AddNumbers(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
                    }
                    else if (operation == 2)
                    {
                        result = SubtractNumbers(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " - " + secondNumber + "=" + result);
                    }
                    else if (operation == 3)
                    {
                        result = MultiplyNumbers(firstNumber, secondNumber);
                        Console.WriteLine(firstNumber + " * " + secondNumber + " = " + result);
                    }
                    else if (operation == 4)
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        else
                        {
                            double divisionResult = DivideNumbers(firstNumber, secondNumber);
                            Console.WriteLine(firstNumber + " / " + secondNumber + " = " + divisionResult);
                        }
                    }
                    break;
                }
                
                    
                    
                
            }
        }
        

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        static int SubtractNumbers(int x, int y)
        {
            return x - y;
        }

        static int MultiplyNumbers(int x, int y)
        {
            return x * y;
        }

        static double DivideNumbers(int x, int y)
        {
            return (double)x / y;
        }
    }
}

            
        