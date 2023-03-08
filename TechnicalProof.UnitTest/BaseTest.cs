using Microsoft.Extensions.DependencyInjection;
using TechnicalProof.Core.IManager;
using TechnicalProof.Core.Manager;

namespace TechnicalProof.UnitTest
{
    [TestClass]
    public abstract class BaseTest
    {
        protected IServiceProvider serviceProvider;        
        protected ServiceCollection serviceCollection;

        [TestInitialize]
        public void Init()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IEdgeManager, EdgeManager>();
            serviceCollection.AddScoped<ICubeManager, CubeManager>();

            serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}