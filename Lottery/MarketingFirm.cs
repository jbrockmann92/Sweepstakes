using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class MarketingFirm
    {
        //Highest level class
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            //I have already gotten the choice of stack or queue by this point. 
            this.manager = manager;
        }

        public void CreateSweepstakes()
        {
            
        }
    }
}
