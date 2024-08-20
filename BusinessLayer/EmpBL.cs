using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Props1;

namespace BusinessLayer
{
    public class EmpBL
    {
        public bool EmpInsert(EmployeeProps p)
        {
            EmpDAL dal = new EmpDAL();
            return dal.EmpInsert(p);
        }

            public bool EmpUpdate(EmployeeProps p)
            {
                EmpDAL dal = new EmpDAL();
                return dal.EmpUpdate(p);
            }

            public bool EmpDelete(EmployeeProps p)
            {
                EmpDAL dal = new EmpDAL();
                return dal.EmpDelete(p);
            }

            public DataTable EmpSearch(EmployeeProps p)
            {
                EmpDAL dal = new EmpDAL();
                return dal.EmpSearch(p);
            }

            public DataTable EmpView()
            {
                EmpDAL dal = new EmpDAL();
                return dal.EmpView();
            }
        }
    public class CustBL
    {
        public bool CustInsert(CustomerProps cp)
        {
            CustDAL dal = new CustDAL();
            return dal.CustInsert(cp);
        }

        public bool CustUpdate(CustomerProps cp)
        {
            CustDAL dal = new CustDAL();
            return dal.CustUpdate(cp);
        }

        public bool CustDelete(CustomerProps cp)
        {
            CustDAL dal = new CustDAL();
            return dal.CustDelete(cp);
        }

        public DataTable CustSearch(CustomerProps cp)
        {
            CustDAL dal = new CustDAL();
            return dal.CustSearch(cp);
        }

        public DataTable CustView()
        {
            CustDAL dal = new CustDAL();
            return dal.CustView();
        }
    }

    public class ProdBL
    {
        public bool ProdInsert(ProductProps pr)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdInsert(pr);
        }

        public bool ProdUpdate(ProductProps pr)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdUpdate(pr);
        }

        public bool ProdUpdate1(ProductProps pr)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdUpdate1(pr);
        }

        public bool ProdDelete(ProductProps pr)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdDelete(pr);
        }

        public DataTable ProdSearch(ProductProps pr)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdSearch(pr);
        }
        public DataTable ProdNameSearch(ProductProps p)
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdNameSearch(p);

        }

        public DataTable ProdView()
        {
            ProdDAL dal = new ProdDAL();
            return dal.ProdView();
        }
    }

    public class SuppBL
    {
        public bool SuppInsert(SupplierProps sp)
        {
            SuppDAL dal = new SuppDAL();
            return dal.SuppInsert(sp);
        }

        public bool SuppUpdate(SupplierProps sp)
        {
            SuppDAL dal = new SuppDAL();
            return dal.SuppUpdate(sp);
        }

        public bool SuppDelete(SupplierProps sp)
        {
            SuppDAL dal = new SuppDAL();
            return dal.SuppDelete(sp);
        }

        public DataTable SuppSearch(SupplierProps sp)
        {
            SuppDAL dal = new SuppDAL();
            return dal.SuppSearch(sp);
        }

        public DataTable SuppView()
        {
            SuppDAL dal = new SuppDAL();
            return dal.SuppView();
        }
    }

}




