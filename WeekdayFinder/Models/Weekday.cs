using System;

namespace WeekdayFinder.Models
{
  public class Weekday
  {
    private DateTime _userDateTime;
    private string _userDayOfWeek;

    public Weekday(DateTime userDateTime)
    {
      _userDateTime = userDateTime;
    }

    public string GetDayOfWeek()
    {
      _userDayOfWeek = _userDateTime.DayOfWeek.ToString();
      return _userDayOfWeek;
    }
  }
}
