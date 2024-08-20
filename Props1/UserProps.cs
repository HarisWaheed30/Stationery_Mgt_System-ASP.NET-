using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Props1
{
    public class UserProps
    {
        private string uname, upass, status;
        private int accesslvl;

        public string Uname { get => uname; set => uname = value; }
        public string Upass { get => upass; set => upass = value; }

        public string Status { get => status; set => status = value; }
        public int Accesslvl { get => accesslvl; set => accesslvl = value; }
    }
}
