using CentuDY.Factories;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repositories
{
    public class UserRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();

        public static List<ViewUser> getAllUser()
        {
            return (from x in db.Users 
                    join y in db.Roles on x.RoleId equals y.RoleId
                    where x.RoleId == 2 select new ViewUser{ 
                        UserId = x.UserId,
                        Username = x.Username,
                        Name = x.Name,
                        Role = y.RoleName,
                        Gender = x.Gender,
                        PhoneNumber = x.PhoneNumber,
                        Address = x.Address,
                    }).ToList();
        }
        public static void insertUser(String username, String password, String name, String gender, String phoneNumber, String address)
        {
            User user = UserFactory.createUser(username, password, name, gender, phoneNumber, address);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User getUserByUsername(String username)
        {
            return (from x in db.Users where x.Username == username select x).FirstOrDefault();
        }

        public static User getUserById(int id)
        {
            return (from x in db.Users where x.UserId == id select x).FirstOrDefault();
        }

        public static User getUser(String username, String password)
        {
            return (from x in db.Users where x.Username == username && x.Password == password select x).FirstOrDefault();
        }

        public static void updateProfile(int userId, String name, String gender, String phoneNumber, String address)
        {
            User user = getUserById(userId);
            user.Name = name;
            user.Gender = gender;
            user.PhoneNumber = phoneNumber;
            user.Address = address;
            db.SaveChanges();
        }

        public static void updatePassword(int userId, String password)
        {
            User user = getUserById(userId);
            user.Password = password;
            db.SaveChanges();
        }

        public static void deleteUser(int id)
        {
            User user = getUserById(id);
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}