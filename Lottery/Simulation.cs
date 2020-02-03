using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            ISweepstakesManager sweepstakesManager;

            sweepstakesManager = UserInterface.StackOrQueue(); //Is this right? I want to use Factory
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepstakes();
            Console.ReadLine();
            marketingFirm.manager.GetSweepstakes();
        }
    }
}
