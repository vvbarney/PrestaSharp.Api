using Bukimedia.PrestaSharp.Factories;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace PrestaSharp.IntegrationTests
{
    public class PriceRangeTests : BaseTest
    {

        private PriceRangeFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new PriceRangeFactory(TestUrl, TestApiKey, null);
        }

        [Test]
        public void Listing()
        {
            var priceRanges = factory.GetAll();

            ClassicAssert.IsNotNull(priceRanges);
            ClassicAssert.AreEqual(1, priceRanges.Count);
        }
    }
}