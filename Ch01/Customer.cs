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
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + Name + "\n";
            foreach (Rental each in rentals)
                result += "\t" + each.RentalMovie.Title + "\t" + each.GetCharge() + "\n";

            result += "Amount owed is " + GetTotalCharge() + "\n";
            result += "You earned " + GetFrequentReterpoints() + " frequent renter points\n";

            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
            foreach (Rental each in _rentals)
                result += each.GetCharge();

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