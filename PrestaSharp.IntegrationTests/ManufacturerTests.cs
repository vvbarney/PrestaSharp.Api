using Bukimedia.PrestaSharp.Factories;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace PrestaSharp.IntegrationTests
{
    public class ManufacturerTests : BaseTest
    {

        private ManufacturerFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new ManufacturerFactory(TestUrl, TestApiKey, null);
        }

        [Test]
        public void Listing()
        {
            var manufacturers = factory.GetAll();

            ClassicAssert.AreEqual(2, manufacturers.Count);
            ClassicAssert.AreEqual("Studio Design", manufacturers[0].name);
            ClassicAssert.AreEqual("Graphic Corner", manufacturers[1].name);
        }
    }
}