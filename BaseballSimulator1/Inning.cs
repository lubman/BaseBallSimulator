using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballSimulator1
{
          
    public class Inning
    {
        public Team.TeamType HalfInning { get; set; }

        public double InningNumber { get; set; }
        public int Outs { get; set; }

    }
}
