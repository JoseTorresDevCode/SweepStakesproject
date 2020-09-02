using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm 
    {
        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
           
        }

        public string SweepstakesCreation(string userInput)
        {
            Console.WriteLine("would you like to create a Sweepstakes?");
            userInput = Console.ReadLine();
            
            if (userInput == "yes")
            {
                TheSweepstakes theSweepstakes = new TheSweepstakes();
                theSweepstakes.CreateSweepstakes();
            }
            else
            {
                Console.WriteLine("please hit enter to exit");
            }
            return userInput;
        }

        public void ChooseManagerType(string managerType)
        {
            Console.WriteLine("enter 1: Queue Manager -- Enter 2: Stack Manager");
            managerType = Console.ReadLine();

            
        }

    }
}
