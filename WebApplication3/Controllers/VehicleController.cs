using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.TableViewModels;

namespace WebApplication3.Controllers
{
    public class VehicleController : Controller
    {
        // GET: Vehicle

        public ActionResult ViewVehicles()
        {
            List<VehicleTableViewModel> lst = null;
            using (RentAcarEntities1 db = new RentAcarEntities1()) { 
                lst = (from d in db.Vehiculoes
                       where d.Estado == "Activo"
                       select new VehicleTableViewModel
                       {
                           Descripcion = d.Descripcion,
                           NPlaca = d.NPlaca,
                           TipoDeVehiculo = d.TipoDeVehiculo,
                           Marca = d.Marca,
                           Modelo = d.Modelo

                       }).ToList();

            }
                return View(lst);
        }

        public ActionResult Search(string option)
        {
            List<VehicleTableViewModel> lst = null;
           
                using (RentAcarEntities1 db = new RentAcarEntities1())
                {
                    lst = (from d in db.Vehiculoes
                           where d.Estado == "Activo" & d.Modelo == "option"
                           select new VehicleTableViewModel
                           {
                               Descripcion = d.Descripcion,
                               NPlaca = d.NPlaca,
                               TipoDeVehiculo = d.TipoDeVehiculo,
                               Marca = d.Marca,
                               Modelo = d.Modelo
                           }).ToList();
                }
            Console.WriteLine("hola");
            return View(lst);
            
              }
            
    }
}