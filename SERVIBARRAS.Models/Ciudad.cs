// Independiente -- Ciudad
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// using SERVIBARRAS.Models.Enums;

namespace SERVIBARRAS.Models
{
    public class Ciudad
    {
        [Key]
       [Column("CiudadId")]
       public int CiudadId { get; set; }

        [Required(ErrorMessage = "El NombreCiudad es obligatorio")]
        [Display(Name = "NombreCiudad")]
        [StringLength(300)]
        public string NombreCiudad { get; set; }

 // ...

    }



}

