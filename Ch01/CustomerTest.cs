using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch01
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Statement_Childrens_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Childrens), 7);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t7.5\nAmount owed is 7.5\nYou earned 1 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statement_Childrens_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Childrens), 1);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t1.5\nAmount owed is 1.5\nYou earned 1 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statement_Regular_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Regular), 7);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t9.5\nAmount owed is 9.5\nYou earned 1 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statement_Regular_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Regular), 1);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t2\nAmount owed is 2\nYou earned 1 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statement_NewRelease_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.NewRelease), 7);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t21\nAmount owed is 21\nYou earned 2 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statement_NewRelease_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.NewRelease), 1);
            target.AddRental(rental);

            var actual = target.Statement();
            var expected = "Rental Record for Tom\n\tMovieA\t3\nAmount owed is 3\nYou earned 1 frequent renter points\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_Childrens_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Childrens), 7);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 7.5<BR>\n<P>You owe <EM>7.5</EM><P>\nOn this rental you earned <EM>1</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_Childrens_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Childrens), 1);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 1.5<BR>\n<P>You owe <EM>1.5</EM><P>\nOn this rental you earned <EM>1</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_Regular_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Regular), 7);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 9.5<BR>\n<P>You owe <EM>9.5</EM><P>\nOn this rental you earned <EM>1</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_Regular_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.Regular), 1);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 2<BR>\n<P>You owe <EM>2</EM><P>\nOn this rental you earned <EM>1</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_NewRelease_DaysRented_7()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.NewRelease), 7);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 21<BR>\n<P>You owe <EM>21</EM><P>\nOn this rental you earned <EM>2</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HtmlStatement_NewRelease_DaysRented_1()
        {
            var name = "Tom";
            var target = new Customer(name);
            var rental = new Rental(new Movie("MovieA", Movie.NewRelease), 1);
            target.AddRental(rental);

            var actual = target.HtmlStatement();
            var expected = "<H1>Rentals for <EM>Tom</EM></H1><P>\nMovieA: 3<BR>\n<P>You owe <EM>3</EM><P>\nOn this rental you earned <EM>1</EM> frequent renter points<P>";

            Assert.AreEqual(expected, actual);
        }
    }
}