using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class TheSweepstakes
    {
        
        Dictionary<int, Contestant> totalContestantCount = new Dictionary<int, Contestant>();
        int registeredNumber;

        public string CreateSweepstakes()
        {
            string name;
            Console.WriteLine("Name of Sweepstakes:");
            name = Console.ReadLine();
            return name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            registeredNumber = totalContestantCount.Count + 1;
            contestant.registrationNumber = registeredNumber;
            totalContestantCount.Add(registeredNumber, contestant);
        }

        public int PickContestWinnner()  
        {

        }

        public void PrintContestantInfo()
        {

        }
    }
}
