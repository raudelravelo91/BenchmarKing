using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarKing
{
    public class InMemoryDB
    {
        public List<Game> Games { get; set; }

        public List<Rig> Rigs { get; set; }

        public List<BenchResult> Benchs { get; set; }
    }
}
