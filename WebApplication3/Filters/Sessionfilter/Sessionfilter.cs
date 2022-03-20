using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Controllers;

namespace WebApplication3.Filters.Sessionfilter
{
    public class Sessionfilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var oUser = (User)HttpContext.Current.Session["User"];
            if (oUser == null)
            {
                if (filterContext.Controller is AccessController == false)
                {
                    if (filterContext.Controller is UserController == true)
                    {
                        base.OnActionExecuting(filterContext);
                    }
                    else
                    {
                        filterContext.HttpContext.Response.Redirect("~/Access/Index");
                    }

                }
            }
            else
            {
                if (filterContext.Controller is AccessController == true)
                {
                    if (filterContext.Controller is VehicleController == true)
                    {
                        base.OnActionExecuting(filterContext);
                    }
                    else
                    {
                        filterContext.HttpContext.Response.Redirect("~/Home/Index");
                    }


                }
            }



            base.OnActionExecuting(filterContext);
        }

    }
}