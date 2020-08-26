using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZagrosRealState.Data.Models.DbContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using ZagrosRealState.ViewModels.Views;
using ZagrosRealState.Entities.Entities;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WillingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public WillingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به خواهان
            ViewBag.Willing_LST_Jahats = new SelectList(_context.Willing_LST_Jahats, "Willing_LST_JahatName", "Willing_LST_JahatName");
            ViewBag.Willing_LSTs = new SelectList(_context.Willing_LSTs, "Willing_LSTName", "Willing_LSTName");

            //********************************************************************************************************************************************

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateWillingViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var WillingTransaction = _context.Database.BeginTransaction();
                try
                {
                    Willing InsertWillingAddNewData = new Willing()
                    {
                        Willing_Name = VM.Willing_Name,
                        Willing_Family = VM.Willing_Family,
                        Willing_Mobile = VM.Willing_Mobile,
                        Willing_Price = VM.Willing_Price,
                        Willing_KhahanList = VM.Willing_WillingList,
                        Willing_JahatList = VM.Willing_JahatList,
                        Willing_Moshakhasat = VM.Willing_Moshakhasat,
                        Willing_Address = VM.Willing_Address,
                        Willing_DatePublish = DateTime.Now

                    };
                    /******************************************/
                    // درج اطلاعات مربوط به خواهان
                    await _context.Willings.AddAsync(InsertWillingAddNewData);
                    await _context.SaveChangesAsync();
                    WillingTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageWilling = "Faild New Willing Data" });
                }

            }
            else
            {
                // دریافت کلیه لیست های مربوط به خواهان
                ViewBag.Willing_LST_Jahats = new SelectList(_context.Willing_LST_Jahats, "Willing_LST_JahatName", "Willing_LST_JahatName");
                ViewBag.Willing_LSTs = new SelectList(_context.Willing_LSTs, "Willing_LSTName", "Willing_LSTName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {
            var ReadData = (from b in _context.Willings
                                   select new
                                   ViewDataWillingModel
                                   {
                                       Willing_Name = b.Willing_Name,
                                       Willing_Family = b.Willing_Family,
                                       Willing_Mobile = b.Willing_Mobile,
                                       Willing_Price = b.Willing_Price,
                                       Willing_WillingList = b.Willing_KhahanList,
                                       Willing_JahatList = b.Willing_JahatList,
                                       Willing_Moshakhasat = b.Willing_Moshakhasat,
                                       Willing_Address = b.Willing_Address,
                                       Willing_DatePublish = b.Willing_DatePublish

                                   }).AsNoTracking().ToList();
            // نمایش اطلاعات مربوط به داده های آپارتمان به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var WillingPagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            WillingPagingModel.Action = "Read";

            ViewBag.Willing_LST_Jahats = new SelectList(_context.Willing_LST_Jahats, "Willing_LST_JahatName", "Willing_LST_JahatName");
            ViewBag.Willing_LSTs = new SelectList(_context.Willing_LSTs, "Willing_LSTName", "Willing_LSTName");

            return View(WillingPagingModel);
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