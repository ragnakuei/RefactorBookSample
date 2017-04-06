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
    }
}