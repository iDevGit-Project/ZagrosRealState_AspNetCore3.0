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
    public class ByeSellController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ByeSellController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به خرید و فروش

            ViewBag.ByeAndSell_LST_MoredeMoamelehs = new SelectList(_context.ByeAndSell_LST_MoredeMoamelehs, "ByeAndSell_LST_MoredeMoameleh_Name", "ByeAndSell_LST_MoredeMoameleh_Name");
            ViewBag.ByeAndSell_LST_Karbaries = new SelectList(_context.ByeAndSell_LST_Karbaries, "ByeAndSell_LST_TypeKarbaryName", "ByeAndSell_LST_TypeKarbaryName");
            ViewBag.ByeAndSell_LST_JahatMoameles = new SelectList(_context.ByeAndSell_LST_JahatMoameles, "ByeAndSell_LST_JahatMoameleName", "ByeAndSell_LST_JahatMoameleName");

            //********************************************************************************************************************************************

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateByeAndSellViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var BuySellTransaction = _context.Database.BeginTransaction();
                try
                {
                    ByeAndSell InsertData = new ByeAndSell()
                    {
                        ByeAndSellCode_Id = VM.ByeAndSellCode_Id,
                        ByeAndSell_TypeMoredeMoameleh = VM.ByeAndSell_TypeMoredeMoameleh,
                        ByeAndSell_JahateMoameleh = VM.ByeAndSell_JahateMoameleh,
                        ByeAndSell_TypeKarbary = VM.ByeAndSell_TypeKarbary,
                        ByeAndSell_Moshakhasat = VM.ByeAndSell_Moshakhasat,
                        ByeAndSell_Address = VM.ByeAndSell_Address,
                        ByeAndSell_TypeEstefadeh = VM.ByeAndSell_TypeEstefadeh,
                        ByeAndSell_Price = VM.ByeAndSell_Price,
                        ByeAndSell_CodePosty = VM.ByeAndSell_CodePosty,
                        ByeAndSell_Family = VM.ByeAndSell_Family,
                        ByeAndSell_Mobile = VM.ByeAndSell_Mobile,
                        ByeAndSell_DatePublish = DateTime.Now,
                    };
                    /******************************************/
                    // درج اطلاعات مربوط به خرید و فروش
                    await _context.ByeAndSells.AddAsync(InsertData);
                    await _context.SaveChangesAsync();
                    BuySellTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageByeSell = "Faild New ByeSell Data" });
                }

            }
            else
            {
                // دریافت کلیه لیست های مربوط به خرید و فروش
                ViewBag.ByeAndSell_LST_MoredeMoamelehs = new SelectList(_context.ByeAndSell_LST_MoredeMoamelehs, "ByeAndSell_LST_MoredeMoameleh_Name", "ByeAndSell_LST_MoredeMoameleh_Name");
                ViewBag.ByeAndSell_LST_Karbaries = new SelectList(_context.ByeAndSell_LST_Karbaries, "ByeAndSell_LST_TypeKarbaryName", "ByeAndSell_LST_TypeKarbaryName");
                ViewBag.ByeAndSell_LST_JahatMoameles = new SelectList(_context.ByeAndSell_LST_JahatMoameles, "ByeAndSell_LST_JahatMoameleName", "ByeAndSell_LST_JahatMoameleName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {
            var ReadData = (from b in _context.ByeAndSells
                                   select new
                                   ViewDataByeAndSellModel
                                   {
                                       ByeAndSellCode_Id = b.ByeAndSellCode_Id,
                                       ByeAndSell_TypeMoredeMoameleh = b.ByeAndSell_TypeMoredeMoameleh,
                                       ByeAndSell_JahateMoameleh = b.ByeAndSell_JahateMoameleh,
                                       ByeAndSell_TypeKarbary = b.ByeAndSell_TypeKarbary,
                                       ByeAndSell_Moshakhasat = b.ByeAndSell_Moshakhasat,
                                       ByeAndSell_Address = b.ByeAndSell_Address,
                                       ByeAndSell_TypeEstefadeh = b.ByeAndSell_TypeEstefadeh,
                                       ByeAndSell_Price = b.ByeAndSell_Price,
                                       ByeAndSell_CodePosty = b.ByeAndSell_CodePosty,
                                       ByeAndSell_Family = b.ByeAndSell_Family,
                                       ByeAndSell_Mobile = b.ByeAndSell_Mobile,
                                       ByeAndSell_DatePublish = b.ByeAndSell_DatePublish,

                                   }).AsNoTracking().ToList();

            // نمایش اطلاعات مربوط به داده های خرید و فروش به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var ByeAndSellPagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            ByeAndSellPagingModel.Action = "Read";

            ViewBag.ByeAndSell_LST_MoredeMoamelehs = new SelectList(_context.ByeAndSell_LST_MoredeMoamelehs, "ByeAndSell_LST_MoredeMoameleh_Name", "ByeAndSell_LST_MoredeMoameleh_Name");
            ViewBag.ByeAndSell_LST_Karbaries = new SelectList(_context.ByeAndSell_LST_Karbaries, "ByeAndSell_LST_TypeKarbaryName", "ByeAndSell_LST_TypeKarbaryName");
            ViewBag.ByeAndSell_LST_JahatMoameles = new SelectList(_context.ByeAndSell_LST_JahatMoameles, "ByeAndSell_LST_JahatMoameleName", "ByeAndSell_LST_JahatMoameleName");

            return View(ByeAndSellPagingModel);
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