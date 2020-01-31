using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Simulation
    {

        //This is where I call the method that will do everything else. I need to instantiate a MarketingFirm here.

        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;

            sweepstakesManager = UserInterface.StackOrQueue(); //Is this right? I want to use Factory
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
        }

    }
}
