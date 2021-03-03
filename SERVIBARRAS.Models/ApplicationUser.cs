using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SERVIBARRAS.Models
{
    // Cuando se genere el proyecto crear una nueva migracion para que estos campos sean añadidos a la tabla
    // Se añaden estos campos a la tabla Identity ya que no los tiene y estamos heredando de ella
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        public string  Direccion { get; set; }
        [Required(ErrorMessage = "La ciudad es obligatorio")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "EL país es obligatorio")]
        public string Pais { get; set; }
    }
}