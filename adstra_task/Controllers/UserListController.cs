using adstra_task.Data;
using adstra_task.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Controllers
{
    public class UserListController : Controller
    {
        private readonly AuthDBContext context;

        public UserListController(AuthDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.usersLists.ToList();
             return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {

             return View();
        }
        [HttpPost]
        public IActionResult Create(UsersList model)
        {
            if (ModelState.IsValid)
            {
                var user = new UsersList()
                {
                    FirstName =model.FirstName,
                    LastName =model.LastName,
                    PhoneNumber=model.PhoneNumber,
                    Email=model.Email

                };
                context.usersLists.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Empty Field Can't Submit";
                return View();
            }
        }


        public IActionResult Update()
        {
            return View();
        }
    }
}
