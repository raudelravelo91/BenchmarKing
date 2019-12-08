using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarKing
{
    public class BenchResult
    {
        public Rig Rig { get; set; }

        public GameConfig GameConfig { get; set; }

        public int Avg { get; set; }

        public int OnePercentLow { get; set; }
    }
}
