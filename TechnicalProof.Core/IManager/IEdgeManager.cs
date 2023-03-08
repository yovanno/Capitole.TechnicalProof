using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProof.Model;

namespace TechnicalProof.Core.IManager
{
    public interface IEdgeManager
    {
        Task<double> Overlap(Edge edgeA, Edge edgeB);
        Task<bool> Collides(Edge edgeA, Edge edgeB);
    }
}
