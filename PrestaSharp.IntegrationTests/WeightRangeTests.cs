using Bukimedia.PrestaSharp.Factories;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace PrestaSharp.IntegrationTests
{
    public class WeightRangeTests : BaseTest
    {

        private WeightRangeFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new WeightRangeFactory(TestUrl, TestApiKey, null);
        }

        [Test]
        public void Listing()
        {
            var weightRanges = factory.GetAll();

            ClassicAssert.IsNotNull(weightRanges);
            ClassicAssert.AreEqual(1, weightRanges.Count);
        }
    }
}