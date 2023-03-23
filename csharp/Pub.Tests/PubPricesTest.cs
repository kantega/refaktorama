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
        public void OneBeer()
        {
            int actualPrice = pub.ComputeCost(Pub.OneBeer, false, 1);
            Assert.AreEqual(74, actualPrice);
        }

        [Test]
        [Description("When we order one cider, then the price is 103 kr.")]
        public void CidersAreCostly()
        {
            int actualPrice = pub.ComputeCost(Pub.OneCider, false, 1);
            Assert.AreEqual(103, actualPrice);
        }

        [Test]
        [Description("When we order a proper cider, then the price is 110 kr.")]
        public void ProperCidersAreEvenMoreExpensive()
        {
            int actualPrice = pub.ComputeCost(Pub.AProperCider, false, 1);
            Assert.AreEqual(110, actualPrice);
        }

        [Test]
        [Description("When we order a gin and tonic, then the price is 115 kr.")]

        public void ACocktail()
        {
            int actualPrice = pub.ComputeCost(Pub.GT, false, 1);
            Assert.AreEqual(115, actualPrice);
        }

        [Test]
        [Description("When we order a bacardi special, then the price is 127 kr.")]

        public void BacardiSpecial()
        {
            int actualPrice = pub.ComputeCost(Pub.BacardiSpecial, false, 1);
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

            public void StudentsGetADiscountForBeer()
            {
                int actualPrice = pub.ComputeCost(Pub.OneBeer, true, 1);
                Assert.AreEqual(67, actualPrice);
            }

            [Test]
            [Description("When they order multiple beers, they also get a discount.")]

            public void StudentsGetDiscountsWhenOrderingMoreThanOneBeer()
            {
                int actualPrice = pub.ComputeCost(Pub.OneBeer, true, 2);
                Assert.AreEqual(67 * 2, actualPrice);
            }

            [Test]
            [Description("When they order a cocktail, they do not get a discount.")]

            public void StudentsDoNotGetDiscountsForCocktails()
            {
                int actualPrice = pub.ComputeCost(Pub.GT, true, 1);
                Assert.AreEqual(115, actualPrice);
            }
        }

        [Test]
        [Description("When they order a drink which is not on the menu, then they are refused.")]
        public void ADrinkNotInTheSortimentGivesError()
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

            public void CanBuyAtMostTwoDrinksInOneGo()
            {
                Assert.Throws<Exception>(() => pub.ComputeCost(Pub.BacardiSpecial, false, 3));
            }

            [Test]
            [Description("and the order is for beers, then they are served.")]

            public void CanOrderMoreThanTwoBeers()
            {
                pub.ComputeCost(Pub.OneBeer, false, 5);
            }
        }
    }
}
