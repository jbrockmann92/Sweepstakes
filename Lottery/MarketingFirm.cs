using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            //This is the factory pattern. If I try to make the decision in this class about queue or stack, I would have to write two different methods or something and it could cause all kinds of problems later
            this.manager = manager;
        }

        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetSweepstakesName());
            manager.InsertSweepstakes(sweepstakes);

            sweepstakes.RegisterContestant(UserInterface.GetContestantInfo());
            //Probably not the best place for this. Need to be able to register multiple.
        }
    }
}
