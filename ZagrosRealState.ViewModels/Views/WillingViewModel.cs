using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class WillingViewModel
    {

    }
    public class CreateWillingViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( نام خواهان ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [Display(Name = "نام")]
        public string Willing_Name { get; set; }
        /********************************************/

        [Display(Name = "نام خانوادگی")]
        public string Willing_Family { get; set; }
        /********************************************/

        [Display(Name = "شماره موبایل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( شماره موبایل ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string Willing_Mobile { get; set; }
        /********************************************/

        [Display(Name = "مبلغ پیش پرداخت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( مبلغ پیش پرداخت ) الزامی است.")]
        public string Willing_Price { get; set; }
        /********************************************/

        [Display(Name = "خواهان")]
        public string Willing_WillingList { get; set; }
        /********************************************/

        [Display(Name = "جهت")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( جهت ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string Willing_JahatList { get; set; }
        /********************************************/

        [Display(Name = "به مشخصات")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( به مشخصات ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string Willing_Moshakhasat { get; set; }
        /********************************************/

        [Display(Name = "آدرس خواهان")]
        public string Willing_Address { get; set; }

    }
    public class ViewDataWillingModel
    {
        // نمایش فیلدهای جدول مشتری
        public string Willing_Name { get; set; }
        public string Willing_Family { get; set; }
        public string Willing_Mobile { get; set; }
        public string Willing_Price { get; set; }
        public string Willing_WillingList { get; set; }
        public string Willing_JahatList { get; set; }
        public string Willing_Moshakhasat { get; set; }
        public string Willing_Address { get; set; }
        public DateTime? Willing_DatePublish { get; set; }
    }
}
