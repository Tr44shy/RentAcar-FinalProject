using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public void Rentar(string idAuto, string idCliente, string fechaRenta, string precioRenta)
        {
            int idVehiculo = int.Parse(idAuto);
            int idC = int.Parse(idCliente);
            DateTime fecha = DateTime.Parse(fechaRenta);
            double precio = double.Parse(precioRenta);

            //Rentaes renta = new Rentaes(
            //{
            //    idVehiculo = idVehiculo,
            //    idCliente = idC,
            //    fecha = fecha,
            //    precio = precio
            //});

            //db.Rentaes.Add(renta);

            var vehiculo = db.Vehiculoes.Find(idVehiculo);
            Vehiculo vehiculoModificado = new Vehiculo(){ Estado = "Inactivo"};
            db.Entry(vehiculo).CurrentValues.SetValues(vehiculoModificado);

            db.SaveChanges();
        }
    }
}