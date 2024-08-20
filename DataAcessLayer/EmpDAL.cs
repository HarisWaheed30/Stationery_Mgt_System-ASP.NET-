using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Props1;


namespace DataAccessLayer
{
    public class EmpDAL
    {
        dbCon db = new dbCon();
        public bool EmpInsert(EmployeeProps p)
        {
            //string query = "Insert Into Employee Values('" + p.Emp_id + "','" + p.Emp_name + "','" + p.Emp_cell + "','" + p.Emp_address + "', '"+p.Emp_salary+"')";
            //return db.UDI(query);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Emp_id", p.Emp_id),
                new SqlParameter("@Emp_name", p.Emp_name),
                new SqlParameter("@Emp_cell", p.Emp_cell),
                new SqlParameter("@Emp_address", p.Emp_address),
                new SqlParameter("@Emp_salary", p.Emp_salary)
            };
            return db.ExecuteStoredProcedure(@"EmpInsertSP", parameters);
        }

        public bool EmpUpdate(EmployeeProps p)
        {
            //string query = "Update Employee Set name = '" + p.Emp_name + "', cell = '" + p.Emp_cell + "', address = '" + p.Emp_address + "', salary ='"+p.Emp_salary+"' Where empID = '" + p.Emp_id + "'";
            //return db.UDI(query);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Emp_id", p.Emp_id),
                new SqlParameter("@Emp_name", p.Emp_name),
                new SqlParameter("@Emp_cell", p.Emp_cell),
                new SqlParameter("@Emp_address", p.Emp_address),
                new SqlParameter("@Emp_salary", p.Emp_salary)
            };
            return db.ExecuteStoredProcedure("EmpUpdateSP", parameters);
        }

        public bool EmpDelete(EmployeeProps p)
        {
            //string query = "Delete Employee Where empID = '" + p.Emp_id + "'";
            //return db.UDI(query);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Emp_id", p.Emp_id)
            };
            return db.ExecuteStoredProcedure("EmpDeleteSP", parameters);
        }

        public DataTable EmpSearch(EmployeeProps p)
        {
            //string query = "Select * From Employee Where empID = '" + p.Emp_id + "'";
            //return db.Search(query);

            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@Emp_id", p.Emp_id)
           };
            return db.ExecuteStoredProcedureWithDataTable("EmpSearchSP", parameters);
        }

        public DataTable EmpView()
        {
            //string query = "Select * From Employee";
            //return db.Search(query);

            return db.ExecuteStoredProcedureWithDataTable("EmpViewSP", null);
        }
    }

    public class ProdDAL
    {
        dbCon db = new dbCon();
        public bool ProdInsert(ProductProps pr)
        {
            string query = "Insert Into Product Values('" + pr.Prod_id + "','" + pr.Prod_name + "','" + pr.Prod_description + "','" + pr.Prod_stock + "','"  +pr.Prod_price + "', '"  +pr.Prod_category + "')";
            return db.UDI(query);
        }

        public bool ProdUpdate(ProductProps pr)
        {
            string query = "Update Product Set name = '" + pr.Prod_name + "', description = '" + pr.Prod_description+ "', category = '" + pr.Prod_category + "', stock ='" + pr.Prod_stock + "', price ='" + pr.Prod_price + "' Where prodID = '" + pr.Prod_id + "'";
            return db.UDI(query);
        }
        public bool ProdUpdate1(ProductProps pr)
        {
            string query = "Update Product Set stock = '" + pr.Prod_stock + "' Where name = '" + pr.Prod_name + "'";
            return db.UDI(query);
        }

        public bool ProdDelete(ProductProps pr)
        {
            string query = "Delete Product Where prodID = '" + pr.Prod_id + "'";
            return db.UDI(query);
        }

        public DataTable ProdSearch(ProductProps pr)
        {
            string query = "Select * From Product Where prodID = '" + pr.Prod_id + "'";
            return db.Search(query);
        }
        public DataTable ProdNameSearch(ProductProps p)
        {
            string qry = "Select * From Product Where name = '" + p.Prod_name + "'";
            return db.Search(qry);
        }
        public DataTable ProdView()
        {
            string query = "Select * From Product";
            return db.Search(query);
        }
    }

    public class CustDAL
    {
        dbCon db = new dbCon();
        public bool CustInsert(CustomerProps cp)
        {
            string query = "Insert Into Customer Values('" + cp.Cust_id + "','" + cp.Cust_name + "','" + cp.Cust_cell + "','" + cp.Cust_email + "', '" + cp.Cust_address + "', '" + cp.Cust_membership_status + "', '"+cp.Cust_membership_expirydate+"')";
            return db.UDI(query);
        }

        public bool CustUpdate(CustomerProps cp)
        {
            string query = "Update Customer Set name = '" + cp.Cust_name + "', cell = '" + cp.Cust_cell+ "', email = '" + cp.Cust_email + "', address ='" + cp.Cust_address + "', membership_status ='" + cp.Cust_membership_status + "', membership_expiry_date'" + cp.Cust_membership_expirydate + "' Where custID = '" + cp.Cust_id + "'";
            return db.UDI(query);
        }

        public bool CustDelete(CustomerProps cp)
        {
            string query = "Delete Customer Where custID = '" + cp.Cust_id+ "'";
            return db.UDI(query);
        }

        public DataTable CustSearch(CustomerProps cp)
        {
            string query = "Select * From Customer Where custID = '" + cp.Cust_id + "'";
            return db.Search(query);
        }

        public DataTable CustView()
        {
            string query = "Select * From Customer";
            return db.Search(query);
        }
    }

    public class SuppDAL
    {
        dbCon db = new dbCon();
        public bool SuppInsert(SupplierProps sp)
        {
            string query = "Insert Into Supplier Values('" + sp.Supp_id + "','" + sp.Supp_companyname + "','" + sp.Supp_contactperson + "','" + sp.Supp_cell + "', '" + sp.Supp_address+ "', '" + sp.Supp_email + "', '" + sp.Supp_productcategory + "')";
            return db.UDI(query);
        }

        public bool SuppUpdate(SupplierProps sp)
        {
            string query = "Update Supplier Set company_name = '" + sp + "', cell = '" + sp.Supp_cell + "', email = '" + sp.Supp_email + "', address ='" + sp.Supp_address + "', contactperson ='" + sp.Supp_contactperson + "', product_category'" + sp.Supp_productcategory + "' Where custID = '" + sp.Supp_id + "'";
            return db.UDI(query);
        }

        public bool SuppDelete(SupplierProps sp)
        {
            string query = "Delete Supplier Where suppID = '" + sp.Supp_id + "'";
            return db.UDI(query);
        }

        public DataTable SuppSearch(SupplierProps sp)
        {
            string query = "Select * From Supplier Where suppID = '" + sp.Supp_id + "'";
            return db.Search(query);
        }

        public DataTable SuppView()
        {
            string query = "Select * From Supplier";
            return db.Search(query);
        }
    }

}

