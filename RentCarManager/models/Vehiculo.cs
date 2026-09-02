using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCarManager.models
{
   public class Vehiculo
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public String Marca { get; set; }
        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]
        [Range(1900,2100)]
        public int Anio { get; set; }
        [Required]
        [StringLength(10)]
        public string placa { get; set; }
        [Required]
        [StringLength(50)]
        public string TipoVehiculo { get; set; }
        [Required]
        [Range(0.1, 100000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TarifaPorDia { get; set; }
        [Required(ErrorMessage = "el estado es obligatorio")]
        [StringLength(25)]
        public string estado { get; set; } /* pendiente para cambiar de string a 
                                                     * enum para majenar los estados                                                                                    
                                                     */
    }
}
