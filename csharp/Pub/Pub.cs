namespace Pub
{
    public class Pub
    {
        public const string OneBeer = "hansa";
        public const string OneCider = "grans";
        public const string AProperCider = "strongbow";
        public const string Gt = "gt";
        public const string BacardiSpecial = "bacardi_special";

        public int ComputeCost(string drink, bool student, int amount)
        {

            if (amount > 2 && (drink == Gt || drink == BacardiSpecial))
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
            else if (drink == Gt)
            {
                price = Ingredient6 + Ingredient5 + Ingredient4;
            }
            else if (drink == BacardiSpecial)
            {
                price = Ingredient6 / 2 + Ingredient1 + Ingredient2 + Ingredient3;
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
        private int Ingredient1 { get; } = 65;

        //one unit of grenadine
        private int Ingredient2 { get; } = 10;

        //one unit of lime juice
        private int Ingredient3 { get; } = 10;

        //one unit of green stuff
        private int Ingredient4 { get; } = 10;

        //one unit of tonic water
        private int Ingredient5 { get; } = 20;

        //one unit of gin
        private int Ingredient6 { get; } = 85;
    }
}
