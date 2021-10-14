using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Magic_MateoMurillo.Models
{
    public class Suerte
    {
        [Key]
        public string FuturoId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Vision { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [Url]
        public string Imagen { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
    }
}
