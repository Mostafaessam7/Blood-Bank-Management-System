using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DBContext
{
    public class DonorTbl
    {
        [Key]
        public string NID { get; set; }
        public string DName { get; set; }
        public int DAge { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DNum { get; set; }
        public string DGender {  get; set; }
        public string DPhone { get; set; }

        public string DAddress{ get; set; }
        [ForeignKey("bloodTbl")]
        public string DBGroup { get; set; }
        public BloodTbl? bloodTbl { get; set; }


    }
}
