using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using ZagrosRealState.Data.Interface;
using ZagrosRealState.Data.Models.DbContext;
using ZagrosRealState.Entities.Entities;
using ZagrosRealState.ViewModels.Views;

namespace ZagrosRealState.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApartmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _ENV;
        public ApartmentController(ApplicationDbContext context, IWebHostEnvironment ENV)
        {
            _context = context;
            _ENV = ENV;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            // دریافت کلیه لیست های مربوط به آپارتمان
            ViewBag.Apartment_LST_Ejarehs = new SelectList(_context.Apartment_LST_Ejarehs, "LST_EjarehAPName", "LST_EjarehAPName");
            ViewBag.Apartment_LST_Takhliyehs = new SelectList(_context.Apartment_LST_Takhliyehs, "LST_TakhliyehAPName", "LST_TakhliyehAPName");
            ViewBag.Apartment_LST_NumKhabs = new SelectList(_context.Apartment_LST_NumKhabs, "LST_NumKhabAP", "LST_NumKhabAP");
            ViewBag.Apartment_LST_NumABs = new SelectList(_context.Apartment_LST_NumABs, "LST_NumABAP", "LST_NumABAP");
            ViewBag.Apartment_LST_NumGAZs = new SelectList(_context.Apartment_LST_NumGAZs, "LST_NumGAZAP", "LST_NumGAZAP");
            ViewBag.Apartment_LST_NumBarghs = new SelectList(_context.Apartment_LST_NumBarghs, "LST_NumBarghAP", "LST_NumBarghAP");
            ViewBag.Apartment_LST_NumTELLs = new SelectList(_context.Apartment_LST_NumTELLs, "LST_NumTELLAP", "LST_NumTELLAP");
            ViewBag.Apartment_LST_EmkanatSatus = new SelectList(_context.Apartment_LST_EmkanatSatus, "LST_EmkanatSatusAPName", "LST_EmkanatSatusAPName");
            ViewBag.Apartment_LST_Parkings = new SelectList(_context.Apartment_LST_Parkings, "LST_ParkingAPName", "LST_ParkingAPName");
            ViewBag.Apartment_LST_Anbaris = new SelectList(_context.Apartment_LST_Anbaris, "LST_AnbariAPName", "LST_AnbariAPName");
            ViewBag.Apartment_LST_Asansors = new SelectList(_context.Apartment_LST_Asansors, "LST_AsansorAPName", "LST_AsansorAPName");
            ViewBag.Apartment_LST_Shoofazhs = new SelectList(_context.Apartment_LST_Shoofazhs, "LST_ShoofazhAPName", "LST_ShoofazhAPName");
            ViewBag.Apartment_LST_HagheCharges = new SelectList(_context.Apartment_LST_HagheCharges, "LST_HagheChargeAPName", "LST_HagheChargeAPName");
            ViewBag.Apartment_LST_ApartemanStatuses = new SelectList(_context.Apartment_LST_ApartemanStatuses, "LST_ApartemanStatusAPName", "LST_ApartemanStatusAPName");
            //********************************************************************************************************************************************

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateApartmentViewModel VM)
        {
            if (ModelState.IsValid)
            {
                if (VM.Apartment_Image != null)
                {
                    string FileExtention = Path.GetExtension(VM.Apartment_Image.FileName);
                    string NewFileName = string.Concat(Guid.NewGuid().ToString(), FileExtention);
                    var path = $"{_ENV.WebRootPath}/ImageApartment/{NewFileName}";
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await VM.Apartment_Image.CopyToAsync(stream);
                    }
                }
                var ApartmentTransaction = _context.Database.BeginTransaction();
                try
                {
                    Apartment InsertData = new Apartment()
                    {
                        Apartment_CodeId = VM.Apartment_CodeId,
                        Apartment_Metrazh = VM.Apartment_Metrazh,
                        Apartment_Tabaghe = VM.Apartment_Tabaghe,
                        Apartment_Ejareh = VM.Apartment_Ejareh,
                        Apartment_Takhliyeh = VM.Apartment_Takhliyeh,
                        Apartment_NumKhab = VM.Apartment_NumKhab,
                        Apartment_NumBolook = VM.Apartment_NumBolook,
                        Apartment_NumVahed = VM.Apartment_NumVahed,
                        Apartment_DateTakhliyeh = DateTime.Now,
                        Apartment_PublishDate = DateTime.Now,
                        Apartment_Enshaaab_Aab = VM.Apartment_Enshaaab_Aab,
                        Apartment_Enshaaab_Gaaz = VM.Apartment_Enshaaab_Gaaz,
                        Apartment_Enshaaab_Baargh = VM.Apartment_Enshaaab_Baargh,
                        Apartment_Enshaaab_Telephone = VM.Apartment_Enshaaab_Telephone,
                        Apartment_StatusEnshaaab = VM.Apartment_StatusEnshaaab,
                        Apartment_Parking = VM.Apartment_Parking,
                        Apartment_Anbari = VM.Apartment_Anbari,
                        Apartment_Asansor = VM.Apartment_Asansor,
                        Apartment_Shoofazh = VM.Apartment_Shoofazh,
                        Apartment_HagheCharge = VM.Apartment_HagheCharge,
                        Apartment_HagheCharge_Price = VM.Apartment_HagheCharge_Price,
                        Apartment_PriceRahn = VM.Apartment_PriceRahn,
                        Apartment_PriceEjareh = VM.Apartment_PriceEjareh,
                        Apartment_Address = VM.Apartment_Address,
                        Apartment_StatusRahnAparteman = VM.Apartment_StatusRahnAparteman,
                        Apartment_MojerName = VM.Apartment_MojerName,
                        Apartment_MojerTell = VM.Apartment_MojerTell,
                        Apartment_Description = VM.Apartment_Description,
                        Apartment_Url = VM.Apartment_Image.FileName,
                    };

                    //if (VM.Apartment_Image!=null)
                    //{
                    //    using(var memorystream = new MemoryStream())
                    //    {
                    //        await VM.Apartment_Image.CopyToAsync(memorystream);
                    //        InsertData.Apartment_Image = memorystream.ToArray();
                    //    }
                    //}

                    await _context.Apartments.AddAsync(InsertData);
                    await _context.SaveChangesAsync();
                    ApartmentTransaction.Commit();

                    return RedirectToAction("Read");
                }
                catch (Exception)
                {
                    return RedirectToAction("Read", new { AddNewDataMessageApartment = "Faild New Apartment Data" });
                }

            }
            else
            {
                // دریافت کلیه لیست های مربوط به آپارتمان
                ViewBag.Apartment_LST_Ejarehs = new SelectList(_context.Apartment_LST_Ejarehs, "LST_EjarehAPName", "LST_EjarehAPName");
                ViewBag.Apartment_LST_Takhliyehs = new SelectList(_context.Apartment_LST_Takhliyehs, "LST_TakhliyehAPName", "LST_TakhliyehAPName");
                ViewBag.Apartment_LST_NumKhabs = new SelectList(_context.Apartment_LST_NumKhabs, "LST_NumKhabAP", "LST_NumKhabAP");
                ViewBag.Apartment_LST_NumABs = new SelectList(_context.Apartment_LST_NumABs, "LST_NumABAP", "LST_NumABAP");
                ViewBag.Apartment_LST_NumGAZs = new SelectList(_context.Apartment_LST_NumGAZs, "LST_NumGAZAP", "LST_NumGAZAP");
                ViewBag.Apartment_LST_NumBarghs = new SelectList(_context.Apartment_LST_NumBarghs, "LST_NumBarghAP", "LST_NumBarghAP");
                ViewBag.Apartment_LST_NumTELLs = new SelectList(_context.Apartment_LST_NumTELLs, "LST_NumTELLAP", "LST_NumTELLAP");
                ViewBag.Apartment_LST_EmkanatSatus = new SelectList(_context.Apartment_LST_EmkanatSatus, "LST_EmkanatSatusAPName", "LST_EmkanatSatusAPName");
                ViewBag.Apartment_LST_Parkings = new SelectList(_context.Apartment_LST_Parkings, "LST_ParkingAPName", "LST_ParkingAPName");
                ViewBag.Apartment_LST_Anbaris = new SelectList(_context.Apartment_LST_Anbaris, "LST_AnbariAPName", "LST_AnbariAPName");
                ViewBag.Apartment_LST_Asansors = new SelectList(_context.Apartment_LST_Asansors, "LST_AsansorAPName", "LST_AsansorAPName");
                ViewBag.Apartment_LST_Shoofazhs = new SelectList(_context.Apartment_LST_Shoofazhs, "LST_ShoofazhAPName", "LST_ShoofazhAPName");
                ViewBag.Apartment_LST_HagheCharges = new SelectList(_context.Apartment_LST_HagheCharges, "LST_HagheChargeAPName", "LST_HagheChargeAPName");
                ViewBag.Apartment_LST_ApartemanStatuses = new SelectList(_context.Apartment_LST_ApartemanStatuses, "LST_ApartemanStatusAPName", "LST_ApartemanStatusAPName");

                return View(VM);
            }
        }

        public IActionResult Read(int pageindex = 1)
        {

            var ReadData = (from b in _context.Apartments
                                     select new
                                     ViewDataApartmentModel
                                     {
                                         Apartment_CodeId = b.Apartment_CodeId,
                                         Apartment_MojerName = b.Apartment_MojerName,
                                         Apartment_MojerTell = b.Apartment_MojerTell,
                                         Apartment_Metrazh = b.Apartment_Metrazh,
                                         Apartment_Tabaghe = b.Apartment_Tabaghe,
                                         Apartment_NumKhab = b.Apartment_NumKhab,
                                         Apartment_StatusEnshaaab = b.Apartment_StatusEnshaaab,
                                         Apartment_PriceRahn = b.Apartment_PriceRahn,
                                         Apartment_PriceEjareh = b.Apartment_PriceEjareh,
                                         Apartment_Address = b.Apartment_Address,
                                         Apartment_StatusRahnAparteman = b.Apartment_StatusRahnAparteman,
                                         Apartment_PublishDate = b.Apartment_PublishDate,
                                         //Apartment_Image = b.Apartment_Image

                                     }).AsNoTracking().ToList();

            // نمایش اطلاعات مربوط به داده های آپارتمان به صورت صفحه بندی شده که در هر صفحه 5 مورد را به کاربر نشان می دهیم
            var ApartmentPagingModel = PagingList.Create(ReadData, 5, pageindex);
            // ************************************************************************************************************************

            // این متد برای رفتن به صفحه ای است که اطلاعات جداول در آنجا ذخیره شده اند. همچنین عملیات صفحه بندی نیز انجام میگیرد
            ApartmentPagingModel.Action = "Read";

            ViewBag.Apartment_LST_ApartemanStatuses = new SelectList(_context.Apartment_LST_ApartemanStatuses, "LST_ApartemanStatusAPName", "LST_ApartemanStatusAPName");
            ViewBag.Apartment_LST_NumKhabs = new SelectList(_context.Apartment_LST_NumKhabs, "LST_NumKhabAP", "LST_NumKhabAP");
            ViewBag.Apartment_LST_EmkanatSatus = new SelectList(_context.Apartment_LST_EmkanatSatus, "LST_EmkanatSatusAPName", "LST_EmkanatSatusAPName");

            return View(ApartmentPagingModel);
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var ReadData = (from b in _context.Apartments
                            select new
                            ViewDataApartmentModel
                            {
                                Apartment_CodeId = b.Apartment_CodeId,
                                Apartment_MojerName = b.Apartment_MojerName,
                                Apartment_MojerTell = b.Apartment_MojerTell,
                                Apartment_Metrazh = b.Apartment_Metrazh,
                                Apartment_Tabaghe = b.Apartment_Tabaghe,
                                Apartment_NumKhab = b.Apartment_NumKhab,
                                Apartment_StatusEnshaaab = b.Apartment_StatusEnshaaab,
                                Apartment_PriceRahn = b.Apartment_PriceRahn,
                                Apartment_PriceEjareh = b.Apartment_PriceEjareh,
                                Apartment_Address = b.Apartment_Address,
                                Apartment_StatusRahnAparteman = b.Apartment_StatusRahnAparteman,
                                Apartment_PublishDate = b.Apartment_PublishDate,

                            }).AsNoTracking().ToList();

            return PartialView(ReadData);
        }
    }
}