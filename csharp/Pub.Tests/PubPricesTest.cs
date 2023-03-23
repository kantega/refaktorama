using NUnit.Framework;

namespace Pub.Tests
{

    [Description("Pub spec")]
    [TestFixture]
    public class PubPricesTest
    {

        private Pub pub;

        [SetUp]
        public void Init()
        {
            pub = new Pub();
        }

        [Description("When we order one beer, then the price is 74 kr.")]
        [Test]
        public void OneBeerTest()
        {
            var actualPrice = pub.ComputeCost(Pub.OneBeer, false, 1);
            Assert.That(actualPrice, Is.EqualTo(74));
        }

        [Test]
        [Description("When we order one cider, then the price is 103 kr.")]
        public void TestCidersAreCostly()
        {
            var actualPrice = pub.ComputeCost(Pub.OneCider, false, 1);
            Assert.That(actualPrice, Is.EqualTo(103));
        }

        [Test]
        [Description("When we order a proper cider, then the price is 110 kr.")]
        public void TestProperCidersAreEvenMoreExpensive()
        {
            var actualPrice = pub.ComputeCost(Pub.AProperCider, false, 1);
            Assert.That(actualPrice, Is.EqualTo(110));
        }

        [Test]
        [Description("When we order a gin and tonic, then the price is 115 kr.")]

        public void TestACocktail()
        {
            var actualPrice = pub.ComputeCost(Pub.Gt, false, 1);
            Assert.That(actualPrice, Is.EqualTo(115));
        }

        [Test]
        [Description("When we order a bacardi special, then the price is 127 kr.")]

        public void TestBacardiSpecial()
        {
            var actualPrice = pub.ComputeCost(Pub.BacardiSpecial, false, 1);
            Assert.That(actualPrice, Is.EqualTo(127));
        }

        [TestFixture]
        [Description("Given a customer who is a student")]
        public class Students
        {

            private Pub pub;

            [SetUp]
            public void Init()
            {
                pub = new Pub();
            }

            [Test]
            [Description("When they order a beer, then they get a discount.")]

            public void TestStudentsGetADiscountForBeer()
            {
                var actualPrice = pub.ComputeCost(Pub.OneBeer, true, 1);
                Assert.That(actualPrice, Is.EqualTo(67));
            }

            [Test]
            [Description("When they order multiple beers, they also get a discount.")]

            public void TestStudentsGetDiscountsWhenOrderingMoreThanOneBeer()
            {
                var actualPrice = pub.ComputeCost(Pub.OneBeer, true, 2);
                Assert.That(actualPrice, Is.EqualTo(67 * 2));
            }

            [Test]
            [Description("When they order a cocktail, they do not get a discount.")]

            public void TestStudentsDoNotGetDiscountsForCocktails()
            {
                int actualPrice = pub.ComputeCost(Pub.Gt, true, 1);
                Assert.That(actualPrice, Is.EqualTo(115));
            }
        }

        [Test]
        [Description("When they order a drink which is not on the menu, then they are refused.")]
        public void TestThatADrinkNotInTheSortimentGivesError()
        {
            Assert.Throws<Exception>(() => pub.ComputeCost("sanfranciscosling", false, 1));
        }

        [TestFixture]
        [Description("When they order more than two drinks")]
        public class MultipleDrinks
        {
            private Pub pub;

            [SetUp]
            public void Init()
            {
                pub = new Pub();
            }

            [Test]
            [Description("and the order is for cocktails, then they are refused.")]

            public void TestCanBuyAtMostTwoDrinksInOneGo()
            {
                Assert.Throws<Exception>(() => pub.ComputeCost(Pub.BacardiSpecial, false, 3));
            }

            [Test]
            [Description("and the order is for beers, then they are served.")]

            public void TestCanOrderMoreThanTwoBeers()
            {
                pub.ComputeCost(Pub.OneBeer, false, 5);
            }
        }
    }
}
