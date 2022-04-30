using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.TableViewModels;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {

        private readonly RentAcarEntities1 db = new RentAcarEntities1();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminView() 
        {

            return View();     
        }

        public ActionResult CarView()
        {
            List<VehicleTableViewModel2> lst = new List<VehicleTableViewModel2>();

            var vehiculos = db.Vehiculoes.ToList();

            foreach (var vehiculo in vehiculos)
            {
                var vehicleVM = castearVehiculo(vehiculo);
                lst.Add(vehicleVM);
            }

            return View(lst);
             
        }
        public VehicleTableViewModel2 castearVehiculo(Vehiculo vehiculo)
        {
            return new VehicleTableViewModel2
            {
                Id = vehiculo.Id,
                Descripcion = vehiculo.Descripcion,
                NChasis = (int)vehiculo.NChasis,
                NMotor = (int)vehiculo.NMotor,
                NPlaca = vehiculo.NPlaca,
                TipoDeVehiculo = vehiculo.TipoDeVehiculo,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                TipoDeCombustible = vehiculo.TipoDeCombustible,
                Estado = vehiculo.Estado             
            };
        }

        public ActionResult Enter(string user, string password) {

            try
            {
                using (RentAcarEntities1 db = new RentAcarEntities1())
                {

                    var lst = from d in db.Admins
                              where d.Usuario == user && d.Pass == password
                              select d;
                    if (lst.Count() > 0)
                    {

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