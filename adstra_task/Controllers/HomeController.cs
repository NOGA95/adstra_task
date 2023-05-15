using adstra_task.Areas.Identity.Data;
using adstra_task.Data;
using adstra_task.Models;
using adstra_task.Models.Repositories;
using adstra_task.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace adstra_task.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        private AuthDBContext _application;
        private readonly IUserListRepo _users;

        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger,UserManager<ApplicationUser> userManager, AuthDBContext application , IUserListRepo user)
        {
            _logger = logger;
            this._userManager = userManager;
            _application = application;
            _users = user;

        }

       
        public IActionResult Index()
        {
            return View(_application.Users.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            try
            {
                var user = _users.GetUserByID(id);
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User With Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var model = new EditUserVM
                    {
                        Id = user.Id,
                        Email = user.Email,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber

                    };

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return View("Not Found");
            }

        }
        [HttpPost]
        public async Task<IActionResult> Update(EditUserVM UserDetails)
        {
            try
            {
                var model = new ApplicationUser
                {
                    Id = UserDetails.Id,
                    Email = UserDetails.Email,
                    FirstName = UserDetails.FirstName,
                    LastName = UserDetails.LastName,
                    PhoneNumber = UserDetails.PhoneNumber

                };

                 _users.Update(model);
                var user =await _userManager.UpdateAsync(model);
                return RedirectToAction("Index", user);

            }
            catch (Exception ex)
            {
                return View("NotFound");

            }
            

        }



        [HttpGet]
        public IActionResult Delete(string id)
        {
            try
            {
                var user = _users.GetUserByID(id);
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User With Id = {id} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var model = new EditUserVM
                    {
                        Id = user.Id,
                        Email = user.Email,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber

                    };

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return View("Not Found");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Delete(EditUserVM DeleteUser)
        {
            try
            {
                var model = new ApplicationUser
                {
                    Id = DeleteUser.Id,
                    Email = DeleteUser.Email,
                    FirstName = DeleteUser.FirstName,
                    LastName = DeleteUser.LastName,
                    PhoneNumber = DeleteUser.PhoneNumber

                };

                _users.Delete(model);
                var user = await _userManager.DeleteAsync(model);
                return RedirectToAction("Index", user);

            }
            catch (Exception ex)
            {
                return View("NotFound");

            }


        }
        public async Task<IActionResult> Profile()
        {
            try
            {
                var username = _userManager.GetUserName(User);
                var userid = _users.GetUserIDByName(username);
                var user = await _userManager.FindByNameAsync(username);
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"User With username = {username} cannot be found";
                    return View("NotFound");
                }
                else
                {
                    var model = new EditUserVM
                    {
                        Id = user.Id,
                        Email = user.Email,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber

                    };

                    return View(model);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                return View("Not Found");
            }


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
