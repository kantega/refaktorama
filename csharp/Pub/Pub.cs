namespace no.kantega
{
    public class Pub
    {
        public const String ONE_BEER = "hansa";
        public const String ONE_CIDER = "grans";
        public const String A_PROPER_CIDER = "strongbow";
        public const String GT = "gt";
        public const String BACARDI_SPECIAL = "bacardi_special";

        public int ComputeCost(String drink, bool student, int amount)
        {

            if (amount > 2 && (drink == GT || drink == BACARDI_SPECIAL))
            {
                throw new Exception("Too many drinks, max 2.");
            }
            int price;
            if (drink == ONE_BEER)
            {
                price = 74;
            }
            else if (drink == ONE_CIDER)
            {
                price = 103;
            }
            else if (drink == A_PROPER_CIDER) price = 110;
            else if (drink == GT)
            {
                price = ingredient6 + ingredient5 + ingredient4;
            }
            else if (drink == BACARDI_SPECIAL)
            {
                price = ingredient6 / 2 + ingredient1 + ingredient2 + ingredient3;
            }
            else
            {
                throw new Exception("No such drink exists");
            }
            if (student && (drink == ONE_CIDER || drink == ONE_BEER || drink == A_PROPER_CIDER))
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
