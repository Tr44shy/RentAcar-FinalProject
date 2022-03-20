using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
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

        public ActionResult Enter(string user, string password)
        {
            try
            {
                using (RentAcarEntities1 db = new RentAcarEntities1()) {

                    var lst = from d in db.Users
                              where d.User1 == user && d.Password == password
                              select d;
                    if (lst.Count() > 0)
                    {
                        User oUser = lst.First();
                        Session["User"] = oUser;

                        return Content("1");
                    }
                    else 
                    {
                        return Content("Usuario invalido");
                    }
                }
    
            }
            catch (Exception e)
            {
                return Content("Ocurrio un error xd" + e.Message);
            }
        }
    }
}