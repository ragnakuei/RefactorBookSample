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
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + Name + "\n";
            foreach (Rental each in rentals)
            {
                var thisAmount = each.GetCharge();
                result += "\t" + each.RentalMovie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }

            result += "Amount owed is " + totalAmount + "\n";
            result += "You earned " + GetFrequentReterpoints() + " frequent renter points\n";

            return result;
        }

        private int GetFrequentReterpoints()
        {
            int frequentRenterPoints = 0;
            foreach (Rental each in _rentals)
                frequentRenterPoints += each.GetFrequentRenterPoints();

            return frequentRenterPoints;
        }
    }
}