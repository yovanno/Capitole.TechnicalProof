using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProof.Model
{
    public class Edge
    {
        public double start { get; set; }
        public double end { get; set; }

        public Edge(double center, double length)
        {
            start = center - length / 2.0;
            end = center + length / 2.0;
        }
    }
}
