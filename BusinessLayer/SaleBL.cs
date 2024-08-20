using DataAcessLayer;
using Props1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SaleBL
    {
        SaleDAL dal = new SaleDAL();
        public bool SaleInsert(SaleProps p)
        {
            return dal.SaleInsert(p);
        }
        public DataTable SaleSearchAll()
        {
            return dal.SaleSearchAll();
        }

        public int getReceipt()
        {
            return dal.getReceipt();
        }
    }
}
