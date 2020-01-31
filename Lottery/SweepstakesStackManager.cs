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
        //Constructor

        //Member Methods (CAN DO)

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes stackSweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            stackSweepstakes.RegisterContestant(UserInterface.GetContestantInfo());
            return stackSweepstakes;
        }
    }
}
