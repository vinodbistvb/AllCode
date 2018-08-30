using System;
namespace TipCalculation
{
    public class TipFormula
    {

        double Value;
        public double BillAmount = 0;
        //char menuChoice_Inner;
        char menuChoice;

        public double TipValue()
        {
            // B) Bad tip O) Ok tip G) Good Tip D) Divvy the bill Q) Quit:"
            // If the user enters 'B', 'O', or 'G', calculate and output a tip of 10%, 15%, or 20% respectively.
            // If the user enters 'D', you will need to read the number of diners from the user and then calculate
            // and output the per - diner amount.
            // If the user enters 'Q', you should exit the loop(which will then exit the program).

       


            switch(menuChoice)
            {
                case 'B':
                    // If the user enters 'B', 'O', or 'G', calculate and output a tip of 10 %, 15 %, or 20 % respectively.
                    // Value = this.BillAmount * 0.1;
                    Value = BillAmount * 0.1;
                    Console.WriteLine("Tip amount for dinner is : {0} ", Value);
                    //menuChoice_Inner = this.AskChecqAmount(this);
                    //menuChoice_Inner = AskChecqAmount();
                    //this.TipValue(menuChoice_Inner);
                    AskChecqAmount();
                    TipValue();


                    break;
                case 'O':
                    // If the user enters 'B', 'O', or 'G', calculate and output a tip of 10 %, 15 %, or 20 % respectively.
                    Value = this.BillAmount * 0.15;
                    Console.WriteLine("Tip amount for dinner is : {0} ", Value);
                    //menuChoice_Inner = this.AskChecqAmount(this);
                    //menuChoice_Inner = AskChecqAmount();
                    //this.TipValue(menuChoice_Inner);
                    AskChecqAmount();
                    TipValue();

                    break;
                case 'G':
                    // If the user enters 'B', 'O', or 'G', calculate and output a tip of 10 %, 15 %, or 20 % respectively.
                    Value = this.BillAmount * 0.2;
                    Console.WriteLine("Tip amount for dinner is : {0} ", Value);
                    //menuChoice_Inner = this.AskChecqAmount(this);
                    //menuChoice_Inner = AskChecqAmount();
                    //this.TipValue(menuChoice_Inner);
                    AskChecqAmount();
                    TipValue();

                    break;
                case 'D':
                    // Number of dinners ?? per dinner output
                    Console.Write(" Enter number of Dinners :");
                    int numberOfDinners = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Per person share for the dinner is : {0}", this.BillAmount / numberOfDinners);
                    //menuChoice_Inner = this.AskChecqAmount(this);
                    //menuChoice_Inner = AskChecqAmount( );
                    //this.TipValue(menuChoice_Inner);
                    AskChecqAmount();
                    TipValue();

                    break;
                case 'Q':
                    // exit 
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

            return  Value;
        }

        public void AskChecqAmount( )
        {
            Console.Write("Enter the check amount :");

            BillAmount = int.Parse(Console.ReadLine());

            //Client.BillAmount = int.Parse(Console.ReadLine());

            // Display tip options

            Console.WriteLine("B) Bad tip O) Ok tip G) Good Tip D) Divvy the bill Q) Quit:");
            Console.Write("Select the tip choice :");

            // Get user choice for Tip
            // Thte [3] will get the fourth letter entered by the user as count starts form 0
            //char menuChoice = 'v';

            try
            {
                menuChoice = Console.ReadLine().ToUpper()[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(" This is out of bound exception ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            TipValue();
            //return menuChoice;
        }


    }
}
