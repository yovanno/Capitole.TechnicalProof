using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProof.Core.IManager;
using TechnicalProof.Model;

namespace TechnicalProof.Core.Manager
{
    public class CubeManager : ICubeManager
    {
        private readonly IEdgeManager _edgeManager;

        public CubeManager(IEdgeManager edgeManager)
        {
            _edgeManager = edgeManager;
        }

        /// <summary>
        /// Calculates the value of the intersection volume between two cubes.
        /// </summary>
        /// <param name="cubeA"> Cube A</param>
        /// <param name="cubeB">Cube B</param>
        /// <returns></returns>
        public async Task<double> IntersectionVolumeWithAsync(Cube cubeA, Cube cubeB) =>

            await _edgeManager.Overlap(cubeA.width, cubeB.width).ConfigureAwait(continueOnCapturedContext: false)
                * await _edgeManager.Overlap(cubeA.height, cubeB.height).ConfigureAwait(continueOnCapturedContext: false)
                * await _edgeManager.Overlap(cubeA.depth, cubeB.depth).ConfigureAwait(continueOnCapturedContext: false);

        /// <summary>
        /// Determines if two cubes collide
        /// </summary>
        /// <param name="cubeA">Cube A</param>
        /// <param name="cubeB">Cube B</param>
        /// <returns></returns>
        public async Task<bool> CollidesWithAsync(Cube cubeA, Cube cubeB) =>
                await _edgeManager.Collides(cubeA.width, cubeB.width).ConfigureAwait(continueOnCapturedContext: false)
                || await _edgeManager.Collides(cubeA.height, cubeB.height).ConfigureAwait(continueOnCapturedContext: false)
                || await _edgeManager.Collides(cubeA.depth, cubeB.depth).ConfigureAwait(continueOnCapturedContext: false);
    }
}
