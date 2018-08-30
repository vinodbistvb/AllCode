using System;

namespace TipCalculation
{
    class MainClass
    {



        public static void Main(string[] args)
        {
           
            TipFormula ClientOne = new TipFormula();
            ClientOne.AskChecqAmount();

            // char menuChoice =  ClientOne.AskChecqAmount();
             
            // double value =  ClientOne.TipValue(menuChoice);

            // Again ask for the check amount
            // Console.ReadLine();
        }

      
    }
}
