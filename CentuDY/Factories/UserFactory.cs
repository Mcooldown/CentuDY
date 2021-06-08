using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factories
{
    public class UserFactory
    {
        public static User createUser(String username, String password, String name, String gender, String phoneNumber, String address)
        {
            return new User { 
                RoleId = 2,
                Username = username,
                Password = password,
                Name = name,
                Gender = gender,
                PhoneNumber = phoneNumber,
                Address = address,
            };
        }
    }
}