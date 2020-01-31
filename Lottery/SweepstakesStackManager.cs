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
            //Insert into stack here
        }

        public Sweepstakes GetSweepstakes()
        {
            //Where I pull the instance off the top
        }
    }
}
