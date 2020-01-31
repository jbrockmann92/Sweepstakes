using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        Queue<Sweepstakes> sweepstakes = new Queue<Sweepstakes>();

        //Constructor

        //Member Methods (CAN DO)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {

        }
    }
}
