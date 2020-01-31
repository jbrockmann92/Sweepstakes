﻿using System;
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
        //Want to ask the client whether they want to complete the most recent sweepstakes first or last??
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes queueSweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            queueSweepstakes.RegisterContestant(UserInterface.GetContestantInfo());
            return queueSweepstakes;
        }
    }
}
