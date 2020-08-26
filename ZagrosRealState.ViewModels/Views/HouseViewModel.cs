using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class HouseViewModel
    {

    }
    public class CreateHouseViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( کد ملک ) الزامی است.")]
        [StringLength(maximumLength: 4, MinimumLength = 2, ErrorMessage = "کد ملک شما باید حداکثر 4 رقم باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "کد ملک")]
        public string HouseCode_Id { get; set; }
        /********************************************/

        [Display(Name = "متراژ")]
        public string House_Metrazh { get; set; }

        [Display(Name = "طبقه")]
        public string House_NumTabagheh { get; set; }
        /********************************************/
        [Display(Name = "درب از")]
        public string House_TypeDarb { get; set; }
        /********************************************/
        [Display(Name = "وضعیت اجاره")]
        public string House_StatusEjareh { get; set; }
        /********************************************/
        [Display(Name = "تعداد خواب")]
        public string House_NumKahb { get; set; }
        /********************************************/
        [Display(Name = "طبقه")]
        public string House_Tabagheh { get; set; }
        /********************************************/
        [Display(Name = "پارکینگ")]
        public string House_Parking { get; set; }
        /********************************************/
        [Display(Name = "ورودی")]
        public string House_VoroodyType { get; set; }
        /********************************************/
        [Display(Name = "تاریخ تخلیه")]
        public DateTime? House_DatePublish { get; set; }
        /********************************************/
        [Display(Name = "آب")]
        public string House_AB { get; set; }
        /********************************************/
        [Display(Name = "گاز")]
        public string House_Gaz { get; set; }
        /********************************************/
        [Display(Name = "برق")]
        public string House_Bargh { get; set; }
        /********************************************/
        [Display(Name = "دیگر امکانات")]
        public string House_OtherEmkanat { get; set; }
        /********************************************/
        [Display(Name = "مبلغ رهن")]
        public string House_PriceRahn { get; set; }
        /********************************************/
        [Display(Name = "مبلغ اجاره")]
        public string House_PriceEjareh { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( آدرس ) الزامی است.")]
        [Display(Name = "آدرس")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string House_Address { get; set; }
        /********************************************/
        [Display(Name = "وضعیت منزل")]
        public string House_StatusHouse { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( نام و نام خانوادگی ) الزامی است.")]
        [Display(Name = "نام و نام خانوادگی")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string House_Family { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( شماره تماس ) الزامی است.")]
        [Display(Name = "شماره تماس")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string House_Mobile { get; set; }
        /********************************************/

        [Display(Name = "توضیحات")]
        public string House_Comment { get; set; }
        /********************************************/
        
        [Column(TypeName = "image")]
        public Byte[] House_Image { get; set; }
        public string House_Url { get; set; }
        public int House_UserId { get; set; }

    }

    public class ViewDataHouseModel
    {
        // نمایش فیلدهای جدول منزل
        public string HouseCode_Id { get; set; }
        public string House_Family { get; set; }
        public string House_Mobile { get; set; }
        public string House_Metrazh { get; set; }
        public string House_Tabagheh { get; set; }
        public string House_AB { get; set; }
        public string House_Gaz { get; set; }
        public string House_PriceRahn { get; set; }
        public string House_PriceEjareh { get; set; }
        public string House_Address { get; set; }
        public string House_StatusHouse { get; set; }
        public DateTime? House_DatePublish { get; set; }
    }
}
