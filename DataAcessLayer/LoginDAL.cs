using DataAccessLayer;
using Props1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class LoginDAL
    {
        dbCon db = new dbCon();

        public DataTable Login(LoginProps lp)
        {
            //
            //for practice

            // String query = "select accesslvl from users where ulogin ='" + lp.Uname + "' AND upass ='" + lp.Upass + "' AND status ='offline'";

             String query = "select accesslvl, status from users where ulogin ='" + lp.Uname + "' AND upass ='" + lp.Upass + "'";  
            return db.Search(query);


        }
        public bool UpdateStatus(string status, LoginProps lp)
        {
           
            string query = "UPDATE Users SET status = '"+status+"' WHERE ulogin ='"+lp.Uname+"' ";
            return db.UDI(query);
        }
    }
}
