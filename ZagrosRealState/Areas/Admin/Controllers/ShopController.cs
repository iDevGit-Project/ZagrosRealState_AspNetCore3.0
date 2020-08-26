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
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به مغازه
            ViewBag.Shop_LST_Locations = new SelectList(_context.Shop_LST_Locations, "Shop_LST_LocationName", "Shop_LST_LocationName");
            ViewBag.Shop_LST_Darbs = new SelectList(_context.Shop_LST_Darbs, "Shop_LST_DarbName", "Shop_LST_DarbName");
            ViewBag.Shop_LST_Ejarehs = new SelectList(_context.Shop_LST_Ejarehs, "Shop_LST_EjarehName", "Shop_LST_EjarehName");
            ViewBag.Shop_LST_Balakons = new SelectList(_context.Shop_LST_Balakons, "Shop_LST_BalakonName", "Shop_LST_BalakonName");
            ViewBag.Shop_LST_InsideDesigns = new SelectList(_context.Shop_LST_InsideDesigns, "Shop_LST_InsideDesignName", "Shop_LST_InsideDesignName");
            ViewBag.Shop_LST_ABs = new SelectList(_context.Shop_LST_ABs, "Shop_LST_ABName", "Shop_LST_ABName");
            ViewBag.Shop_LST_Gazs = new SelectList(_context.Shop_LST_Gazs, "Shop_LST_GazName", "Shop_LST_GazName");
            ViewBag.Shop_LST_Barghs = new SelectList(_context.Shop_LST_Barghs, "Shop_LST_BarghName", "Shop_LST_BarghName");
            ViewBag.Shop_LST_Tells = new SelectList(_context.Shop_LST_Tells, "Shop_LST_TellName", "Shop_LST_TellName");
            ViewBag.Shop_LST_HagheCharges = new SelectList(_context.Shop_LST_HagheCharges, "Shop_LST_HagheChargeName", "Shop_LST_HagheChargeName");
            ViewBag.Shop_LST_PayaneKars = new SelectList(_context.Shop_LST_PayaneKars, "Shop_LST_PayaneKarName", "Shop_LST_PayaneKarName");
            ViewBag.Shop_LST_Senfs = new SelectList(_context.Shop_LST_Senfs, "Shop_LST_SenfName", "Shop_LST_SenfName");
            ViewBag.Shop_LST_Anbaries = new SelectList(_context.Shop_LST_Anbaries, "Shop_LST_AnbaryName", "Shop_LST_AnbaryName");
            ViewBag.Shop_LST_Asansors = new SelectList(_context.Shop_LST_Asansors, "Shop_LST_AsansorName", "Shop_LST_AsansorName");
            ViewBag.Shop_LST_Shoofazhs = new SelectList(_context.Shop_LST_Shoofazhs, "Shop_LST_ShoofazhName", "Shop_LST_ShoofazhName");
            ViewBag.Shop_LST_Rahn_OR_Ejarehs = new SelectList(_context.Shop_LST_Rahn_OR_Ejarehs, "Shop_LST_Rahn_OR_EjarehName", "Shop_LST_Rahn_OR_EjarehName");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateShopViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var ShopTransaction = _context.Database.BeginTransaction();
                try
                {
                    Shop InsertData = new Shop()
                    {
                        ShopCode_Id = VM.ShopCode_Id,
                        Shop_Mougheyat = VM.Shop_Mougheyat,
                        Shop_Metrazh = VM.Shop_Metrazh,
                        Shop_TypeDarb = VM.Shop_TypeDarb,
                        Shop_StatusEjareh = VM.Shop_StatusEjareh,
                        Shop_Balakon = VM.Shop_Balakon,
                        Shop_BalakonMetrazh = VM.Shop_BalakonMetrazh,
                        Shop_BeARZ = VM.Shop_BeARZ,
                        Shop_InsidePooshesh = VM.Shop_InsidePooshesh,
                        Shop_AB = VM.Shop_AB,
                        Shop_Gaz = VM.Shop_Gaz,
                        Shop_Bargh = VM.Shop_Bargh,
                        Shop_Tell = VM.Shop_Tell,
                        Shop_HagheCharge = VM.Shop_HagheCharge,
                        Shop_PriceCharge = VM.Shop_PriceCharge,
                        Shop_PriceRahn = VM.Shop_PriceRahn,
                        Shop_PriceEjareh = VM.Shop_PriceEjareh,
                        Shop_Address = VM.Shop_Address,
                        Shop_PayaneKar = VM.Shop_PayaneKar,
                        Shop_TypeSenf = VM.Shop_TypeSenf,
                        Shop_Family = VM.Shop_Family,
                        Shop_Mobile = VM.Shop_Mobile,
                        Shop_Comment = VM.Shop_Comment,
                        Shop_Anbary = VM.Shop_Anbary,
                        Shop_Asansor = VM.Shop_Asansor,
                        Shop_Shoofazh = VM.Shop_Shoofazh,
                        Shop_Status_Rah_OR_Ejareh = VM.Shop_Status_Rah_OR_Ejareh,
                        Shop_DatePublish = DateTime.Now

                    };
                    await _context.Shops.AddAsync(InsertData);
                    await _context.SaveChangesAsync();
                    ShopTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageShop = "Faild New Shop Data" });
                }

            }
            else
            {
                // دریافت کلیه لیست های مربوط به مغازه
                ViewBag.Shop_LST_Locations = new SelectList(_context.Shop_LST_Locations, "Shop_LST_LocationName", "Shop_LST_LocationName");
                ViewBag.Shop_LST_Darbs = new SelectList(_context.Shop_LST_Darbs, "Shop_LST_DarbName", "Shop_LST_DarbName");
                ViewBag.Shop_LST_Ejarehs = new SelectList(_context.Shop_LST_Ejarehs, "Shop_LST_EjarehName", "Shop_LST_EjarehName");
                ViewBag.Shop_LST_Balakons = new SelectList(_context.Shop_LST_Balakons, "Shop_LST_BalakonName", "Shop_LST_BalakonName");
                ViewBag.Shop_LST_InsideDesigns = new SelectList(_context.Shop_LST_InsideDesigns, "Shop_LST_InsideDesignName", "Shop_LST_InsideDesignName");
                ViewBag.Shop_LST_ABs = new SelectList(_context.Shop_LST_ABs, "Shop_LST_ABName", "Shop_LST_ABName");
                ViewBag.Shop_LST_Gazs = new SelectList(_context.Shop_LST_Gazs, "Shop_LST_GazName", "Shop_LST_GazName");
                ViewBag.Shop_LST_Barghs = new SelectList(_context.Shop_LST_Barghs, "Shop_LST_BarghName", "Shop_LST_BarghName");
                ViewBag.Shop_LST_Tells = new SelectList(_context.Shop_LST_Tells, "Shop_LST_TellName", "Shop_LST_TellName");
                ViewBag.Shop_LST_HagheCharges = new SelectList(_context.Shop_LST_HagheCharges, "Shop_LST_HagheChargeName", "Shop_LST_HagheChargeName");
                ViewBag.Shop_LST_PayaneKars = new SelectList(_context.Shop_LST_PayaneKars, "Shop_LST_PayaneKarName", "Shop_LST_PayaneKarName");
                ViewBag.Shop_LST_Senfs = new SelectList(_context.Shop_LST_Senfs, "Shop_LST_SenfName", "Shop_LST_SenfName");
                ViewBag.Shop_LST_Anbaries = new SelectList(_context.Shop_LST_Anbaries, "Shop_LST_AnbaryName", "Shop_LST_AnbaryName");
                ViewBag.Shop_LST_Asansors = new SelectList(_context.Shop_LST_Asansors, "Shop_LST_AsansorName", "Shop_LST_AsansorName");
                ViewBag.Shop_LST_Shoofazhs = new SelectList(_context.Shop_LST_Shoofazhs, "Shop_LST_ShoofazhName", "Shop_LST_ShoofazhName");
                ViewBag.Shop_LST_Rahn_OR_Ejarehs = new SelectList(_context.Shop_LST_Rahn_OR_Ejarehs, "Shop_LST_Rahn_OR_EjarehName", "Shop_LST_Rahn_OR_EjarehName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {
            var ReadData = (from b in _context.Shops
                                select new
                                ViewDataShopModel
                                {
                                    ShopCode_Id = b.ShopCode_Id,
                                    Shop_Family = b.Shop_Family,
                                    Shop_Mobile = b.Shop_Mobile,
                                    Shop_Metrazh = b.Shop_Metrazh,
                                    Shop_Balakon = b.Shop_Balakon,
                                    Shop_InsidePooshesh = b.Shop_InsidePooshesh,
                                    Shop_PriceRahn = b.Shop_PriceRahn,
                                    Shop_PriceEjareh = b.Shop_PriceEjareh,
                                    Shop_TypeSenf = b.Shop_TypeSenf,
                                    Shop_Address = b.Shop_Address,
                                    Shop_PayaneKar = b.Shop_PayaneKar,
                                    Shop_DatePublish = b.Shop_DatePublish

                                }).AsNoTracking().ToList();

            // نمایش اطلاعات مربوط به داده های مغازه به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var ShopPagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            ShopPagingModel.Action = "Read";

            ViewBag.Shop_LST_Senfs = new SelectList(_context.Shop_LST_Senfs, "Shop_LST_SenfName", "Shop_LST_SenfName");
            ViewBag.Shop_LST_Balakons = new SelectList(_context.Shop_LST_Balakons, "Shop_LST_BalakonName", "Shop_LST_BalakonName");
            ViewBag.Shop_LST_InsideDesigns = new SelectList(_context.Shop_LST_InsideDesigns, "Shop_LST_InsideDesignName", "Shop_LST_InsideDesignName");
            ViewBag.Shop_LST_PayaneKars = new SelectList(_context.Shop_LST_PayaneKars, "Shop_LST_PayaneKarName", "Shop_LST_PayaneKarName");

            return View(ShopPagingModel);
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