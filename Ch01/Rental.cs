namespace Ch01
{
    public class Rental
    {
        public Movie RentalMovie { get; }
        public int DaysRented { get; }

        public Rental(Movie movie, int daysRented)
        {
            RentalMovie = movie;
            DaysRented = daysRented;
        }

        public double GetCharge()
        {
            double result = 0;
            switch (RentalMovie.PriceCode)
            {
                case Movie.Regular:
                    result += 2;
                    if (DaysRented > 2)
                    {
                        result += (DaysRented - 2) * 1.5;
                    }
                    break;
                case Movie.NewRelease:
                    result += DaysRented * 3;
                    break;
                case Movie.Childrens:
                    result += 1.5;
                    if (DaysRented > 3)
                        result += (DaysRented - 3) * 1.5;
                    break;
            }

            return result;
        }

        public int GetFrequentRenterPoints()
        {
            if ((RentalMovie.PriceCode == Movie.NewRelease) && (DaysRented > 1))
                return 2;
            return 1;
        }
    }
}