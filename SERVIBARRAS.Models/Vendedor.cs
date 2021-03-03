// Independiente -- Vendedor
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// using SERVIBARRAS.Models.Enums;

namespace SERVIBARRAS.Models
{
    public class Vendedor
    {
        [Key]
       [Column("VendedorId")]
       public int VendedorId { get; set; }

        [Required(ErrorMessage = "El NombreVendedor es obligatorio")]
        [Display(Name = "NombreVendedor")]
        [StringLength(400)]
        public string NombreVendedor { get; set; }

 // ...

    }



}

