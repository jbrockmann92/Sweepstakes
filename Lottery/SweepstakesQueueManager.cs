using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes;
        public Contestant winner;

        public SweepstakesQueueManager()
        {
            sweepstakes = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes recentSweepstakes = sweepstakes.Dequeue();
            winner = recentSweepstakes.PickWinner();
            winner.isWinner = true;
            recentSweepstakes.Notify();
            return recentSweepstakes;
        }
    }
}
