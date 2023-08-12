using System;
namespace KnowledgeCheck1_Calculator
{
	public class Entry
	{
		public (string, string) NumberEntry(string operatorChoice)
		{
            Console.WriteLine("Enter 2 integers to " + operatorChoice);
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            return (number1, number2);
        }
	}
}

