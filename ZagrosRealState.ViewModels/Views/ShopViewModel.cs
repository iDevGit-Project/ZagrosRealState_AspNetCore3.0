using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class ShopViewModel
    {

    }

    public class CreateShopViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن (کد ملک) الزامی است.")]
        [StringLength(maximumLength: 4, MinimumLength = 2, ErrorMessage = "کد ملک شما باید حداکثر 4 رقم باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "کد ملک")]
        public string ShopCode_Id { get; set; }
        /********************************************/

        [Display(Name = "موقعیت")]
        public string Shop_Mougheyat { get; set; }
        /********************************************/

        [Display(Name = "متراژ")]
        public string Shop_Metrazh { get; set; }

        /********************************************/
        [Display(Name = "نوع درب")]
        public string Shop_TypeDarb { get; set; }

        /********************************************/
        [Display(Name = "وضعیت اجاره")]
        public string Shop_StatusEjareh { get; set; }

        /********************************************/
        [Display(Name = "بالاکن")]
        public string Shop_Balakon { get; set; }

        /********************************************/
        [Display(Name = "متراژ بالاکن")]
        public string Shop_BalakonMetrazh { get; set; }

        /********************************************/
        [Display(Name = "به عرض")]
        public string Shop_BeARZ { get; set; }

        /********************************************/
        [Display(Name = "پوشش داخلی")]
        public string Shop_InsidePooshesh { get; set; }

        /********************************************/
        [Display(Name = "آب")]
        public string Shop_AB { get; set; }

        /********************************************/
        [Display(Name = "گاز")]
        public string Shop_Gaz { get; set; }

        /********************************************/
        [Display(Name = "برق")]
        public string Shop_Bargh { get; set; }

        /********************************************/
        [Display(Name = "تلفن")]
        public string Shop_Tell { get; set; }

        /********************************************/
        [Display(Name = "حق شارژ")]
        public string Shop_HagheCharge { get; set; }

        /********************************************/
        [Display(Name = "مبلغ حق شارژ")]
        public string Shop_PriceCharge { get; set; }

        /********************************************/
        [Display(Name = "مبلغ رهن")]
        public string Shop_PriceRahn { get; set; }

        /********************************************/
        [Display(Name = "مبلغ اجاره")]
        public string Shop_PriceEjareh { get; set; }

        /********************************************/
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن (آدرس) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "آدرس")]
        public string Shop_Address { get; set; }

        /********************************************/
        [Display(Name = "پایان کار")]
        public string Shop_PayaneKar { get; set; }

        /********************************************/
        [Display(Name = "مناسب جهت صنف")]
        public string Shop_TypeSenf { get; set; }

        /********************************************/
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن (نام و نام خانوادگی) الزامی است.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "نام و نام خانوادگی")]
        public string Shop_Family { get; set; }

        /********************************************/
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن (شماره تماس) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "شماره تماس")]
        public string Shop_Mobile { get; set; }

        /********************************************/
        [Display(Name = "توضیحات")]
        public string Shop_Comment { get; set; }

        /********************************************/
        [Display(Name = "انباری")]
        public string Shop_Anbary { get; set; }

        /********************************************/
        [Display(Name = "آسانسور")]
        public string Shop_Asansor { get; set; }

        /********************************************/
        [Display(Name = "شوفاژ")]
        public string Shop_Shoofazh { get; set; }

        /********************************************/
        [Display(Name = "وضعیت رهن یا اجاره")]
        public string Shop_Status_Rah_OR_Ejareh { get; set; }

    }
    public class ViewDataShopModel
    {
        // نمایش فیلدهای جدول مغازه 
        public string ShopCode_Id { get; set; }
        public string Shop_Family { get; set; }
        public string Shop_Mobile { get; set; }
        public string Shop_Metrazh { get; set; }
        public string Shop_Balakon { get; set; }
        public string Shop_InsidePooshesh { get; set; }
        public string Shop_PriceRahn { get; set; }
        public string Shop_PriceEjareh { get; set; }
        public string Shop_TypeSenf { get; set; }
        public string Shop_Address { get; set; }
        public string Shop_PayaneKar { get; set; }
        public DateTime? Shop_DatePublish { get; set; }
    }
}
