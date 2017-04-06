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
                result += "\t" + each.RentalMovie.Title + "\t" + each.RentalMovie.GetCharge(each.DaysRented) + "\n";

            result += "Amount owed is " + GetTotalCharge() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints() + " frequent renter points\n";

            return result;
        }

        public string HtmlStatement()
        {
            string result = "<H1>Rentals for <EM>" + Name + "</EM></H1><P>\n";
            foreach (Rental each in _rentals)
                result += each.RentalMovie.Title + ": " + each.RentalMovie.GetCharge(each.DaysRented) + "<BR>\n";

            result += "<P>You owe <EM>" + GetTotalCharge() + "</EM><P>\n";
            result += "On this rental you earned <EM>" + GetTotalFrequentRenterPoints() + "</EM> frequent renter points<P>";
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;
            foreach (Rental each in _rentals)
                result += each.RentalMovie.GetCharge(each.DaysRented);

            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int frequentRenterPoints = 0;
            foreach (Rental each in _rentals)
                frequentRenterPoints += each.RentalMovie.Price.GetFrequentRenterPoints(each.DaysRented, each.RentalMovie);

            return frequentRenterPoints;
        }
    }
}