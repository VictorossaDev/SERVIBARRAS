using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SERVIBARRAS.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre para el slider")]
        [Display(Name = "Titulo Slider")]
        public string Titulo { get; set; }

        [Required]
        [Display(Name = "Contenido")]
        public string Contenido { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
    }
}