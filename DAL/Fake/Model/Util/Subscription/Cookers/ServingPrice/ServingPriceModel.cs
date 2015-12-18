namespace DAL.Fake.Model.Util
{
    public class ServingPriceModel
    {
        public enum Values
        {
            Nine_DollarsNintyNine = 1,
            Fourteen_Dollars_NintyNine = 2,
            Ninteen_Dollars_NintyNine = 3

        }


        public double GetPrice(Values v)
        {
            switch (v)
            {
                case Values.Nine_DollarsNintyNine:
                    return 9.99;
                case Values.Fourteen_Dollars_NintyNine:
                    return 14.99;
                case Values.Ninteen_Dollars_NintyNine:
                    return 19.99;
                default:
                    return 0;

            }
        }
    }
}