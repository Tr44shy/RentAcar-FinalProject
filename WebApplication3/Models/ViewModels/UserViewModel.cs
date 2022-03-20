﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electronico")]
        [StringLength(100,ErrorMessage ="El{0} debe tener al menos {1} caracter", MinimumLength = 1)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Las contraseñas no son iguales")]
        public string ConfirmPassword { get; set; }

    }
}