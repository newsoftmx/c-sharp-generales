using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace mvcAprendizaje_2.Models
{
    public class Speaker
    {
        public Int32 SpeakerID { get; set; }
        //[Required(ErrorMessage="El campo boina es requerido")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Speaker name")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name="Email")]
        public String EmailAddress { get; set; }
        //La sig linea es para hacer una carga diferida
        //deshabilito esto al hacer las vistas
        //public virtual List<Session> Sessions { get; set; }

    }
    /*public class SpeakerMetadata
    {
        [Required()]
        public Object Name { get; set; }
    }*/
}
