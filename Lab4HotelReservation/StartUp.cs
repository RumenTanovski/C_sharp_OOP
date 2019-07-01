using System;
using System.Linq;

namespace Lab4HotelReservation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //input
            //50.25 5 Summer VIP
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal pricePerDay = decimal.Parse(input[0]);
            int days = int.Parse(input[1]);            
            Season season = (Season)Enum.Parse(typeof(Season), input[2]);
            Discount discount = Discount.None;

            if (input.Count() == 4)
            {
                discount = (Discount)Enum.Parse(typeof(Discount), input[3]);
            }

            decimal totalPrice =  PriceCalculator.GetTotalPrice(pricePerDay,days,season,discount);
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
