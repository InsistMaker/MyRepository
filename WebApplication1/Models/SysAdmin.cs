using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class SysAdmin
    {
        public int LoginId { get; set; }
        public String AdminName { get; set; }
        public String LoginPwd { get; set; }
    }
}
