namespace Lab4HotelReservation
{
    public static class PriceCalculator
    {       
        public static decimal GetTotalPrice(decimal pricePerDay, int numbersOfDay,Season season, Discount discount)
        {
            decimal priceBeforDiscount = pricePerDay * numbersOfDay * (int)season; 
            decimal discountAmount = priceBeforDiscount*(decimal)discount/100;
            decimal finalPrice = priceBeforDiscount - discountAmount;
            return finalPrice;
        }
    }
}
