using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProof.Model;

namespace TechnicalProof.UnitTest
{
    public class CubeBuilder
    {
        private Point center;
        private double edgeLength;
        public static CubeBuilder Cube()
        {
            return new CubeBuilder();
        }
        public CubeBuilder CenteredAt(double x, double y, double z)
        {
            center = new Point(x, y, z);
            return this;
        }
        public CubeBuilder WithEdgeLength(double length)
        {
            edgeLength = length;
            return this;
        }
        public Cube Build()
        {
            return new Cube(center, edgeLength);
        }
    }
}
