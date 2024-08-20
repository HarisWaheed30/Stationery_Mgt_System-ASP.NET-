using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Props1
{
    public class EmployeeProps
    {
        private string emp_id;
        private string emp_name;
        private string emp_cell;
        private decimal emp_salary;
        private string emp_address;

        public string Emp_id { get => emp_id; set => emp_id = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Emp_cell { get => emp_cell; set => emp_cell = value; }
        public string Emp_address { get => emp_address; set => emp_address = value; }
        public decimal Emp_salary { get => emp_salary; set => emp_salary = value; }
    }

    public class ProductProps
    {
        private string prod_id;
       private string prod_name;
       private string prod_description;
       private int prod_stock;
       private float prod_price;
        private string prod_category;

        public string Prod_id { get => prod_id; set => prod_id = value; }
        public string Prod_name { get => prod_name; set => prod_name = value; }
        public string Prod_description { get => prod_description; set => prod_description = value; }
        public int Prod_stock { get => prod_stock; set => prod_stock = value; }
        public float Prod_price { get => prod_price; set => prod_price = value; }
        public string Prod_category { get => prod_category; set => prod_category = value; }
    }

    public class CustomerProps
    {
        private string cust_id;
        private string cust_name;
        private string cust_cell;
        private string cust_address;
        private string cust_email;
        private string cust_membership_status;
        private string cust_membership_expirydate;

        public string Cust_id { get => cust_id; set => cust_id = value; }
        public string Cust_name { get => cust_name; set => cust_name = value; }
        public string Cust_cell { get => cust_cell; set => cust_cell = value; }
        public string Cust_address { get => cust_address; set => cust_address = value; }
        public string Cust_email { get => cust_email; set => cust_email = value; }
        public string Cust_membership_status { get => cust_membership_status; set => cust_membership_status = value; }
        public string Cust_membership_expirydate { get => cust_membership_expirydate; set => cust_membership_expirydate = value; }
    }

    public class SupplierProps
    {
        private string supp_id;
        private string supp_companyname;
        private string supp_cell;
        private string supp_address;
        private string supp_email;
        private string supp_contactperson;
        private string supp_productcategory;

        public string Supp_id { get => supp_id; set => supp_id = value; }
        public string Supp_companyname { get => supp_companyname; set => supp_companyname = value; }
        public string Supp_cell { get => supp_cell; set => supp_cell = value; }
        public string Supp_address { get => supp_address; set => supp_address = value; }
        public string Supp_email { get => supp_email; set => supp_email = value; }
        public string Supp_contactperson { get => supp_contactperson; set => supp_contactperson = value; }
        public string Supp_productcategory { get => supp_productcategory; set => supp_productcategory = value; }
    }

    }
