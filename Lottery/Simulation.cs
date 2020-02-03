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

            sweepstakesManager = UserInterface.StackOrQueue();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakesManager);
            marketingFirm.CreateSweepstakes();
            Console.ReadLine();
            marketingFirm.manager.GetSweepstakes();
            Console.ReadLine();
        }
    }
}
