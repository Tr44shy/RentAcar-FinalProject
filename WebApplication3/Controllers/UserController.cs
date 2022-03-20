using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.ViewModels;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
   
        [HttpGet]
        public ActionResult Userview() {
            return View();
        }

        [HttpPost]
        public ActionResult Userview(UserViewModel model) {
            if (!ModelState.IsValid) {
                return View(model);
            }
            using (var db= new RentAcarEntities1()) {
                User Ouser = new User();
                Ouser.User1 = model.Email;
                Ouser.Password = model.Password;

                db.Users.Add(Ouser);
                db.SaveChanges();


            }
            return Redirect(Url.Content("~/Access/Index"));
        }
    }
}