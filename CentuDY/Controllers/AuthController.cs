using CentuDY.Handlers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controllers
{
    public class AuthController
    {
        public static User auth()
        {
            HttpContext context = HttpContext.Current;

            if (context.Session["user"] == null)
            {
                return null;
            }
            else
            {
                User user = (User)(context.Session["user"]);
                return user;
            }
        }

        public static User userFromCookie()
        {
            HttpContext context = HttpContext.Current;

            if (context.Request.Cookies["user_id"] == null)
            {
                return null;
            }
            else
            {
                var id = context.Request.Cookies["user_id"].Value;
                User user = UserController.getUserById(Int32.Parse(id));
                return user;
            }
        } 

        public static String login(String username, String password, bool cookieCheck)
        {
            User user = UserHandler.getUser(username, password);

            String message;
            if (user != null)
            {
                HttpContext context = HttpContext.Current;
                context.Session.Add("user", user);
                if (cookieCheck)
                {
                    HttpCookie cookie = new HttpCookie("user_id");
                    cookie.Value = user.UserId.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    context.Response.Cookies.Add(cookie);
                }
                message = "";
            }
            else
            {
                message = "Invalid username or password";
            }

            return message;
        }

        public static void logout()
        {
            HttpContext context = HttpContext.Current;
            context.Session.Remove("user");
            context.Response.Cookies["user_id"].Expires = DateTime.Now.AddDays(-1);
        }

        public static bool isAdmin()
        {
            User user = (User)HttpContext.Current.Session["user"];
            if (user.RoleId == 1) return true;
            else return false;
        }

        public static bool isUser()
        {
            User user = (User)HttpContext.Current.Session["user"];
            if (user.RoleId == 2) return true;
            else return false;
        }
    }
}