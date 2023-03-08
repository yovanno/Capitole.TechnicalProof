using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProof.Core.IManager;
using TechnicalProof.Model;

namespace TechnicalProof.Core.Manager
{
    public class EdgeManager : IEdgeManager
    {
        /// <summary>
        /// Calculates the value of the overlap between two edges.
        /// </summary>
        /// <param name="edgeA">Edge A</param>
        /// <param name="edgeB">Edge B</param>
        /// <returns></returns>
        public async Task<double> Overlap(Edge edgeA, Edge edgeB) =>
            Math.Max(0, await Difference(edgeA, edgeB));

        /// <summary>
        /// calculate if two edges collide
        /// </summary>
        /// <param name="edgeA"></param>
        /// <param name="edgeB"></param>
        /// <returns></returns>
        public async Task<bool> Collides(Edge edgeA, Edge edgeB) =>
            await Difference(edgeA, edgeB) >= 0;

        /// <summary>
        /// Calculates the difference value between two edges
        /// </summary>
        /// <param name="edgeA"></param>
        /// <param name="edgeB"></param>
        /// <returns></returns>
        private async Task<double> Difference(Edge edgeA, Edge edgeB) =>
            Math.Min(edgeA.end, edgeB.end) - Math.Max(edgeA.start, edgeB.start);
    }
}
