using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProof.Core.IManager;
using static TechnicalProof.UnitTest.CubeBuilder;

namespace TechnicalProof.UnitTest.Core
{
    [TestClass]
    public class CubeTest : BaseTest
    {
        private ICubeManager _cubeManager;

        [TestInitialize]
        public void InitSql()
        {
            _cubeManager = serviceProvider.GetRequiredService<ICubeManager>();
        }

        [TestMethod]
        public async Task Cubes_CollidesWith_False()
        {
            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            var collide = await _cubeManager.CollidesWithAsync(cubeA, cubeB);
            Assert.IsFalse(collide);
        }

        [TestMethod]
        public async Task Cubes_CollidesWith_True()
        {
            var cubeA = Cube().CenteredAt(4, 4, 4).WithEdgeLength(6).Build();
            var cubeB = Cube().CenteredAt(3, 6, 6).WithEdgeLength(6).Build();

            var collide = await _cubeManager.CollidesWithAsync(cubeA, cubeB);
            Assert.IsTrue(collide);
        }

        [TestMethod]
        public async Task Cubes_intersectedVolume_Zero()
        {
            var expectedValue = 0;

            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(10, 10, 10).WithEdgeLength(2).Build();

            var intersetedVolume = await _cubeManager.IntersectionVolumeWithAsync(cubeA, cubeB);

            Assert.AreEqual(expectedValue, intersetedVolume);
        }

        [TestMethod]
        public async Task Cubes_intersectedVolume_Four()
        {
            var expectedValue = 4;

            var cubeA = Cube().CenteredAt(2, 2, 2).WithEdgeLength(2).Build();
            var cubeB = Cube().CenteredAt(2, 2, 3).WithEdgeLength(2).Build();

            var intersetedVolume = await _cubeManager.IntersectionVolumeWithAsync(cubeA, cubeB);

            Assert.AreEqual(expectedValue, intersetedVolume);
        }        
    }
}
