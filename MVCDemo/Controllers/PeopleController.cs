using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Samuel", LastName = "Lane", Age = 42 });
            people.Add(new PersonModel { FirstName = "Karen", LastName = "Lane", Age = 35 });
            people.Add(new PersonModel { FirstName = "Jalen", LastName = "Lane", Age = 14 });
            people.Add(new PersonModel { FirstName = "Jaliyah", LastName = "Lane", Age = 12 });


            return View(people);
        }
    }
}