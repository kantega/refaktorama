namespace no.kantega
{
    public class Pub
    {
        public const string OneBeer = "hansa";
        public const string OneCider = "grans";
        public const string AProperCider = "strongbow";
        public const string GT = "gt";
        public const string BacardiSpecial = "bacardi_special";

        public int ComputeCost(string drink, bool student, int amount)
        {

            if (amount > 2 && (drink == GT || drink == BacardiSpecial))
            {
                throw new Exception("Too many drinks, max 2.");
            }
            int price;
            if (drink == OneBeer)
            {
                price = 74;
            }
            else if (drink == OneCider)
            {
                price = 103;
            }
            else if (drink == AProperCider) price = 110;
            else if (drink == GT)
            {
                price = ingredient6 + ingredient5 + ingredient4;
            }
            else if (drink == BacardiSpecial)
            {
                price = ingredient6 / 2 + ingredient1 + ingredient2 + ingredient3;
            }
            else
            {
                throw new Exception("No such drink exists");
            }
            if (student && (drink == OneCider || drink == OneBeer || drink == AProperCider))
            {
                price = price - price / 10;
            }
            return price * amount;
        }

        //one unit of rum
        private int ingredient1
        {
            get { return 65; }
        }

        //one unit of grenadine
        private int ingredient2
        {
            get { return 10; }
        }

        //one unit of lime juice
        private int ingredient3
        {
            get { return 10; }
        }

        //one unit of green stuff
        private int ingredient4
        {
            get { return 10; }
        }

        //one unit of tonic water
        private int ingredient5
        {
            get { return 20; }
        }

        //one unit of gin
        private int ingredient6
        {
            get { return 85; }
        }
    }
}
