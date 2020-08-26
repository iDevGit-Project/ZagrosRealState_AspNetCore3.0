using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class ByeAndSellViewModel
    {

    }

    public class CreateByeAndSellViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( کد ملک ) الزامی است.")]
        [StringLength(maximumLength: 4, MinimumLength = 2, ErrorMessage = "کد ملک شما باید حداکثر 4 رقم باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "کد ملک")]
        public string ByeAndSellCode_Id { get; set; }
        /********************************************/

        [Display(Name = "موضوع مورد معامله")]
        public string ByeAndSell_TypeMoredeMoameleh { get; set; }
        /********************************************/

        [Display(Name = "[جهت معامله")]
        public string ByeAndSell_JahateMoameleh { get; set; }
        /********************************************/

        [Display(Name = "نوع کاربری")]
        public string ByeAndSell_TypeKarbary { get; set; }
        /********************************************/

        [Display(Name = "مشخصات مورد معامله")]
        public string ByeAndSell_Moshakhasat { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( آدرس مکان خرید و فروش ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "واقع در")]
        public string ByeAndSell_Address { get; set; }
        /********************************************/

        [Display(Name = "جهت استفاده")]
        public string ByeAndSell_TypeEstefadeh { get; set; }
        /********************************************/

        [Display(Name = "به مبلغ")]
        public string ByeAndSell_Price { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( کدپستی | پلاک | قطعه ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "کدپستی | پلاک | قطعه")]
        public string ByeAndSell_CodePosty { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( به نام ) الزامی است.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "به نام")]
        public string ByeAndSell_Family { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( شماره تماس ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [Display(Name = "شماره تماس")]
        public string ByeAndSell_Mobile { get; set; }
        /********************************************/

        //[Display(Name = "تاریخ ثبت")]
        //public DateTime? ByeAndSell_DatePublish { get; set; }
        /********************************************/


        //[Column(TypeName = "image")]
        //public byte[] ByeAndSell_Image { get; set; }
        //public string ByeAndSell_Url { get; set; }

    }
    public class ViewDataByeAndSellModel
    {
        // نمایش فیلدهای جدول خرید و فروش
        public string ByeAndSellCode_Id { get; set; }
        public string ByeAndSell_Family { get; set; }
        public string ByeAndSell_Mobile { get; set; }
        public string ByeAndSell_TypeMoredeMoameleh { get; set; }
        public string ByeAndSell_JahateMoameleh { get; set; }
        public string ByeAndSell_TypeKarbary { get; set; }
        public string ByeAndSell_Moshakhasat { get; set; }
        public string ByeAndSell_Address { get; set; }
        public string ByeAndSell_TypeEstefadeh { get; set; }
        public string ByeAndSell_Price { get; set; }
        public string ByeAndSell_CodePosty { get; set; }
        public DateTime? ByeAndSell_DatePublish { get; set; }
    }
}
