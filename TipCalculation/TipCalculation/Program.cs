using System;

namespace TipCalculation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            TipFormula ClientOne = new TipFormula();

            // Get the total check amount
            Console.Write("Enter the check amount :");
            ClientOne.BillAmount = int.Parse(Console.ReadLine());

            // Display tip options
          
            Console.WriteLine("B) Bad tip O) Ok tip G) Good Tip D) Divvy the bill Q) Quit:");
            Console.Write("Select the tip choice :");

            // Get user choice for Tip
            // Thte [3] will get the fourth letter entered by the user as count starts form 0
            char input = Console.ReadLine()[3];

            Console.WriteLine(input);

            Console.ReadLine();

            // Calculate the tip amount
            // Again ask for the check amount 


        }
    }
}
