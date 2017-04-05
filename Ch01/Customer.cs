using System.Collections.Generic;

namespace Ch01
{
    public class Customer
    {
        private readonly string _name;
        private List<Rental> _rentals = new List<Rental>();

        public Customer(string name)
        {
            _name = name;
        }

        public void addRental(Rental arg)
        {
            _rentals.Add(arg);
        }


        private string getName()
        {
            return _name;
        }

        public string statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + getName() + "\n";
            while (rentals.Count > 0)
            {
                double thisAmount = 0;
                Rental each = (Rental)rentals[0];

                switch (each.getMovie().getPriceCode())
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (each.GetDaysRented() > 2)
                        {
                            thisAmount += (each.GetDaysRented() - 2) * 1.5;
                        }
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += each.GetDaysRented() * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (each.GetDaysRented() > 3)
                            thisAmount += (each.GetDaysRented() - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if ((each.getMovie().getPriceCode() == Movie.NEW_RELEASE)
                    && (each.GetDaysRented() > 1))
                    frequentRenterPoints++;

                result += "\t" + each.getMovie().getTitle() + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is" + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";

            return result;


        }
    }
}