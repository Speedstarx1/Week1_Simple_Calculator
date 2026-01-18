// In my research, I discovered there's a format C# uses before writing code, (using, namespace and class) 
//But today I just found out a class can be public, private or internal.
//I didn't get to ask if it could be none like mine, but the fact that the code is working seems like an answer in a way
//I guess in this case, since it's a simple program, I can leave it as it is.


using System;
namespace Calculator
{
    class Program
    {   
        

        static void Main(string[] args)
        {
            //created variables we would need beforehand
            int firstNumber ;
            int secondNumber ;
            int result ;
            Console.WriteLine("Hello, I'm a simple calculator able to perform arithmetic functions with any two numbers you give me.");
            
            //created loop to repeat until a valid number is inputted
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


            //Same for The second number
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

            //And operation number
            while (true)
            {
                Console.WriteLine("Select the operation you wish to perform \n 1. Addition (+) \n 2. Subtraction (-) \n 3. Multiplication (*) \n 4. Division (/) \n");
                Console.WriteLine("Select By Operation Number(1-4): ");
                string operationInput = Console.ReadLine();

                // Checks to see if the input is valid and executes depending on operation selected

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
        
        // Arithmetic operation functions to use in the code above
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

// Notes:
// Made my research about the null error in my 3 lines of code requesting user input
// Apparently it seems like a warning to me in any case the user doesn't input anything, i guess.

// The Program still has further advancements that can be made:
// Increasing the number of digits the user intends to use
// Looping the program until the user decides to close(Restarting after each operation seems too inconvenient)
