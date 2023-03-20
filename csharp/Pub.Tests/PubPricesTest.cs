using NUnit.Framework;

namespace no.kantega
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
        public void oneBeerTest()
        {
            int actualPrice = pub.computeCost(Pub.ONE_BEER, false, 1);
            Assert.AreEqual(74, actualPrice);
        }

        [Test]
        [Description("When we order one cider, then the price is 103 kr.")]
        public void testCidersAreCostly()
        {
            int actualPrice = pub.computeCost(Pub.ONE_CIDER, false, 1);
            Assert.AreEqual(103, actualPrice);
        }

        [Test]
        [Description("When we order a proper cider, then the price is 110 kr.")]
        public void testProperCidersAreEvenMoreExpensive()
        {
            int actualPrice = pub.computeCost(Pub.A_PROPER_CIDER, false, 1);
            Assert.AreEqual(110, actualPrice);
        }

        [Test]
        [Description("When we order a gin and tonic, then the price is 115 kr.")]

        public void testACocktail()
        {
            int actualPrice = pub.computeCost(Pub.GT, false, 1);
            Assert.AreEqual(115, actualPrice);
        }

        [Test]
        [Description("When we order a bacardi special, then the price is 127 kr.")]

        public void testBacardiSpecial()
        {
            int actualPrice = pub.computeCost(Pub.BACARDI_SPECIAL, false, 1);
            Assert.AreEqual(127, actualPrice);
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

            public void testStudentsGetADiscountForBeer()
            {
                int actualPrice = pub.computeCost(Pub.ONE_BEER, true, 1);
                Assert.AreEqual(67, actualPrice);
            }

            [Test]
            [Description("When they order multiple beers, they also get a discount.")]

            public void testStudentsGetDiscountsWhenOrderingMoreThanOneBeer()
            {
                int actualPrice = pub.computeCost(Pub.ONE_BEER, true, 2);
                Assert.AreEqual(67 * 2, actualPrice);
            }

            [Test]
            [Description("When they order a cocktail, they do not get a discount.")]

            public void testStudentsDoNotGetDiscountsForCocktails()
            {
                int actualPrice = pub.computeCost(Pub.GT, true, 1);
                Assert.AreEqual(115, actualPrice);
            }
        }

        [Test]
        [Description("When they order a drink which is not on the menu, then they are refused.")]
        public void testThatADrinkNotInTheSortimentGivesError()
        {
            Assert.Throws<Exception>(() => pub.computeCost("sanfranciscosling", false, 1));
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

            public void testCanBuyAtMostTwoDrinksInOneGo()
            {
                Assert.Throws<Exception>(() => pub.computeCost(Pub.BACARDI_SPECIAL, false, 3));
            }

            [Test]
            [Description("and the order is for beers, then they are served.")]

            public void testCanOrderMoreThanTwoBeers()
            {
                pub.computeCost(Pub.ONE_BEER, false, 5);
            }
        }
    }
}
