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
    }
}