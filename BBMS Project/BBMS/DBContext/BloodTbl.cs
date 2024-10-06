using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DBContext
{
    public class BloodTbl
    {
        [Key]
        public string BGroup { get; set; }
        public int BStook { get; set; }
        public ICollection<DonorTbl>? Donors { get; set; } = new HashSet<DonorTbl>();
        public ICollection<Patient>? Patients { get; set; }= new HashSet<Patient>();
    }
}
