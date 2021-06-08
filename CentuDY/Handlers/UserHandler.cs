using CentuDY.Models;
using CentuDY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handlers
{
    public class UserHandler
    {
        public static List<ViewUser> getAllUser()
        {
            return UserRepository.getAllUser();
        }

        public static bool insertUser(String username, String password, String name, String gender, String phoneNumber, String address)
        {
            User existUser = UserRepository.getUserByUsername(username);

            if (existUser != null)
            {
                return false;
            }
            else
            {
                UserRepository.insertUser(username, password, name, gender, phoneNumber, address);
                return true;
            }

        }

        public static User getUser(String username, String password)
        {
            User user = UserRepository.getUser(username, password);

            if (user != null)return user;
            else return null;
            
        }
        public static User getUserById(int userId)
        {
            User user = UserRepository.getUserById(userId);
            if (user != null) return user;
            else return null;
        }

        public static bool deleteUser(int userId)
        {
            User user = UserRepository.getUserById(userId);

            if (user == null) return false;
            UserRepository.deleteUser(userId);
            return true;
        }

        public static bool updateProfile(int userId, String name, String gender, String phoneNumber, String address)
        {
            User user = UserRepository.getUserById(userId);

            if (user == null) return false;
            UserRepository.updateProfile(userId, name, gender, phoneNumber, address);
            return true;
        }

        public static bool updatePassword(int userId,String oldPassword, String newPassword)
        {
            User user = UserRepository.getUserById(userId);
            
            if (user == null) return false;
            else if (!user.Password.Equals(oldPassword)) return false;

            UserRepository.updatePassword(userId, newPassword);
            return true;
        }

    }
}