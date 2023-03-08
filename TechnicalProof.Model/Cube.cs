using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProof.Model
{
    public class Cube
    {
        public Edge width { get; set; }
        public Edge height { get; set; }
        public Edge depth { get; set; }

        public Cube(Point center, double edgeLength)
        {
            width = new Edge(center.X, edgeLength);
            height = new Edge(center.Y, edgeLength);
            depth = new Edge(center.Z, edgeLength);
        }
    }
}
