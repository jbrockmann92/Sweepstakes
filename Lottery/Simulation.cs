using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Simulation
    {

        //Want here to find out if they want queue or stack and use factory pattern to create

        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;

            sweepstakesManager = UserInterface.StackOrQueue(); //Is this right? I want to use Factory
        }

    }
}
