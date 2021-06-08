using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Models
{
    public class ViewCart
    {
        public int MedicineId { get; set; }
        public String MedicineName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int SubTotal { get; set; }
    }
}