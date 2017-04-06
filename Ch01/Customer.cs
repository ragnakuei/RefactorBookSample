using System.Collections.Generic;

namespace Ch01
{
    public class Customer
    {
        public string Name { get; }
        private readonly List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }

        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + Name + "\n";
            foreach (Rental each in rentals)
            {
                frequentRenterPoints++;

                if ((each.RentalMovie.PriceCode == Movie.NewRelease)
                    && (each.DaysRented > 1))
                    frequentRenterPoints++;

                var thisAmount = AmountFor(each);
                result += "\t" + each.RentalMovie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";

            return result;
        }

        private static double AmountFor(Rental rental)
        {
            double result = 0;
            switch (rental.RentalMovie.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (rental.DaysRented > 2)
                    {
                        result += (rental.DaysRented - 2) * 1.5;
                    }
                    break;
                case Movie.NewRelease:
                    result += rental.DaysRented * 3;
                    break;
                case Movie.Childrens:
                    result += 1.5;
                    if (rental.DaysRented > 3)
                        result += (rental.DaysRented - 3) * 1.5;
                    break;
            }

            return result;
        }
    }
}