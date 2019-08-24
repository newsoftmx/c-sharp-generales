using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje_2.Models
{
    public class Session : Controller
    {
        //
        // GET: /Session/

        public Int32 SessionID { get; set; }
        public string Title { get; set; }
        [Required()]
        [DataType(DataType.MultilineText)]
        public string Abstract { get; set; }
        public Int32 SpeakerID { get; set; }
        public virtual Speaker Speaker { get; set; }
    }
}
