using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> Students = new List<Student>();
            try
            {
                using (var unitOfWork = new UnitOfWork(new DBEntities()))
                {
                    Students = unitOfWork.Students.GetTop2Student(1).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}