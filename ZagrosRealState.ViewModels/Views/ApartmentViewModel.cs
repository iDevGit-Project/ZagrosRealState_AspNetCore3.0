using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class ApartmentViewModel
    {

    }

    public class CreateApartmentViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( کد ملک ) الزامی است.")]
        [StringLength(maximumLength: 4, MinimumLength = 2, ErrorMessage = "کد ملک شما باید حداکثر 4 رقم باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "کد ملک")]
        public string Apartment_CodeId { get; set; }
        /********************************************/

        [Display(Name = "متراژ")]
        public string Apartment_Metrazh { get; set; }
        

        [Display(Name = "تعداد آپارتمان")]
        public string Apartment_CountRecord { get; set; }
        /********************************************/

        [Display(Name = "طبقه")]
        public string Apartment_Tabaghe { get; set; }
        /********************************************/

        [Display(Name = "وضعیت اجاره")]
        public string Apartment_Ejareh { get; set; }
        /********************************************/

        [Display(Name = "تخلیه فوری")]
        public string Apartment_Takhliyeh { get; set; }
        /********************************************/

        [Display(Name = "تعداد خواب")]
        public string Apartment_NumKhab { get; set; }
        /********************************************/

        [Display(Name = "بلوک")]
        public string Apartment_NumBolook { get; set; }
        /********************************************/

        [Display(Name = "واحد")]
        public string Apartment_NumVahed { get; set; }
        /********************************************/

        [Display(Name = "آب")]
        public string Apartment_Enshaaab_Aab { get; set; }
        /********************************************/

        [Display(Name = "گاز")]
        public string Apartment_Enshaaab_Gaaz { get; set; }
        /********************************************/

        [Display(Name = "برق")]
        public string Apartment_Enshaaab_Baargh { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( تلفن ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "تلفن")]
        public string Apartment_Enshaaab_Telephone { get; set; }

        /********************************************/
        [Display(Name = "وضعیت امکانات")]

        public string Apartment_StatusEnshaaab { get; set; }
        /********************************************/

        [Display(Name = "پارکینگ")]
        public string Apartment_Parking { get; set; }
        /********************************************/

        [Display(Name = "انباری")]
        public string Apartment_Anbari { get; set; }
        /********************************************/

        [Display(Name = "آسانسور")]
        public string Apartment_Asansor { get; set; }
        /********************************************/

        [Display(Name = "شوفاژ")]
        public string Apartment_Shoofazh { get; set; }
        /********************************************/

        [Display(Name = "حق شارژ")]
        public string Apartment_HagheCharge { get; set; }
        /********************************************/

        [Display(Name = "مبلغ حق شارژ")]
        public string Apartment_HagheCharge_Price { get; set; }
        /********************************************/

        [Display(Name = "مبلغ رهن")]

        public string Apartment_PriceRahn { get; set; }
        /********************************************/
        [Display(Name = "مبلغ اجاره")]

        public string Apartment_PriceEjareh { get; set; }
        /********************************************/
        [Display(Name = "وضعیت آپارتمان")]

        public string Apartment_StatusRahnAparteman { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( آدرس ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "آدرس")]
        public string Apartment_Address { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( نام و نام خانوادگی موجر ) الزامی است.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "نام و نام خانوادگی موجر")]
        public string Apartment_MojerName { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( شماره تماس ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "شماره تماس")]
        public string Apartment_MojerTell { get; set; }
        /********************************************/

        [Display(Name = "توضیحات")]
        public string Apartment_Description { get; set; }
        /********************************************/

        public DateTime? Apartment_PublishDate { get; set; }

        //public string FileName { get; set; }
        ///********************************************/
        //public IFormFile File { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "آپلود ( تصویر آپارتمان فوق ) الزامی است.")]
        [Display(Name = "بارگزاری تصویر")]
        public IFormFile Apartment_Image { get; set; }

        //public string Apartment_Url { get; set; }
        ////public DateTime? Apartment_PublishDate { get; set; }
        //public int Apartment_UserId { get; set; }

    }
    public class ViewDataApartmentModel
    {
        // نمایش فیلدهای جدول آپارتمان
        public string Apartment_CodeId { get; set; }
        public string Apartment_MojerName { get; set; }
        public string Apartment_MojerTell { get; set; }
        public string Apartment_Metrazh { get; set; }
        public string Apartment_Tabaghe { get; set; }
        public string Apartment_NumKhab { get; set; }
        public string Apartment_StatusEnshaaab { get; set; }
        public string Apartment_PriceRahn { get; set; }
        public string Apartment_PriceEjareh { get; set; }
        public string Apartment_Address { get; set; }
        public string Apartment_StatusRahnAparteman { get; set; }
        public DateTime? Apartment_PublishDate { get; set; }
        public string Apartment_Url { get; set; }
        public IFormFile Apartment_Image { get; set; }

        //public string FileName { get; set; }
        //public IFormFile File { get; set; }
    }

}
