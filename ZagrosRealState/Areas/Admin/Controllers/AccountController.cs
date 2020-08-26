using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ZagrosRealState.Data.Models.Data;
using ZagrosRealState.ViewModels.Views;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly RoleManager<ApplicationRoles> _roleManager;
        private readonly SignInManager<ApplicationUsers> _signInManager;

        public AccountController(UserManager<ApplicationUsers> userManager, RoleManager<ApplicationRoles> roleManager,
            SignInManager<ApplicationUsers> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                {
                    try
                    {
                        if (await _userManager.FindByNameAsync(model.UserName) != null)
                        {
                            ModelState.AddModelError("UserName", "نام کاربری قبلا توسط کاربر دیگری استفاده شده است.");
                            return View(model);
                        }

                        int IsPhoneAlreadyRegistered = _userManager.Users.Where(item => item.PhoneNumber == model.PhoneNumber).Count();
                        if (IsPhoneAlreadyRegistered > 0)
                        {
                            ModelState.AddModelError("PhoneNumber", "شماره موبایل تکراری می باشد.");
                            return View(model);
                        }

                        var user = new ApplicationUsers
                        {
                            UserName = model.UserName,
                            PasswordHash = model.Password,
                            FirstName = model.firstName,
                            LastName = model.family,
                            PhoneNumber = model.PhoneNumber
                        };
                        IdentityResult registerResult = await _userManager.CreateAsync(user, model.Password);
                        if (registerResult.Succeeded)
                        {
                            //Add Role To User
                            registerResult = await _userManager.AddToRoleAsync(user, "userpanel");
                        }
                    }
                    catch
                    {
                        return RedirectToAction("catchDump", "Index");
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}