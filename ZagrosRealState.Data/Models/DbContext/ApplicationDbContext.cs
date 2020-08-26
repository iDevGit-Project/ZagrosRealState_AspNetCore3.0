using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ZagrosRealState.Data.Models.Data;
using ZagrosRealState.Entities.Entities;

namespace ZagrosRealState.Data.Models.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUsers, ApplicationRoles, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // FluentAPI و نحوه ارتباط جداول در کلیه موجودیت های پایگاه داده از طریق روش Mapping پیکربندی عملیات 

            //  FluentAPI تعریف کردن کلید اصلی جداول از طریف روش 
            builder.Entity<Apartment>().HasKey(p => p.Apartment_Id);
            builder.Entity<Willing>().HasKey(p => p.Willing_Id);
            builder.Entity<ByeAndSell>().HasKey(p => p.ByeAndSell_Id);
            builder.Entity<Shop>().HasKey(p => p.Shop_Id);
            builder.Entity<House>().HasKey(p => p.House_Id);
            builder.Entity<Customers>().HasKey(p => p.Customers_Id);
            builder.Entity<Apartment>().Property(p => p.Apartment_Image).HasColumnType("image");
            builder.Entity<Cities>().Property(p => p.CityID).ValueGeneratedNever();
            builder.Entity<Province>().Property(p => p.ProvinceID).ValueGeneratedNever();

            //************

            // FluentAPI اضافه کردن داده های پیش فرض در جداول پایگاه داده مربوطه از طریق روش 

            // - (1) - آپارتمان
            #region Apartment

            builder.Entity<Apartment_LST_Takhliyeh>().HasData(
                new Apartment_LST_Takhliyeh { LST_TakhliyehAPId = 1, LST_TakhliyehAPName = "تخلیه فوری" },
                new Apartment_LST_Takhliyeh { LST_TakhliyehAPId = 2, LST_TakhliyehAPName = "تخلیه شده" },
                new Apartment_LST_Takhliyeh { LST_TakhliyehAPId = 3, LST_TakhliyehAPName = "در حال تخلیه" }
                );
            /****************************/
            builder.Entity<Apartment_LST_NumKhab>().HasData(
                new Apartment_LST_NumKhab { LST_NumKhabAPId = 1, LST_NumKhabAP = "1" },
                new Apartment_LST_NumKhab { LST_NumKhabAPId = 2, LST_NumKhabAP = "2" },
                new Apartment_LST_NumKhab { LST_NumKhabAPId = 3, LST_NumKhabAP = "3" },
                new Apartment_LST_NumKhab { LST_NumKhabAPId = 4, LST_NumKhabAP = "4" },
                new Apartment_LST_NumKhab { LST_NumKhabAPId = 5, LST_NumKhabAP = "5" }
                );
            /****************************/
            builder.Entity<Apartment_LST_NumAB>().HasData(
                new Apartment_LST_NumAB { LST_NumABAPId = 1, LST_NumABAP = "دارد" },
                new Apartment_LST_NumAB { LST_NumABAPId = 2, LST_NumABAP = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_Ejareh>().HasData(
                new Apartment_LST_Ejareh { LST_EjarehAPId = 1, LST_EjarehAPName = "دارد" },
                new Apartment_LST_Ejareh { LST_EjarehAPId = 2, LST_EjarehAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_NumGAZ>().HasData(
                new Apartment_LST_NumGAZ { LST_NumGAZAPId = 1, LST_NumGAZAP = "دارد" },
                new Apartment_LST_NumGAZ { LST_NumGAZAPId = 2, LST_NumGAZAP = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_NumBargh>().HasData(
                new Apartment_LST_NumBargh { LST_NumBarghAPId = 1, LST_NumBarghAP = "دارد" },
                new Apartment_LST_NumBargh { LST_NumBarghAPId = 2, LST_NumBarghAP = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_NumTELL>().HasData(
                new Apartment_LST_NumTELL { LST_NumTELLAPId = 1, LST_NumTELLAP = "دارد" },
                new Apartment_LST_NumTELL { LST_NumTELLAPId = 2, LST_NumTELLAP = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_EmkanatSatus>().HasData(
                new Apartment_LST_EmkanatSatus { LST_EmkanatSatusAPId = 1, LST_EmkanatSatusAPName = "کلیه امکانات مشترک" },
                new Apartment_LST_EmkanatSatus { LST_EmkanatSatusAPId = 2, LST_EmkanatSatusAPName = "کلیه امکانات مستقل" },
                new Apartment_LST_EmkanatSatus { LST_EmkanatSatusAPId = 3, LST_EmkanatSatusAPName = "فاقد هر گونه امکانات" }
                );
            /****************************/
            builder.Entity<Apartment_LST_Parking>().HasData(
                new Apartment_LST_Parking { LST_ParkingAPId = 1, LST_ParkingAPName = "دارد" },
                new Apartment_LST_Parking { LST_ParkingAPId = 2, LST_ParkingAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_Anbari>().HasData(
                new Apartment_LST_Anbari { LST_AnbariAPId = 1, LST_AnbariAPName = "دارد" },
                new Apartment_LST_Anbari { LST_AnbariAPId = 2, LST_AnbariAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_Asansor>().HasData(
                new Apartment_LST_Asansor { LST_AsansorAPId = 1, LST_AsansorAPName = "دارد" },
                new Apartment_LST_Asansor { LST_AsansorAPId = 2, LST_AsansorAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_Shoofazh>().HasData(
                new Apartment_LST_Shoofazh { LST_ShoofazhAPId = 1, LST_ShoofazhAPName = "دارد" },
                new Apartment_LST_Shoofazh { LST_ShoofazhAPId = 2, LST_ShoofazhAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_HagheCharge>().HasData(
                new Apartment_LST_HagheCharge { LST_HagheChargeAPId = 1, LST_HagheChargeAPName = "دارد" },
                new Apartment_LST_HagheCharge { LST_HagheChargeAPId = 2, LST_HagheChargeAPName = "ندارد" }
                );
            /****************************/
            builder.Entity<Apartment_LST_ApartemanStatus>().HasData(
                new Apartment_LST_ApartemanStatus { LST_ApartemanStatusAPId = 1, LST_ApartemanStatusAPName = "رهن شده" },
                new Apartment_LST_ApartemanStatus { LST_ApartemanStatusAPId = 2, LST_ApartemanStatusAPName = "تخلیه شده" },
                new Apartment_LST_ApartemanStatus { LST_ApartemanStatusAPId = 3, LST_ApartemanStatusAPName = "اجاره شده" },
                new Apartment_LST_ApartemanStatus { LST_ApartemanStatusAPId = 4, LST_ApartemanStatusAPName = "به فروش رسیده" },
                new Apartment_LST_ApartemanStatus { LST_ApartemanStatusAPId = 5, LST_ApartemanStatusAPName = "تحت تملک می باشد" }
                );
            /****************************/
            #endregion

            // - (2) - منزل
            #region House

            builder.Entity<House_LST_Darb>().HasData(
                new House_LST_Darb { House_LST_DarbId = 1, House_LST_DarbName = "حیاط - مستقل" },
                new House_LST_Darb { House_LST_DarbId = 2, House_LST_DarbName = "حیاط - مشترک" },
                new House_LST_Darb { House_LST_DarbId = 3, House_LST_DarbName = "ساختمان - مستقل" },
                new House_LST_Darb { House_LST_DarbId = 4, House_LST_DarbName = "ساختمان - مشترک" },
                new House_LST_Darb { House_LST_DarbId = 5, House_LST_DarbName = "نبش" },
                new House_LST_Darb { House_LST_DarbId = 6, House_LST_DarbName = "دونبش" }
                );
            /****************************/
            builder.Entity<House_LST_Ejareh>().HasData(
                new House_LST_Ejareh { House_LST_EjarehId = 1, House_LST_EjarehName = "دارد" },
                new House_LST_Ejareh { House_LST_EjarehId = 2, House_LST_EjarehName = "ندارد" }
                );
            /****************************/
            builder.Entity<House_LST_NumKhab>().HasData(
                new House_LST_NumKhab { House_LST_NumKhabId = 1, House_LST_NumKhabName = "1" },
                new House_LST_NumKhab { House_LST_NumKhabId = 2, House_LST_NumKhabName = "2" },
                new House_LST_NumKhab { House_LST_NumKhabId = 3, House_LST_NumKhabName = "3" },
                new House_LST_NumKhab { House_LST_NumKhabId = 4, House_LST_NumKhabName = "4" },
                new House_LST_NumKhab { House_LST_NumKhabId = 5, House_LST_NumKhabName = "5" }
                );
            /****************************/
            builder.Entity<House_LST_Tabagheh>().HasData(
                new House_LST_Tabagheh { House_LST_TabaghehId = 1, House_LST_TabaghehName = "1" },
                new House_LST_Tabagheh { House_LST_TabaghehId = 2, House_LST_TabaghehName = "2" },
                new House_LST_Tabagheh { House_LST_TabaghehId = 3, House_LST_TabaghehName = "3" },
                new House_LST_Tabagheh { House_LST_TabaghehId = 4, House_LST_TabaghehName = "4" },
                new House_LST_Tabagheh { House_LST_TabaghehId = 5, House_LST_TabaghehName = "5" }
                );
            /****************************/
            builder.Entity<House_LST_Parking>().HasData(
                new House_LST_Parking { House_LST_ParkingId = 1, House_LST_ParkingName = "دارد" },
                new House_LST_Parking { House_LST_ParkingId = 2, House_LST_ParkingName = "ندارد" }
                );
            /****************************/
            builder.Entity<House_LST_Voroody>().HasData(
                new House_LST_Voroody { House_LST_VoroodyId = 1, House_LST_VoroodyName = "مستقل" },
                new House_LST_Voroody { House_LST_VoroodyId = 2, House_LST_VoroodyName = "مشترک" }
                );
            /****************************/
            builder.Entity<House_LST_Ab>().HasData(
                new House_LST_Ab { House_LST_AbId = 1, House_LST_AbName = "دارد. مستقل" },
                new House_LST_Ab { House_LST_AbId = 2, House_LST_AbName = "دارد. مشترک" },
                new House_LST_Ab { House_LST_AbId = 3, House_LST_AbName = "ندارد" }
                );
            /****************************/
            builder.Entity<House_LST_Bargh>().HasData(
                new House_LST_Bargh { House_LST_BarghId = 1, House_LST_BarghName = "دارد. مستقل" },
                new House_LST_Bargh { House_LST_BarghId = 2, House_LST_BarghName = "دارد. مشترک" },
                new House_LST_Bargh { House_LST_BarghId = 3, House_LST_BarghName = "ندارد" }
                );
            /****************************/
            builder.Entity<House_LST_Gaz>().HasData(
                new House_LST_Gaz { House_LST_GazId = 1, House_LST_GazName = "دارد. مستقل" },
                new House_LST_Gaz { House_LST_GazId = 2, House_LST_GazName = "دارد. مشترک" },
                new House_LST_Gaz { House_LST_GazId = 3, House_LST_GazName = "ندارد" }
                );
            /****************************/
            builder.Entity<House_LST_Status>().HasData(
                new House_LST_Status { House_LST_StatusId = 1, House_LST_StatusName = "تخلیه شده" },
                new House_LST_Status { House_LST_StatusId = 2, House_LST_StatusName = "در حال تخلیه" },
                new House_LST_Status { House_LST_StatusId = 3, House_LST_StatusName = "خالی" }
                );
            /****************************/
            #endregion

            // - (3) - مغازه
            #region Shop

            builder.Entity<Shop_LST_Location>().HasData(
                new Shop_LST_Location { Shop_LST_LocationId = 1, Shop_LST_LocationName = "تجاری" },
                new Shop_LST_Location { Shop_LST_LocationId = 2, Shop_LST_LocationName = "داخل پاساژ" },
                new Shop_LST_Location { Shop_LST_LocationId = 3, Shop_LST_LocationName = "بیرون پاساژ" },
                new Shop_LST_Location { Shop_LST_LocationId = 4, Shop_LST_LocationName = "داخل مجتمع" },
                new Shop_LST_Location { Shop_LST_LocationId = 5, Shop_LST_LocationName = "بیرون مجتمع" },
                new Shop_LST_Location { Shop_LST_LocationId = 6, Shop_LST_LocationName = "داخل گاراژ" },
                new Shop_LST_Location { Shop_LST_LocationId = 7, Shop_LST_LocationName = "بیرون گاراژ" },
                new Shop_LST_Location { Shop_LST_LocationId = 8, Shop_LST_LocationName = "داخل کوچه" },
                new Shop_LST_Location { Shop_LST_LocationId = 9, Shop_LST_LocationName = "سر کوچه" },
                new Shop_LST_Location { Shop_LST_LocationId = 10, Shop_LST_LocationName = "بر خیابان" },
                new Shop_LST_Location { Shop_LST_LocationId = 11, Shop_LST_LocationName = "سر خیابان" }
                );
            /****************************/
            builder.Entity<Shop_LST_Darb>().HasData(
                new Shop_LST_Darb { Shop_LST_DarbId = 1, Shop_LST_DarbName = "شیشه ای" },
                new Shop_LST_Darb { Shop_LST_DarbId = 2, Shop_LST_DarbName = "کرکره ای" },
                new Shop_LST_Darb { Shop_LST_DarbId = 3, Shop_LST_DarbName = "آهنی" },
                new Shop_LST_Darb { Shop_LST_DarbId = 4, Shop_LST_DarbName = "آلومینیوم" },
                new Shop_LST_Darb { Shop_LST_DarbId = 5, Shop_LST_DarbName = "چوبی" },
                new Shop_LST_Darb { Shop_LST_DarbId = 6, Shop_LST_DarbName = "پلاستیک فشرده" },
                new Shop_LST_Darb { Shop_LST_DarbId = 7, Shop_LST_DarbName = "پرده" },
                new Shop_LST_Darb { Shop_LST_DarbId = 8, Shop_LST_DarbName = "درب  برقی هوشمند" },
                new Shop_LST_Darb { Shop_LST_DarbId = 9, Shop_LST_DarbName = "فلزی" },
                new Shop_LST_Darb { Shop_LST_DarbId = 10, Shop_LST_DarbName = "سایر" }
                );
            /****************************/
            builder.Entity<Shop_LST_Ejareh>().HasData(
                new Shop_LST_Ejareh { Shop_LST_EjarehId = 1, Shop_LST_EjarehName = "دارد" },
                new Shop_LST_Ejareh { Shop_LST_EjarehId = 2, Shop_LST_EjarehName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Balakon>().HasData(
                new Shop_LST_Balakon { Shop_LST_BalakonId = 1, Shop_LST_BalakonName = "دارد" },
                new Shop_LST_Balakon { Shop_LST_BalakonId = 2, Shop_LST_BalakonName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_InsideDesign>().HasData(
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 1, Shop_LST_InsideDesignName = "سرامیک" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 2, Shop_LST_InsideDesignName = "آجری" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 3, Shop_LST_InsideDesignName = "بتنی" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 4, Shop_LST_InsideDesignName = "خشت و گل" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 5, Shop_LST_InsideDesignName = "گچی" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 6, Shop_LST_InsideDesignName = "سیمانی" },
                new Shop_LST_InsideDesign { Shop_LST_InsideDesignId = 7, Shop_LST_InsideDesignName = "کاغذ دیواری" }
                );
            /****************************/
            builder.Entity<Shop_LST_AB>().HasData(
                new Shop_LST_AB { Shop_LST_ABId = 1, Shop_LST_ABName = "دارد" },
                new Shop_LST_AB { Shop_LST_ABId = 2, Shop_LST_ABName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Gaz>().HasData(
                new Shop_LST_Gaz { Shop_LST_GazId = 1, Shop_LST_GazName = "دارد" },
                new Shop_LST_Gaz { Shop_LST_GazId = 2, Shop_LST_GazName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Bargh>().HasData(
                new Shop_LST_Bargh { Shop_LST_BarghId = 1, Shop_LST_BarghName = "دارد" },
                new Shop_LST_Bargh { Shop_LST_BarghId = 2, Shop_LST_BarghName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Tell>().HasData(
                new Shop_LST_Tell { Shop_LST_TellId = 1, Shop_LST_TellName = "دارد" },
                new Shop_LST_Tell { Shop_LST_TellId = 2, Shop_LST_TellName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_HagheCharge>().HasData(
                new Shop_LST_HagheCharge { Shop_LST_HagheChargeId = 1, Shop_LST_HagheChargeName = "دارد" },
                new Shop_LST_HagheCharge { Shop_LST_HagheChargeId = 2, Shop_LST_HagheChargeName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_PayaneKar>().HasData(
                new Shop_LST_PayaneKar { Shop_LST_PayaneKarId = 1, Shop_LST_PayaneKarName = "دارد" },
                new Shop_LST_PayaneKar { Shop_LST_PayaneKarId = 2, Shop_LST_PayaneKarName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Senf>().HasData(
                new Shop_LST_Senf { Shop_LST_SenfId = 1, Shop_LST_SenfName = "قطعات یدکی خودرو سبک" },
                new Shop_LST_Senf { Shop_LST_SenfId = 2, Shop_LST_SenfName = "قطعات یدکی خودرو سنگین" },
                new Shop_LST_Senf { Shop_LST_SenfId = 3, Shop_LST_SenfName = "قطعات یدکی موتورسیکلت" },
                new Shop_LST_Senf { Shop_LST_SenfId = 4, Shop_LST_SenfName = "خدمات برق و باتری" },
                new Shop_LST_Senf { Shop_LST_SenfId = 5, Shop_LST_SenfName = "خدمات روغن و مکانیکی" },
                new Shop_LST_Senf { Shop_LST_SenfId = 6, Shop_LST_SenfName = "خدمات لاستیک خودرو" },
                new Shop_LST_Senf { Shop_LST_SenfId = 7, Shop_LST_SenfName = "خدمات ماشین های اداری" },
                new Shop_LST_Senf { Shop_LST_SenfId = 8, Shop_LST_SenfName = "خدمات کافی نت، گیم نت" },
                new Shop_LST_Senf { Shop_LST_SenfId = 9, Shop_LST_SenfName = "خدمات درب و پنجره" },
                new Shop_LST_Senf { Shop_LST_SenfId = 10, Shop_LST_SenfName = "سایر خدمات" }
                );
            /****************************/
            builder.Entity<Shop_LST_Anbary>().HasData(
                new Shop_LST_Anbary { Shop_LST_AnbaryId = 1, Shop_LST_AnbaryName = "دارد" },
                new Shop_LST_Anbary { Shop_LST_AnbaryId = 2, Shop_LST_AnbaryName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Asansor>().HasData(
                new Shop_LST_Asansor { Shop_LST_AsansorId = 1, Shop_LST_AsansorName = "دارد" },
                new Shop_LST_Asansor { Shop_LST_AsansorId = 2, Shop_LST_AsansorName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Shoofazh>().HasData(
                new Shop_LST_Shoofazh { Shop_LST_ShoofazhId = 1, Shop_LST_ShoofazhName = "دارد" },
                new Shop_LST_Shoofazh { Shop_LST_ShoofazhId = 2, Shop_LST_ShoofazhName = "ندارد" }
                );
            /****************************/
            builder.Entity<Shop_LST_Rahn_OR_Ejareh>().HasData(
                new Shop_LST_Rahn_OR_Ejareh { Shop_LST_Rahn_OR_EjarehId = 1, Shop_LST_Rahn_OR_EjarehName = "رهن کامل" },
                new Shop_LST_Rahn_OR_Ejareh { Shop_LST_Rahn_OR_EjarehId = 2, Shop_LST_Rahn_OR_EjarehName = "رهن موقت" },
                new Shop_LST_Rahn_OR_Ejareh { Shop_LST_Rahn_OR_EjarehId = 3, Shop_LST_Rahn_OR_EjarehName = "اجاره موقت" },
                new Shop_LST_Rahn_OR_Ejareh { Shop_LST_Rahn_OR_EjarehId = 4, Shop_LST_Rahn_OR_EjarehName = "رهن و اجاره" }
                );
            /****************************/
            #endregion

            // - (4) - خرید و فروش
            #region ByeAndSell

            builder.Entity<ByeAndSell_LST_MoredeMoameleh>().HasData(
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 1, ByeAndSell_LST_MoredeMoameleh_Name = "یک دستگاه آپارتمان" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 2, ByeAndSell_LST_MoredeMoameleh_Name = "یک باب مغازه تجاری" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 3, ByeAndSell_LST_MoredeMoameleh_Name = "یک واحد تجاری" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 4, ByeAndSell_LST_MoredeMoameleh_Name = "یک واحد تجاری دوبلکس" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 5, ByeAndSell_LST_MoredeMoameleh_Name = "یک واحد آپارتمان" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 6, ByeAndSell_LST_MoredeMoameleh_Name = "یک قطعه زمین" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 7, ByeAndSell_LST_MoredeMoameleh_Name = "باغ شهر" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 8, ByeAndSell_LST_MoredeMoameleh_Name = "منزل ویلایی" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 9, ByeAndSell_LST_MoredeMoameleh_Name = "قطعه انباری" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 10, ByeAndSell_LST_MoredeMoameleh_Name = "قطعه پارکینگ" },
                new ByeAndSell_LST_MoredeMoameleh { ByeAndSell_LST_MoredeMoameleh_Id = 11, ByeAndSell_LST_MoredeMoameleh_Name = "دستگاه سوله" }
                );
            /****************************/
            builder.Entity<ByeAndSell_LST_Karbary>().HasData(
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 1, ByeAndSell_LST_TypeKarbaryName = "مسکونی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 2, ByeAndSell_LST_TypeKarbaryName = "تجاری" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 3, ByeAndSell_LST_TypeKarbaryName = "آموزشی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 4, ByeAndSell_LST_TypeKarbaryName = "صنعتی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 5, ByeAndSell_LST_TypeKarbaryName = "ورزشی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 6, ByeAndSell_LST_TypeKarbaryName = "بهداشتی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 7, ByeAndSell_LST_TypeKarbaryName = "خدماتی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 8, ByeAndSell_LST_TypeKarbaryName = "دامداری" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 9, ByeAndSell_LST_TypeKarbaryName = "مرغداری" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 10, ByeAndSell_LST_TypeKarbaryName = "دامپروری" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 11, ByeAndSell_LST_TypeKarbaryName = "گلخانه" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 12, ByeAndSell_LST_TypeKarbaryName = "پرورش ماهی" },
                new ByeAndSell_LST_Karbary { ByeAndSell_LST_TypeKarbaryId = 13, ByeAndSell_LST_TypeKarbaryName = "باغ و باغچه" }
                );
            /****************************/
            builder.Entity<ByeAndSell_LST_JahatMoamele>().HasData(
                new ByeAndSell_LST_JahatMoamele { ByeAndSell_LST_JahatMoameleId = 1, ByeAndSell_LST_JahatMoameleName = "خرید" },
                new ByeAndSell_LST_JahatMoamele { ByeAndSell_LST_JahatMoameleId = 2, ByeAndSell_LST_JahatMoameleName = "فروش" },
                new ByeAndSell_LST_JahatMoamele { ByeAndSell_LST_JahatMoameleId = 3, ByeAndSell_LST_JahatMoameleName = "معاوضه" },
                new ByeAndSell_LST_JahatMoamele { ByeAndSell_LST_JahatMoameleId = 4, ByeAndSell_LST_JahatMoameleName = "سایر" }
                );
            /****************************/
            #endregion

            // - (5) - خواهان
            #region Willing

            builder.Entity<Willing_LST>().HasData(
                new Willing_LST { Willing_LSTId = 1, Willing_LSTName = "یک واحد آپارتمان" },
                new Willing_LST { Willing_LSTId = 2, Willing_LSTName = "یک باب مغازه" },
                new Willing_LST { Willing_LSTId = 3, Willing_LSTName = "یک باب منزل ویلایی" },
                new Willing_LST { Willing_LSTId = 4, Willing_LSTName = "یک قطعه زمین" }
                );
            /****************************/
            builder.Entity<Willing_LST_Jahat>().HasData(
                new Willing_LST_Jahat { Willing_LST_JahatId = 1, Willing_LST_JahatName = "رهن" },
                new Willing_LST_Jahat { Willing_LST_JahatId = 2, Willing_LST_JahatName = "رهن و اجاره" },
                new Willing_LST_Jahat { Willing_LST_JahatId = 3, Willing_LST_JahatName = "خرید" },
                new Willing_LST_Jahat { Willing_LST_JahatId = 4, Willing_LST_JahatName = "فروش" },
                new Willing_LST_Jahat { Willing_LST_JahatId = 5, Willing_LST_JahatName = "معاوضه" }
                );
            /****************************/
            #endregion

            // - (6) - مشتری
            #region Customers

            builder.Entity<Customers_LST_JOB>().HasData(
                new Customers_LST_JOB { Customers_LST_JOBId = 1, Customers_LST_JOBName = "دولتی" },
                new Customers_LST_JOB { Customers_LST_JOBId = 2, Customers_LST_JOBName = "آزاد" },
                new Customers_LST_JOB { Customers_LST_JOBId = 3, Customers_LST_JOBName = "بیکار" },
                new Customers_LST_JOB { Customers_LST_JOBId = 4, Customers_LST_JOBName = "دانشجو" },
                new Customers_LST_JOB { Customers_LST_JOBId = 5, Customers_LST_JOBName = "استاد دانشگاه" },
                new Customers_LST_JOB { Customers_LST_JOBId = 6, Customers_LST_JOBName = "معلم" },
                new Customers_LST_JOB { Customers_LST_JOBId = 7, Customers_LST_JOBName = "بازنشسته" }
                );
            /****************************/
            #endregion

        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Apartment_LST_Anbari> Apartment_LST_Anbaris { get; set; }
        public DbSet<Apartment_LST_ApartemanStatus> Apartment_LST_ApartemanStatuses { get; set; }
        public DbSet<Apartment_LST_Asansor> Apartment_LST_Asansors { get; set; }
        public DbSet<Apartment_LST_Ejareh> Apartment_LST_Ejarehs { get; set; }
        public DbSet<Apartment_LST_EmkanatSatus> Apartment_LST_EmkanatSatus { get; set; }
        public DbSet<Apartment_LST_HagheCharge> Apartment_LST_HagheCharges { get; set; }
        public DbSet<Apartment_LST_NumAB> Apartment_LST_NumABs { get; set; }
        public DbSet<Apartment_LST_NumBargh> Apartment_LST_NumBarghs { get; set; }
        public DbSet<Apartment_LST_NumGAZ> Apartment_LST_NumGAZs { get; set; }
        public DbSet<Apartment_LST_NumKhab> Apartment_LST_NumKhabs { get; set; }
        public DbSet<Apartment_LST_NumTELL> Apartment_LST_NumTELLs { get; set; }
        public DbSet<Apartment_LST_Parking> Apartment_LST_Parkings { get; set; }
        public DbSet<Apartment_LST_Shoofazh> Apartment_LST_Shoofazhs { get; set; }
        public DbSet<Apartment_LST_Takhliyeh> Apartment_LST_Takhliyehs { get; set; }

        //******************************************************************************************

        public DbSet<Willing> Willings { get; set; }
        public DbSet<Willing_LST_Jahat> Willing_LST_Jahats { get; set; }
        public DbSet<Willing_LST> Willing_LSTs { get; set; }

        //******************************************************************************************
        public DbSet<ByeAndSell> ByeAndSells { get; set; }
        public DbSet<ByeAndSell_LST_Karbary> ByeAndSell_LST_Karbaries { get; set; }
        public DbSet<ByeAndSell_LST_MoredeMoameleh> ByeAndSell_LST_MoredeMoamelehs { get; set; }
        public DbSet<ByeAndSell_LST_JahatMoamele> ByeAndSell_LST_JahatMoameles { get; set; }
        //******************************************************************************************
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Shop_LST_AB> Shop_LST_ABs { get; set; }
        public DbSet<Shop_LST_Anbary> Shop_LST_Anbaries { get; set; }
        public DbSet<Shop_LST_Asansor> Shop_LST_Asansors { get; set; }
        public DbSet<Shop_LST_Balakon> Shop_LST_Balakons { get; set; }
        public DbSet<Shop_LST_Bargh> Shop_LST_Barghs { get; set; }
        public DbSet<Shop_LST_Darb> Shop_LST_Darbs { get; set; }
        public DbSet<Shop_LST_Ejareh> Shop_LST_Ejarehs { get; set; }
        public DbSet<Shop_LST_Gaz> Shop_LST_Gazs { get; set; }
        public DbSet<Shop_LST_HagheCharge> Shop_LST_HagheCharges { get; set; }
        public DbSet<Shop_LST_InsideDesign> Shop_LST_InsideDesigns { get; set; }
        public DbSet<Shop_LST_Location> Shop_LST_Locations { get; set; }
        public DbSet<Shop_LST_PayaneKar> Shop_LST_PayaneKars { get; set; }
        public DbSet<Shop_LST_Rahn_OR_Ejareh> Shop_LST_Rahn_OR_Ejarehs { get; set; }
        public DbSet<Shop_LST_Senf> Shop_LST_Senfs { get; set; }
        public DbSet<Shop_LST_Shoofazh> Shop_LST_Shoofazhs { get; set; }
        public DbSet<Shop_LST_Tell> Shop_LST_Tells { get; set; }
        //******************************************************************************************
        public DbSet<House> Houses { get; set; }
        public DbSet<House_LST_Ab> House_LST_Abs { get; set; }
        public DbSet<House_LST_Bargh> House_LST_Barghs { get; set; }
        public DbSet<House_LST_Darb> House_LST_Darbs { get; set; }
        public DbSet<House_LST_Ejareh> House_LST_Ejarehs { get; set; }
        public DbSet<House_LST_Gaz> House_LST_Gazs { get; set; }
        public DbSet<House_LST_NumKhab> House_LST_NumKhabs { get; set; }
        public DbSet<House_LST_Parking> House_LST_Parkings { get; set; }
        public DbSet<House_LST_Status> House_LST_Statuses { get; set; }
        public DbSet<House_LST_Tabagheh> House_LST_Tabaghehs { get; set; }
        public DbSet<House_LST_Voroody> House_LST_Voroodies { get; set; }

        //******************************************************************************************
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Customers_LST_JOB> Customers_LST_JOBs { get; set; }
        //******************************************************************************************
        public DbSet<Cities> Cities { get; set; }
        //******************************************************************************************
        public DbSet<Province> Provinces { get; set; }
        //******************************************************************************************
    }
}
