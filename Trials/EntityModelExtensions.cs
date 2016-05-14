using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trials
{
    public partial class Track
    {
       public double AverageTime
        {
            get { return this.Runs.Average(r => Convert.ToDouble(r.Time)); }
        }
       public double AverageFaults
        {
            get
            {
                return this.Runs.Average(r => Convert.ToDouble(r.Faults));
            }
        }
    }
    
}