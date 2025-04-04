using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APPRESTAURANTE.Models
{
    public class M_Mesa
    {

        [Required(ErrorMessage = "EL id de la mesa es requerido")]
        [Display(Name = "ID de Mesa")]
        public int id { get; set; }

        [Required(ErrorMessage = "El numero de la mesa es requerido")]
        [Display(Name = "Numero de Mesa")]

        [MinLength(1, ErrorMessage = "El numero de mesa debe contener un total menor o igual a 1 caracteres")]
        public int numero_mesa { get; set; }

        [Required(ErrorMessage = "La descripcion de la mesa es requerido")]
        [Display(Name = "Descripcion de Mesa")]

        [MinLength(3, ErrorMessage = "La descripcion de la mesa debe contener un total menor o igual a 3 caracteres")]
        public string descripcion { get; set; }
    }
}