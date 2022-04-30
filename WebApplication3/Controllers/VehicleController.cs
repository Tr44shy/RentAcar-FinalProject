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
        private readonly RentAcarEntities1 db = new RentAcarEntities1();

        public ActionResult ViewVehicles(string option)
        {
            List<VehicleTableViewModel> lst = new List<VehicleTableViewModel>();

            if (string.IsNullOrWhiteSpace(option))
            {
                var vehiculos = db.Vehiculoes.ToList();

                foreach (var vehiculo in vehiculos)
                {
                    var vehicleVM = castearVehiculo(vehiculo);
                    lst.Add(vehicleVM);
                }

                return View(lst);
            }
            else
            {
                var vehiculos = db.Vehiculoes.Where(x => x.Estado == "Activo" && (x.Modelo == option
                                                                              || x.NPlaca == option
                                                                              || x.Marca == option
                                                                              || x.TipoDeVehiculo == option)).ToList();
                
                foreach (var vehiculo in vehiculos)
                {
                    var vehicleVM = castearVehiculo(vehiculo);
                    lst.Add(vehicleVM);
                }            

                return View(lst);
            }
        }

        public VehicleTableViewModel castearVehiculo(Vehiculo vehiculo)
        {
            return new VehicleTableViewModel
            {
                Descripcion = vehiculo.Descripcion,
                NPlaca = vehiculo.NPlaca,
                TipoDeVehiculo = vehiculo.TipoDeVehiculo,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo

            };
        }

      /**  [HttpGet]
        public ActionResult SearchbyModel(string option)
        {
           List<VehicleTableViewModel>
                   lst = (from d in db.Vehiculoes
                   where d.Estado == "Activo" & d.Modelo == option
                   select new VehicleTableViewModel
                   {
                       Descripcion = d.Descripcion,
                       NPlaca = d.NPlaca,
                       TipoDeVehiculo = d.TipoDeVehiculo,
                       Marca = d.Marca,
                       Modelo = d.Modelo

                   }).ToList();

            return View(lst);
        }**/
    }
}



       

           
           
    