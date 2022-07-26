using Microsoft.AspNetCore.Mvc;

namespace Assignment_26_SM.Controllers
{
    public class EmployeeController : Controller
    {
        //GET: EmployeeController1
        public ActionResult Index()
        {
            return View();
        }

        //GET: EmployeeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Employeepage()
        {
            return View();
        }
        //GET: EmployeeController1/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}