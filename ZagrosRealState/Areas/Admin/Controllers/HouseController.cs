using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZagrosRealState.Data.Models.DbContext;
using ZagrosRealState.Entities.Entities;
using ZagrosRealState.ViewModels.Views;
using ReflectionIT.Mvc.Paging;
using Microsoft.EntityFrameworkCore;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HouseController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HouseController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به منزل
            ViewBag.House_LST_Darbs = new SelectList(_context.House_LST_Darbs, "House_LST_DarbName", "House_LST_DarbName");
            ViewBag.House_LST_Ejarehs = new SelectList(_context.House_LST_Ejarehs, "House_LST_EjarehName", "House_LST_EjarehName");
            ViewBag.House_LST_NumKhabs = new SelectList(_context.House_LST_NumKhabs, "House_LST_NumKhabName", "House_LST_NumKhabName");
            ViewBag.House_LST_Tabaghehs = new SelectList(_context.House_LST_Tabaghehs, "House_LST_TabaghehName", "House_LST_TabaghehName");
            ViewBag.House_LST_Parkings = new SelectList(_context.House_LST_Parkings, "House_LST_ParkingName", "House_LST_ParkingName");
            ViewBag.House_LST_Voroodies = new SelectList(_context.House_LST_Voroodies, "House_LST_VoroodyName", "House_LST_VoroodyName");
            ViewBag.House_LST_Abs = new SelectList(_context.House_LST_Abs, "House_LST_AbName", "House_LST_AbName");
            ViewBag.House_LST_Gazs = new SelectList(_context.House_LST_Gazs, "House_LST_GazName", "House_LST_GazName");
            ViewBag.House_LST_Barghs = new SelectList(_context.House_LST_Barghs, "House_LST_BarghName", "House_LST_BarghName");
            ViewBag.House_LST_Statuses = new SelectList(_context.House_LST_Statuses, "House_LST_StatusName", "House_LST_StatusName");

            //********************************************************************************************************************************************

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateHouseViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var HouseTransaction = _context.Database.BeginTransaction();
                try
                {
                    House InsertData = new House()
                    {
                        HouseCode_Id = VM.HouseCode_Id,
                        House_Metrazh = VM.House_Metrazh,
                        House_Tabagheh = VM.House_Tabagheh,
                        House_TypeDarb = VM.House_TypeDarb,
                        House_StatusEjareh = VM.House_StatusEjareh,
                        House_NumKahb = VM.House_NumKahb,
                        House_NumTabagheh = VM.House_NumTabagheh,
                        House_Parking = VM.House_Parking,
                        House_VoroodyType = VM.House_VoroodyType,
                        House_DatePublish = DateTime.Now,
                        House_AB = VM.House_AB,
                        House_Gaz = VM.House_Gaz,
                        House_Bargh = VM.House_Bargh,
                        House_OtherEmkanat = VM.House_OtherEmkanat,
                        House_PriceRahn = VM.House_PriceRahn,
                        House_PriceEjareh = VM.House_PriceEjareh,
                        House_Address = VM.House_Address,
                        House_StatusManzel = VM.House_StatusHouse,
                        House_Family = VM.House_Family,
                        House_Mobile = VM.House_Mobile,
                        House_Comment = VM.House_Comment,
                    };

                    /******************************************/
                    // درج اطلاعات مربوط به منزل
                    await _context.Houses.AddAsync(InsertData);
                    await _context.SaveChangesAsync();
                    HouseTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageHouse = "Faild New House Data" });
                }

            }
            else
            {
                // دریافت کلیه لیست های مربوط به منزل
                ViewBag.House_LST_Darbs = new SelectList(_context.House_LST_Darbs, "House_LST_DarbName", "House_LST_DarbName");
                ViewBag.House_LST_Ejarehs = new SelectList(_context.House_LST_Ejarehs, "House_LST_EjarehName", "House_LST_EjarehName");
                ViewBag.House_LST_NumKhabs = new SelectList(_context.House_LST_NumKhabs, "House_LST_NumKhabName", "House_LST_NumKhabName");
                ViewBag.House_LST_Tabaghehs = new SelectList(_context.House_LST_Tabaghehs, "House_LST_TabaghehName", "House_LST_TabaghehName");
                ViewBag.House_LST_Parkings = new SelectList(_context.House_LST_Parkings, "House_LST_ParkingName", "House_LST_ParkingName");
                ViewBag.House_LST_Voroodies = new SelectList(_context.House_LST_Voroodies, "House_LST_VoroodyName", "House_LST_VoroodyName");
                ViewBag.House_LST_Abs = new SelectList(_context.House_LST_Abs, "House_LST_AbName", "House_LST_AbName");
                ViewBag.House_LST_Gazs = new SelectList(_context.House_LST_Gazs, "House_LST_GazName", "House_LST_GazName");
                ViewBag.House_LST_Barghs = new SelectList(_context.House_LST_Barghs, "House_LST_BarghName", "House_LST_BarghName");
                ViewBag.House_LST_Statuses = new SelectList(_context.House_LST_Statuses, "House_LST_StatusName", "House_LST_StatusName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {
            var ReadData = (from b in _context.Houses
                                 select new
                                 ViewDataHouseModel
                                 {
                                     HouseCode_Id = b.HouseCode_Id,
                                     House_Family = b.House_Family,
                                     House_Mobile = b.House_Mobile,
                                     House_Metrazh = b.House_Metrazh,
                                     House_Tabagheh = b.House_Tabagheh,
                                     House_AB = b.House_AB,
                                     House_Gaz = b.House_Gaz,
                                     House_PriceRahn = b.House_PriceRahn,
                                     House_PriceEjareh = b.House_PriceEjareh,
                                     House_Address = b.House_Address,
                                     House_StatusHouse = b.House_StatusManzel,
                                     House_DatePublish = b.House_DatePublish

                                 }).AsNoTracking().ToList();

            // نمایش اطلاعات مربوط به داده های منزل به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var HousePagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            HousePagingModel.Action = "Read";

            ViewBag.House_LST_Abs = new SelectList(_context.House_LST_Abs, "House_LST_AbName", "House_LST_AbName");
            ViewBag.House_LST_Gazs = new SelectList(_context.House_LST_Gazs, "House_LST_GazName", "House_LST_GazName");
            ViewBag.House_LST_Statuses = new SelectList(_context.House_LST_Statuses, "House_LST_StatusName", "House_LST_StatusName");

            return View(HousePagingModel);
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