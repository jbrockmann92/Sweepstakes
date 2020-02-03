using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        Stack<Sweepstakes> sweepstakes = new Stack<Sweepstakes>();
        public Contestant winner;
        //Constructor

        //Member Methods (CAN DO)

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //Insert into stack here
            this.sweepstakes.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes recentSweepstakes;
            recentSweepstakes = sweepstakes.Pop();
            winner = recentSweepstakes.PickWinner();
            recentSweepstakes.PrintcontestantInfo(winner);
            return recentSweepstakes;
        }
    }
}
