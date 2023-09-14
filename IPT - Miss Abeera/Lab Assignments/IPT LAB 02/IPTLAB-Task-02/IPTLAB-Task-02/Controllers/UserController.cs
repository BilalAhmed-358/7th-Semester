using IPTLAB_Task_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPTLAB_Task_02.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult DisplayUserDetails()
        {
            List<UserModel> listuser = new List<UserModel>();
            UserModel users = new UserModel();
            users.UserName = "Devesh Umer";
            users.Age = 12;
            users.Gender = "M";
            listuser.Add(users);


            users = new UserModel();
            users.UserName = "Ram Kumar";
            users.Age = 12;
            users.Gender = "M";
            listuser.Add(users);



            return View(listuser);
        }
    }
}