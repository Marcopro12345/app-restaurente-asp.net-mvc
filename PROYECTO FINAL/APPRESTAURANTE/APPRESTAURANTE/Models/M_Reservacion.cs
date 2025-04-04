using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APPRESTAURANTE.Models
{
    public class M_Reservacion
    {

        [Required(ErrorMessage = "EL numero de la Reservación es requerido")]
        [Display(Name = "Numero de Reservación")]
        public int numero_reservacion { get; set; }

        [Required(ErrorMessage = "EL id del cliente es requerido")]
        [Display(Name = "ID del cliente")]
        [MinLength(1, ErrorMessage = "El id del cliente debe contener un total menor o igual a 1 carácter")]
        public Nullable<int> id_cliente { get; set; }

        [Required(ErrorMessage = "EL numero de Mesa es requerido")]
        [Display(Name = "Numero de Mesa")]
        [MinLength(1, ErrorMessage = "El numero de mesa debe contener un total menor o igual a 1 carácter")]
        public Nullable<int> numero_mesa { get; set; }

        [Required(ErrorMessage = "EL id del menú es requerido")]
        [Display(Name = "ID del Menú")]
        [MinLength(1, ErrorMessage = "El id del menú debe contener un total menor o igual a 1 carácter")]
        public Nullable<int> id_menu { get; set; }

        [Required(ErrorMessage = "La cantidad es requerido")]
        [Display(Name = "Cantidad")]

        [MinLength(1, ErrorMessage = "La Cantidad debe contener un total menor o igual a 1 carácter")]
        public int cantidad { get; set; }

        [Required(ErrorMessage = "La fecha de reservación es requerido")]
        [Display(Name = "Fecha de Reservación")]

        [MinLength(1, ErrorMessage = "La fecha de reservación debe contener un total menor o igual a 1 carácter")]
        public System.DateTime fecha_reservacion { get; set; }
    }
}