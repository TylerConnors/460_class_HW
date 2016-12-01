using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs460_HW3
{
	class Calculator
	{

		/**
 *  Our data structure, used to hold operands for the postfix calculation.
 */
		private LinkedStack stack = new LinkedStack();


		static void Main(string[] args)
		{
			Calculator app = new Calculator();
			bool playAgain = true;
			Console.WriteLine("\nPostfix Calculator. Recognizes these operators: + - * /");
			while (playAgain)
			{
				playAgain = app.doCalculation();
			}
			Console.WriteLine("Bye.");
		}





		private Boolean doCalculation()
		{
			Console.WriteLine("Please enter q to quit\n");
			string input = "2 2 +";
			Console.Write("> ");         // prompt user

			input = Console.ReadLine();
			// looks like nextLine() blocks for input when used on an InputStream (System.in).  Docs don't say that!

			// See if the user wishes to quit
			if (input.First() == ('q') || input.First() == ('Q'))
			{
				return false;
			}
			// Go ahead with calculation
			string output = "4";
			try
			{
				output = evaluatePostFixInput(input);
			}
			catch (ArgumentException e)
			{
				output = "illegal argument: " + e;
			}
			Console.WriteLine("\n\t>>> " + input + " = " + output);
			return true;
		}

        public String evaluatePostFixInput(String input)
        {
            if (input == null || input.Equals(""))
            {
                throw new ArgumentException("Null or the empty string are not valid postfix expressions.");
            }
            stack.clear();

            string s;   // Temporary variable for token read
            double a;   // Temporary variable for operand
            double b;   // ...for operand
            double c;   // ...for answer
            string[] st = input.Split(' '); //splits them into an array
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != ("+") && st[i] != ("-") && st[i] != ("*") && st[i] != ("/")) //checks if its a number
                { 
                    stack.push(Convert.ToDouble(st[i]));    // if it's a number push it on the stack
                }
                else
                {
                    // Must be an operator or some other character or word.
                    s = st[i];
                    if (s.Length > 1)
                    {
                        throw new ArgumentException("Input Error: " + s + " is not an allowed number or operator");

                    }

                    // it may be an operator so pop two values off the stack and perform the indicated operation

                    if (stack.isEmpty())
                    {
                       throw new FormatException("Improper input format. Stack became empty when expecting second operand.");
                    }

                    b = ((Double)(stack.pop()));

                    if (stack.isEmpty())
                    {
                        throw new FormatException("Improper input format. Stack became empty when expecting first operand.");
                    }

                    a = ((Double)(stack.pop()));
                    // Wrap up all operations in a single method, easy to add other binary operators this way if desired
                    c = doOperation(a, b, s);
                    // push the answer back on the stack
                    stack.push((c.ToString("0.######")));
                }
            }
                return ((String)(stack.pop()));
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
