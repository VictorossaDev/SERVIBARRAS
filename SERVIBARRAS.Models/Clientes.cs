// Dependiente -- Clientes
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SERVIBARRAS.Models
{
    public class Clientes
    {
        [Key]
       [Column("ClienteId")]
       public int ClienteId { get; set; }

        [Required(ErrorMessage = "El RazonSocial es obligatorio")]
        [Display(Name = "RazonSocial")]
        [StringLength(400)]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El Nit es obligatorio")]
        [Display(Name = "Nit")]
        [StringLength(200)]
        public string Nit { get; set; }

        [Required(ErrorMessage = "El Direccion es obligatorio")]
        [Display(Name = "Direccion")]
        [StringLength(400)]
        public string Direccion { get; set; }

        [Display(Name = "FechaIngreso")]
        public DateTime? FechaIngreso { get; set; }

        [Required(ErrorMessage = "El CiudadId es obligatorio")]
        [Display(Name = "CiudadId")]
        public int CiudadId { get; set; }

        [Required(ErrorMessage = "El VendedorId es obligatorio")]
        [Display(Name = "VendedorId")]
        public int VendedorId { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        [Display(Name = "Email")]
        [StringLength(400)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El Cupo es obligatorio")]
        [Display(Name = "Cupo")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cupo { get; set; }

        [Required(ErrorMessage = "El Plazo es obligatorio")]
        [Display(Name = "Plazo")]
        public int Plazo { get; set; }

        [Required(ErrorMessage = "El TipoGranContribuyenteId es obligatorio")]
        [Display(Name = "TipoGranContribuyenteId")]
        public int TipoGranContribuyenteId { get; set; }

        [Required(ErrorMessage = "El Marca de Extranjero  es obligatorio")]
        [Display(Name = "MarcaDeExtranjero ")]
        public bool MarcaDeExtranjero  { get; set; }

         [ForeignKey("CiudadId")]
        public Ciudad Ciudad { get; set; }

        [ForeignKey("VendedorId")]
        public Vendedor Vendedor { get; set; }

        [ForeignKey("TipoGranContribuyenteId")]
        public TipoGranContribuyente TipoGranContribuyente { get; set; }


   }




}

