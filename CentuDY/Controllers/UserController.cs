using CentuDY.Handlers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Web;

namespace CentuDY.Controllers
{
    public class UserController
    {
        public static List<ViewUser> getAllUser()
        {
            return UserHandler.getAllUser();
        }

        private static String validateProfile(String name, String gender, String phoneNumber, String address)
        {
            ulong phone;
            String message;
            if (name.Equals(""))
            {
                message = "name cannot be empty";
            }
            else if (gender.Equals(""))
            {
                message = "gender must be chosen";
            }
            else if (phoneNumber.Equals(""))
            {
                message = "phone number cannot be empty";
            }
            else if (!ulong.TryParse(phoneNumber, out phone))
            {
                message = "phone number must be numeric";
            }
            else if (address.Equals(""))
            {
                message = "address cannot be empty";
            }
            else if (!address.Contains("Street"))
            {
                message = "address must contain Street";
            }
            else
            {
                message = "";
            }
            return message;
        }

        public static String validatePassword(String password, String confirmPassword)
        {
            String message;
            if (password.Equals(""))
            {
                message = "password cannot be empty";
            }
            else if (password.Length < 8)
            {
                message = "password minimum length is 8 character";
            }
            else if (confirmPassword.Equals(""))
            {
                message = "confirm password cannot be empty";
            }
            else if (!password.Equals(confirmPassword))
            {
                message = "password must match with confirm password";
            }
            else
            {
                message = "";
            }
            return message;

        }

        public static String changePassword(String userId, String oldPassword, String newPassword, String confirmPassword)
        {
            String message;

            if(oldPassword.Equals(""))
            {
                message = "old password cannot be empty";
            }
            else if (oldPassword.Equals(newPassword))
            {
                message = "old password cannot be the same as new password";
            }
            else {
                message = validatePassword(newPassword, confirmPassword);
                if (!message.Equals("")) return message;

                bool updatePassword = UserHandler.updatePassword(Int32.Parse(userId),oldPassword, newPassword);

                if (updatePassword) message = "";
                else message = "incorrect old password or user not exist";
            }
            return message;
        }

        public static String insertUser(String username, String password, String confirmPassword, String name, String gender, String phoneNumber, String address)
        {
            String message;

            if (username.Equals(""))
            {
                message = "Username cannot be empty";
            }
            else if(username.Length < 3)
            {
                message = "username minimum length is 3 character";
            }
            else
            {
                message = validateProfile(name, gender, phoneNumber, address);
                if (!message.Equals("")) return message;
                message = validatePassword(password, confirmPassword);
                if (!message.Equals("")) return message;
                
                bool isInserted = UserHandler.insertUser(username, password, name, gender, phoneNumber, address);

                if (!isInserted)
                {
                    message = "username exist";
                }
            }

            return message;
        }

        public static String updateProfile(String userId, String name, String gender, String phoneNumber, String address)
        {
            String message = validateProfile(name, gender, phoneNumber, address);

            if (message.Equals("")) { 
                bool isUpdated = UserHandler.updateProfile(Int32.Parse(userId), name, gender, phoneNumber, address);
            } 
            return message;
        }

        public static User getUserById(int id)
        {
           return UserHandler.getUserById(id);
        }

        public static bool deleteUser(String userId)
        {
            return UserHandler.deleteUser(Int32.Parse(userId));
        }
    }
}