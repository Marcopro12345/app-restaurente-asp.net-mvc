using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APPRESTAURANTE.Models
{
    public class M_Menu
    {


        [Required(ErrorMessage = "EL id del Menú es requerido")]
        [Display(Name = "ID del Menú")]
        public int id { get; set; }

        [Required(ErrorMessage = "El pedido es requerido")]
        [Display(Name = "Pedido")]

        [MinLength(3, ErrorMessage = "El pedido debe contener un total menor o igual a 3 caracteres")]
        public string descripcion { get; set; }


        [Required(ErrorMessage = "El precio es requerido")]
        [Display(Name = "Precio")]

        [MinLength(3, ErrorMessage = "El precio debe contener un total menor o igual a 3 caracteres")]
        
        public decimal precio { get; set; }

        



        
    }
}