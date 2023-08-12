using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            var entry = new Entry();

            switch (input)
            {
                case "1":
                    {
                        string operation = "add";
                        var (num1, num2) = entry.NumberEntry(operation);

                        if (int.TryParse(num1, out int addNumOne) && int.TryParse(num2, out int addNumTwo))
                        {
                            Console.Write($"{num1} + {num2} = ");
                            Console.Write(calculator.Add(addNumOne, addNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;
                    }

                case "2":
                    {
                        string operation = "subtract";
                        var (num1, num2) = entry.NumberEntry(operation);

                        if (int.TryParse(num1, out int subNumOne) && int.TryParse(num2, out int subNumTwo))
                        {
                            Console.Write($"{num1} - {num2} = ");
                            Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;
                    }

                case "3":
                    {
                        string operation = "multiply";
                        var (num1, num2) = entry.NumberEntry(operation);

                        if (int.TryParse(num1, out int multNumOne) && int.TryParse(num2, out int multNumTwo))
                        {
                            Console.Write($"{num1} * {num2} = ");
                            Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;
                    }

                case "4":
                    {
                        string operation = "divide";
                        var (num1, num2) = entry.NumberEntry(operation);

                        if (double.TryParse(num1, out double divNumOne) && double.TryParse(num2, out double divNumTwo))
                        {
                            Console.Write($"{num1} / {num2} = ");
                            Console.Write(calculator.Divide(divNumOne, divNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;
                    }

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}


