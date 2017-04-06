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

        public Price Price
        {
            set { _price = value; }
            get { return _price; }
        }

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
            return _price.GetCharge(daysRented);
        }
    }


}
