using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarManager.models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public String Apellido { get; set; }
        [Required]
        [StringLength(15)]
        public string cedula { get; set; }
        [Required]
        [StringLength(15)]
        public String telefono { get; set; }
        [Required]
        [StringLength(15)]
        public string LicenciaConducir { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "el correo es obligatorio")]
        public string Correo { get; set; }
    }
}
