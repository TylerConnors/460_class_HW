using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs460_HW3
{
	class Calculator
	{
		static void Main(string[] args)
		{
		}








        public double doOperation(double a, double b, String s) 
		{
		double c = 0.0;
			if (s.Equals("+"))      // Can't use a switch-case with Strings, so we do if-else
				c = (a + b);
			else if (s.Equals("-"))
				c = (a - b);
			else if (s.Equals("*"))
				c = (a * b);
			else if (s.Equals("/"))
			{

				try
				{
					c = (a / b);

				}
				catch (DivideByZeroException)
				{
					Console.WriteLine("Division of zero.");
				}
			}
			else
				throw new ArgumentException("Improper operator: " + s + ", is not one of +, -, *, or /");

		return c;
	}
	}
}
