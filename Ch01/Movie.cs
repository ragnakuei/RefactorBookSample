using System;

namespace Ch01
{
    public class Movie
    {
        private Price _price;

        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Childrens = 2;

        public string Title { get; }

        public Movie(string title, int price)
        {
            Title = title;
            SetPriceCode(price);
        }

        public void SetPriceCode(int arg)
        {
            switch (arg)
            {
                case Regular:
                    _price = new RegularPrice();
                    break;
                case Childrens:
                    _price = new ChildrensPrice();
                    break;
                case NewRelease:
                    _price = new NewReleasePrice();
                    break;
                default:
                    throw new ArgumentException("Incorrect Price Code");
            }
        }

        public int GetPriceCode()
        {
            return _price.GetPriceCode();
        }

        public double GetCharge(int daysRented)
        {
            double result = 0;
            switch (GetPriceCode())
            {
                case Regular:
                    result += 2;
                    if (daysRented > 2)
                        result += (daysRented - 2) * 1.5;
                    break;
                case NewRelease:
                    result += daysRented * 3;
                    break;
                case Childrens:
                    result += 1.5;
                    if (daysRented > 3)
                        result += (daysRented - 3) * 1.5;
                    break;
            }

            return result;
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            if ((GetPriceCode() == NewRelease) && (daysRented > 1))
                return 2;
            return 1;
        }
    }


}
