using DAL;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendanceManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {

            List<Student> Students = new List<Student>();
            try
            {
                using (var unitOfWork = new UnitOfWork(new DBEntities()))
                {
                    Students = unitOfWork.Students.GetAll().OrderBy(x => x.Id).ToList();
                }

                ViewBag.Students = Students;
                return View();
            }

            catch (Exception ex)
            {
                return View("Error");
            }


        }
    }
}
