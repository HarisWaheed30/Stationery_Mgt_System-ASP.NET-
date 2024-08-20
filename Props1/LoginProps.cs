using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Props1
{
    public class LoginProps
    {
        private string uname, upass;
       

        public string Uname { get => uname; set => uname = value; }
        public string Upass { get => upass; set => upass = value; }
        
       
    }
}
