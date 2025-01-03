using Bukimedia.PrestaSharp.Factories;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace PrestaSharp.IntegrationTests
{
    public class DeliveryTests : BaseTest
    {

        private DeliveryFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new DeliveryFactory(TestUrl, TestApiKey, null);
        }

        [Test]
        public void Listing()
        {
            var delvieries = factory.GetAll();

            ClassicAssert.IsNotNull(delvieries);
            ClassicAssert.AreEqual(4, delvieries.Count);
        }
    }
}