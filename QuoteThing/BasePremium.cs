


namespace QuoteThingTest
{
    public class BasePremium
    {
        private static System.Collections.Generic.Dictionary<string, double> _Table;

        static BasePremium()
        {
            _Table = new System.Collections.Generic.Dictionary<string, double>();
            _Table.Add("SingleTrip", 20.0);
            _Table.Add("AnnualTrip", 80.0);
        }

        private double basePremium;

        public BasePremium(string policyType)
        {
            this.basePremium = _Table[policyType];
        }

        public double GetBaseRating()
        {
            return this.basePremium;
        }
    }
}