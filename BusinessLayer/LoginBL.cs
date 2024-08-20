using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using Props1;

namespace BusinessLayer
{
    public class LoginBL
    {
        LoginDAL dal = new LoginDAL();

        public DataTable Login(LoginProps lp)
        {
            return dal.Login(lp);

        }
        public bool UpdateStatus(string status, LoginProps lp)
        {
            return dal.UpdateStatus(status, lp);
        }


        
    }
}
