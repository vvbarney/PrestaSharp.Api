using Bukimedia.PrestaSharp.Factories;
using NUnit.Framework;
using NUnit.Framework.Legacy;

using System.Collections.Generic;
using System.Linq;

namespace PrestaSharp.IntegrationTests
{
    public class ProductTests : BaseTest
    {

        private ProductFactory factory;

        [SetUp]
        public void Setup()
        {
            factory = new ProductFactory(TestUrl, TestApiKey, null);
        }

        [Test]
        public void Listing()
        {
            var products = factory.GetAll();

            ClassicAssert.AreEqual(19, products.Count);
            ClassicAssert.AreEqual("Hummingbird printed t-shirt", products[0].name[0].Value);
            ClassicAssert.AreEqual("Hummingbird printed sweater", products[1].name[0].Value);
            ClassicAssert.AreEqual("Mountain fox notebook", products[2].name[0].Value);
            ClassicAssert.AreEqual("Brown bear notebook", products[3].name[0].Value);
            ClassicAssert.AreEqual("Hummingbird notebook", products[4].name[0].Value);
            ClassicAssert.AreEqual("Mug The best is yet to come", products[5].name[0].Value);
            ClassicAssert.AreEqual("Mug The adventure begins", products[6].name[0].Value);
            ClassicAssert.AreEqual("Mug Today is a good day", products[7].name[0].Value);
            ClassicAssert.AreEqual("Mountain fox cushion", products[8].name[0].Value);
            ClassicAssert.AreEqual("Brown bear cushion", products[9].name[0].Value);
            ClassicAssert.AreEqual("Hummingbird cushion", products[10].name[0].Value);
            ClassicAssert.AreEqual("Pack Mug + Framed poster", products[11].name[0].Value);
            ClassicAssert.AreEqual("Customizable mug", products[12].name[0].Value);
            ClassicAssert.AreEqual("The best is yet to come' Framed poster", products[13].name[0].Value);
            ClassicAssert.AreEqual("The adventure begins Framed poster", products[14].name[0].Value);
            ClassicAssert.AreEqual("Today is a good day Framed poster", products[15].name[0].Value);
            ClassicAssert.AreEqual("Mountain fox - Vector graphics", products[16].name[0].Value);
            ClassicAssert.AreEqual("Brown bear - Vector graphics", products[17].name[0].Value);
            ClassicAssert.AreEqual("Hummingbird - Vector graphics", products[18].name[0].Value);
        }

        [Test]
        public void AddList()
        {
            System.Collections.Generic.List<Bukimedia.PrestaSharp.Entities.product> inputProducts = new System.Collections.Generic.List<Bukimedia.PrestaSharp.Entities.product>() {
            new Bukimedia.PrestaSharp.Entities.product()
            {
                reference ="NEWREF",
                name = new System.Collections.Generic.List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language()
                    {
                        id = 1,
                        Value = "NEW REF PRODUCT",
                    }
                },
                type = "simple",
                link_rewrite = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                        {
                            new Bukimedia.PrestaSharp.Entities.AuxEntities.language()
                            {
                                id = 1,
                                Value = Bukimedia.PrestaSharp.Lib.Functions.GetLinkRewrite("new ref1")
                            },


                        },
                },
            new Bukimedia.PrestaSharp.Entities.product()
            {
                reference ="NEWREF2",
                name = new System.Collections.Generic.List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                {
                    new Bukimedia.PrestaSharp.Entities.AuxEntities.language()
                    {
                        id = 1,
                        Value = "NEW REF PRODUCT2",
                    }
                },
                type = "simple",
                link_rewrite = new List<Bukimedia.PrestaSharp.Entities.AuxEntities.language>()
                        {
                            new Bukimedia.PrestaSharp.Entities.AuxEntities.language()
                            {
                                id = 1,
                                Value = Bukimedia.PrestaSharp.Lib.Functions.GetLinkRewrite("new ref2")
                            },


                        },
                }
            };
            var response = factory.AddList(inputProducts);

            ClassicAssert.IsTrue(response != null);
            ClassicAssert.IsTrue(response.Count == 2);
            ClassicAssert.IsTrue(response.ElementAt(0).id.HasValue);
        }
    }
}