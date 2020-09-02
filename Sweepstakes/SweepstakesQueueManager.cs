using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<TheSweepstakes> queue;
        public TheSweepstakes GetTheSweepstakes()
        {
            return queue.Dequeue();
        }
        public void InsertSweepstakes(TheSweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

    }
}
