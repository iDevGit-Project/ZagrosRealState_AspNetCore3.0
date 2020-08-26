using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class CustomersViewModel
    {

    }
    public class CreateCustomersViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( نام مشتری ) الزامی است.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [Display(Name = "نام")]
        public string Customers_Name { get; set; }
        /********************************************/

        [Display(Name = "نام خانوادگی")]
        public string Customers_Family { get; set; }
        /********************************************/

        [Display(Name = "کد ملی")]
        public string Customers_CodeMelli { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( موبایل ) الزامی است.")]
        [Display(Name = "موبایل")]
        public string Customers_Mobile { get; set; }
        /********************************************/

        [Display(Name = "شغل")]
        public string Customers_Job { get; set; }
        /********************************************/

        [Required(AllowEmptyStrings = false, ErrorMessage = "وارد نمودن ( موبایل ) الزامی است.")]
        [Display(Name = "آدرس")]
        public string Customers_Address { get; set; }
        /********************************************/
    }
    public class ViewDataCustomersModel
    {
        // نمایش فیلدهای جدول مشتری
        public string Customers_Name { get; set; }
        public string Customers_Family { get; set; }
        public string Customers_CodeMelli { get; set; }
        public string Customers_Mobile { get; set; }
        public string Customers_Job { get; set; }
        public string Customers_Address { get; set; }
        public DateTime? Customers_DatePublish { get; set; }
    }
}
