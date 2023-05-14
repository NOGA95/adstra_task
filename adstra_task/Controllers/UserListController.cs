using adstra_task.Data;
using adstra_task.Models;
using adstra_task.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adstra_task.Controllers
{
    [Authorize]
    public class UserListController : Controller
    {
        private readonly AuthDBContext context;

        public UserListController(AuthDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            try
            {
                var AllUsers = context.usersLists.ToList();
                
                return View(AllUsers);
            }
            catch
            {
                var error = "Error Message".ToString();
                return View(error);
            }



        }


        [HttpGet]
        public IActionResult Create()
        {

             return View();
        }
        //public IActionResult Create(UsersList model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new UsersList()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            PhoneNumber = model.PhoneNumber,
        //            Email = model.Email

        //        };
        //        context.usersLists.Add(user);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        TempData["error"] = "Empty Field Can't Submit";
        //        return View();
        //    }
        //}


        //public IActionResult Update(UsersList model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new UsersList()
        //        {
        //            FirstName = model.FirstName,
        //            LastName = model.LastName,
        //            PhoneNumber = model.PhoneNumber,
        //            Email = model.Email

        //        };
        //        context.usersLists.Update(user);
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        TempData["error"] = "Empty Field Can't Submit";
        //        return View();
        //    }
        //}
    }
}
