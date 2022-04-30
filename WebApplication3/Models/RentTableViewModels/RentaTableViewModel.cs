using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models.TableViewModels
{
    public class RentaTableViewModel
    {
        
        [Required]
        public int IDVehiculo { get; set; }
        [Required]
        public int IDCliente { get; set; }
        [Required]
        [DisplayName("Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }
        [Required]
        public long Precio { get; set; }
    }
}