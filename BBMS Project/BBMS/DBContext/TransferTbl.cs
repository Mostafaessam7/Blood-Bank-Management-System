using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBMS.DBContext
{
    public class TransferTbl
    {
       public int  TNum { get; set; }
     
       public string PName { get; set; }
       

        [ForeignKey("bloodTbl")]
        public string PBGroup { get; set; }
        public BloodTbl bloodTbl { get; set; }
        
    }
}
