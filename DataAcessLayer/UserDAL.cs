using DataAccessLayer;
using Props1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class UserDAL
    {
        dbCon db = new dbCon();

        public bool RegisterUser(UserProps up)
        {
            string query = "Insert into Users values('" + up.Uname + "','" + up.Upass + "','" + up.Status + "','" + up.Accesslvl + "')";
            return db.UDI(query);
        
        }
    }
}
