namespace KISSPrinciple
{
    public class RestaurantBill
    {
        public decimal CalculateTotal(decimal[] prices, decimal tipPercentage)
        {
            decimal total = prices.Sum();
            total += (total * tipPercentage);

            return total;
        }
    }
}
