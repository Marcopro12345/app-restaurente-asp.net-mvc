using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APPRESTAURANTE.Models
{
    public class M_Cliente
    {
        [Required(ErrorMessage = "EL id de la cliente es requerido")]
        [Display(Name = "ID de cliente")]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        [Display(Name = "Nombre del cliente")]

        [MinLength(3, ErrorMessage = "El nombre del cliente debe contener un total menor o igual a 3 caracteres")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es requerido")]
        [Display(Name = "Apellido del cliente")]

        [MinLength(3, ErrorMessage = "El Apellido del cliente debe contener un total menor o igual a 3 caracteres")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El numero del cliente es requerido")]
        [Display(Name = "Numero del cliente")]

        [MinLength(8, ErrorMessage = "El Numero del cliente debe contener un total menor o igual a 8 caracteres")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "El correo del cliente es requerido")]
        [Display(Name = "Correo del cliente")]

        [MinLength(10, ErrorMessage = "El correo del cliente debe contener un total menor o igual a 10 caracteres")]
        public string correo_electronico { get; set; }
    }
}