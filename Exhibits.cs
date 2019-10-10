using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JurassicWorld.Data
{
    public class Exhibits
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        [Display(Name= "Exhibits Name")]
        public string  EName { get; set; }
        [Display(Name = "Exhibits Head")]
        public string EHead{ get; set; }
    }
}
