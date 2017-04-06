namespace Ch01
{
    public class Movie
    {
        public const int Regular = 0;
        public const int NewRelease = 1;
        public const int Childrens = 2;

        public string Title { get; }
        public int PriceCode { get; private set; }

        public Movie(string title, int priceCode)
        {
            Title = title;
            PriceCode = priceCode;
        }

        public void SetPriceCode(int arg)
        {
            PriceCode = arg;
        }
    }
}
