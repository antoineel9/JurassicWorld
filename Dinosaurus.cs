using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JurassicWorld.Data
{
    public class Dinosaurus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        public string DName { get; set; }
            [ForeignKey("EID")]
        public Exhibits ExhibitsId{ get; set; }


    }
}
