using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<TheSweepstakes> stack;
        public TheSweepstakes GetTheSweepstakes()
        {
            return stack.Pop();
        }
        public void InsertSweepstakes(TheSweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

    }
}
