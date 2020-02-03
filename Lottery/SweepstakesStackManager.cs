using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakes = new Stack<Sweepstakes>();
        public Contestant winner;

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            this.sweepstakes.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes recentSweepstakes;
            recentSweepstakes = sweepstakes.Pop();
            winner = recentSweepstakes.PickWinner();
            winner.isWinner = true;
            recentSweepstakes.Notify();
            return recentSweepstakes;
        }
    }
}
