using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCarManager.models
{
    public class Alquiler
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int ClienteId { get; set; } // llave foranea 
        public Cliente cliente { get; set; } // propiedad de navegacion

        public int VehiculoId { get; set; }
        public Vehiculo vehiculo { get; set; }
        [Required(ErrorMessage ="la fecha de salida es obligatoria")]
        [Column(TypeName = "datetime2")] // para mayor presicion en la base de datos
        public DateTime FechaSalida { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "la fecha de devolucion es obligatoria")]
        [Column(TypeName ="datetime2")]
        public  DateTime FechaDevolucionPrevista { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? FechaDevolucionReal { get; set; }
        [Required(ErrorMessage = "el monto debe ser valido")]
        [Range(0.00, 1000000.00)]
        [Column(TypeName ="decimal(18,2)")]
        public decimal MontoTotal { get; set; }
        public string EstadoAlquiler { get; set; }  /* pendiente para cambiar de string a 
                                                     * enum para majenar los estados                                                                                    
                                                     */

    }
}
