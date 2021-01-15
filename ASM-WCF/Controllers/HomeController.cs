
using ASM_WCF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM_WCF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "hello";


        }

        public ActionResult Contact()
        {
            ServiceClient client = new ServiceClient();

            // Use the 'client' variable to call operations on the service.
            var res = client.CreateStudent(new Student
            {
                Name = "Huy",
                Rollnumber ="A001",
                Birthday = DateTime.Now,
                Introduction = "hello",
                Genre = 1,
                Email = "hello@gamil.com"
                

            });
            // Always close the client.
            client.Close();

            return View();
        }
    }
}