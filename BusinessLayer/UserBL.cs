using DataAcessLayer;
using Props1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBL
    {
        UserDAL dal= new UserDAL();
        public bool RegisterUser(UserProps up)
        {
            return dal.RegisterUser(up);
        }
    }
}
