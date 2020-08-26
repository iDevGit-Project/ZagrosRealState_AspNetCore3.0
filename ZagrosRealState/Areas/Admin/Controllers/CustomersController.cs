using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using ZagrosRealState.Data.Models.DbContext;
using ZagrosRealState.Entities.Entities;
using ZagrosRealState.ViewModels.Views;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به مشتریان
            ViewBag.Customers_LST_JOBs = new SelectList(_context.Customers_LST_JOBs, "Customers_LST_JOBName", "Customers_LST_JOBName");

            //********************************************************************************************************************************************

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomersViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var CustomersTransaction = _context.Database.BeginTransaction();
                try
                {
                    Customers InsertData = new Customers()
                    {
                        Customers_Name = VM.Customers_Name,
                        Customers_Family = VM.Customers_Family,
                        Customers_CodeMelli = VM.Customers_CodeMelli,
                        Customers_Mobile = VM.Customers_Mobile,
                        Customers_Job = VM.Customers_Job,
                        Customers_Address = VM.Customers_Address,
                        Customers_DatePublish = DateTime.Now

                    };

                    await _context.Customers.AddAsync(InsertData);
                    await _context.SaveChangesAsync();
                    CustomersTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageCustomers = "Faild New Customers Data" });
                }
;
            }
            else
            {
                // دریافت کلیه لیست های مربوط به مشتری
                ViewBag.Customers_LST_JOBs = new SelectList(_context.Customers_LST_JOBs, "Customers_LST_JOBName", "Customers_LST_JOBName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {
            var ReadData = (from b in _context.Customers
                                     select new
                                     ViewDataCustomersModel
                                     {
                                         Customers_Name = b.Customers_Name,
                                         Customers_Family = b.Customers_Family,
                                         Customers_CodeMelli = b.Customers_CodeMelli,
                                         Customers_Mobile = b.Customers_Mobile,
                                         Customers_Job = b.Customers_Job,
                                         Customers_Address = b.Customers_Address,
                                         Customers_DatePublish = b.Customers_DatePublish

                                     }).AsNoTracking().ToList();

            // نمایش اطلاعات مربوط به داده های آپارتمان به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var CustomersPagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            CustomersPagingModel.Action = "Read";
            ViewBag.Customers_LST_JOBs = new SelectList(_context.Customers_LST_JOBs, "Customers_LST_JOBName", "Customers_LST_JOBName");

            return View(CustomersPagingModel);
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}