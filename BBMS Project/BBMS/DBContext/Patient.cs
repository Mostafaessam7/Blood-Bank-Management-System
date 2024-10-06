using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DBContext
{
    public class Patient
    {
        [Key]
        public string NId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PNum { get; set; }
        public string PName { get; set; }
        public int PAge { get; set; }
        public string PGender { get; set; }
        public string PPhone { get; set; }

        public string PAddress { get; set; }
        [ForeignKey("bloodTbl")]
        public string PBGroup { get; set; }
        public BloodTbl bloodTbl { get; set; }
    }
}
