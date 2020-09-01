using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {



        public static void ContestantDetails(Contestant contestant)
        {
            int contestantNumber;
            int totalCount;
            Console.WriteLine("What is your First Name:");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("What is your Last Name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("What is your Email Address");
            contestant.emailAddress = Console.ReadLine();

            
            for (contestantNumber = 0; contestantNumber < totalCount; contestantNumber++)
            {
                contestantNumber = contestant.registrationNumber;
            }


        }


    }
}
   
