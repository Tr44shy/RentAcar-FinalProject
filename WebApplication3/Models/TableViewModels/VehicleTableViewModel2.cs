using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models.TableViewModels
{
    public class VehicleTableViewModel2
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int NChasis { get; set; }
        public int NMotor { get; set; }
        public string NPlaca { get; set; }
        public string TipoDeVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoDeCombustible { get; set; }
        public string Estado { get; set; }
    }
}