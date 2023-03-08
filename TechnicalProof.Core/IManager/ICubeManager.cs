using TechnicalProof.Model;

namespace TechnicalProof.Core.IManager
{
    public interface ICubeManager
    {
        public Task<double> IntersectionVolumeWithAsync(Cube cubeA, Cube cubeB);
        public Task<bool> CollidesWithAsync(Cube cubeA, Cube cubeB);
    }
}