using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.TableViewModels;

namespace WebApplication3.Controllers
{
    public class RentController : Controller
    {
        private readonly RentAcarEntities1 db = new RentAcarEntities1();
        public ActionResult RentView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RentView(RentaTableViewModel model)
        {

           
                Renta renta = new Renta();
                renta.IDVehiculo = model.IDVehiculo;
                renta.IDCliente = model.IDCliente;
                renta.Fecha = model.Fecha;
                renta.Precio = model.Precio;

                db.Rentas.Add(renta);

                /**var vehiculo = db.Vehiculoes.Find(model.IDVehiculo);
                Vehiculo vehiculoModificado = new Vehiculo() { Estado = "Inactivo" };
                db.Entry(vehiculo).CurrentValues.SetValues(vehiculoModificado);**/

                db.SaveChanges();
          

            


            return Redirect(Url.Content("~/Rent/RentView"));
            /**Renta renta = new Renta()
            {
                IDVehiculo = idVehiculo,
               IDCliente = idC,
               Fecha = fecha,
                Precio = precio
            };
            **/



        }
    }
}