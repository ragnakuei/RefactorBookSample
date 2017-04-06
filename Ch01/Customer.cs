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

                var thisAmount = amountFor(each);
                result += "\t" + each.RentalMovie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";

            return result;
        }

        private static double amountFor(Rental each)
        {
            double thisAmount = 0;
            switch (each.RentalMovie.PriceCode)
            {
                case Movie.Regular:
                    thisAmount += 2;
                    if (each.DaysRented > 2)
                    {
                        thisAmount += (each.DaysRented - 2) * 1.5;
                    }
                    break;
                case Movie.NewRelease:
                    thisAmount += each.DaysRented * 3;
                    break;
                case Movie.Childrens:
                    thisAmount += 1.5;
                    if (each.DaysRented > 3)
                        thisAmount += (each.DaysRented - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }
    }
}