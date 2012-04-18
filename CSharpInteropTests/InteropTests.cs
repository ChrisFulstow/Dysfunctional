using System;
using NUnit.Framework;

namespace CSharpInteropTests
{
    [TestFixture]
    public class InteropTests
    {
        [Test]
        public void Tests()
        {
            var startDate = DateTime.Parse("1 Jan 2011");
            var endDate = DateTime.Parse("31 Dec 2011");

            var dateRange = new FSharpLibrary.DateRange();
            var dates = dateRange.DateRange(startDate, endDate);
            var weekends = dateRange.Weekends(dates);

            foreach (var dateTime in weekends)
            {
                Console.WriteLine(dateTime);
            }
        }
    }
}
