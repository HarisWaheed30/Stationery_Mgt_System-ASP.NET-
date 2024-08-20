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
    public class SaleDAL
    {
        dbCon db = new dbCon();
        public bool SaleInsert(SaleProps p)
        {
            string query = "Insert Into Sales Values('" + p.Quantity + "','" + p.Date + "','" + p.Soldby + "')";
            return db.UDI(query);

        }
        public DataTable SaleSearchAll()
        {
            string qry = "Select * From Sales";
            return db.Search(qry);
        }

        public int getReceipt()
        {
            string qry = "SELECT ISNULL(MAX(reciept), 0) + 1  FROM Sales";
            return db.getIntNumber(qry);
        }

    }
}
