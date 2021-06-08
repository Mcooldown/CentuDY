using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Models
{
    public class ViewUser
    {
        public int UserId { get; set; }
        public String Username { get; set; }
        public String Name { get; set; }
        public String Role { get; set; }
        public String Gender { get; set; }
        public String PhoneNumber { get; set; }
        public String Address { get; set; }
    }
}