// Independiente -- TipoGranContribuyente
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// using SERVIBARRAS.Models.Enums;

namespace SERVIBARRAS.Models
{
    public class TipoGranContribuyente
    {
        [Key]
       [Column("TipoGranContribuyenteId")]
       public int TipoGranContribuyenteId { get; set; }

        [Required(ErrorMessage = "El NombreTipoGranContribuyente es obligatorio")]
        [Display(Name = "NombreTipoGranContribuyente")]
        [StringLength(400)]
        public string NombreTipoGranContribuyente { get; set; }

 // ...

    }



}

