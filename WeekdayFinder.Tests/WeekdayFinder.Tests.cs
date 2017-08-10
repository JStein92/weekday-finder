using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayFinderTests
  {
    [TestMethod]
    public void GetDayOfWeek_ReturnDayOfWeekOfToday_True()
    {
      //Arrange
      DateTime myDateTime = DateTime.Now;
      Weekday newWeekday = new Weekday(myDateTime);
      string expected = "Thursday";

      //Act
      string actual = newWeekday.GetDayOfWeek();

      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetDayOfWeek_ReturnAnyDayOfWeek_True()
    {
      //Arrange
      DateTime myDateTime = new DateTime(1978, 7, 7);
      Weekday newWeekday = new Weekday(myDateTime);
      string expected = "Friday";

      //Act
      string actual = newWeekday.GetDayOfWeek();

      //Assert
      Assert.AreEqual(expected, actual);
    }

  }
}
