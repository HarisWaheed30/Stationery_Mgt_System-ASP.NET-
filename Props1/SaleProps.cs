using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Props1
{
    public class SaleProps
    {
       private int quantity;
       private DateTime date;
        private string soldby;

        public int Quantity { get => quantity; set => quantity = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Soldby { get => soldby; set => soldby = value; }
    }
}
