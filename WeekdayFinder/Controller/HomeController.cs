using Microsoft.AspNetCore.Mvc;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinder.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/weekday")]
    public ActionResult Weekday()
    {
      DateTime newDateTime = DateTime.Parse(Request.Form["date"]);
      Weekday newWeekday = new Weekday(newDateTime);
      return View(newWeekday);
    }
    
  }
}
