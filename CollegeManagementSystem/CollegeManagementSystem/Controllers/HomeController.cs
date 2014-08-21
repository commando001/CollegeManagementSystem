using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CollegeManagementSystem.DAL;
using CollegeManagementSystem.ViewModels;

namespace CollegeManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private CollegeContext db = new CollegeContext(); //variable for the database context

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            //return View();


            IQueryable<EnrollmentDateGroup> data = from student in db.Students
                                                   group student by student.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
            return View(data.ToList());

            /* groups student entities by enrollment date > stored into dateGroup
             * calculates the number of entities in each group (StudentCount = dateGroup.Count()
             * the result is stored in a collection of EnrollmentDateGroup view model objects*/
        }

        //code for disposing the database to free up memory
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}