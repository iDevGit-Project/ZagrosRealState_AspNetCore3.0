using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZagrosRealState.ViewModels.Views
{
    public class UserViewModel
    {
    }

    public class RegisterViewModel
    {

        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا نام خود را وارد کنید.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "نام شما باید حداقل 2 و حداکثر 50 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string firstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا نام خانوادگی خود را وارد کنید.")]
        [StringLength(maximumLength: 250, MinimumLength = 2, ErrorMessage = "نام خانوادگی شما باید حداقل 2 و حداکثر 250 کاراکتر باشد.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string family { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا یک نام کاربری وارد کنید.")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کاراکترهای غیرمجاز استفاده شده است.")]
        public string UserName { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا شماره تماس خود را وارد نمایید.")]
        [MinLength(11, ErrorMessage = "شماره تماس باید 11 رقمی باشد")]
        [MaxLength(11)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "فرمت شماره موبایل صحیح نیست")]
        public string PhoneNumber { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا رمز عبور را وارد کنید.")]
        [StringLength(maximumLength: 30, MinimumLength = 6, ErrorMessage = "رمز عبور باید حداقل 6 و حداکثر 30 کاراکتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفا تکرار رمز عبور را وارد کنید.")]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار آن یکسان نیست")]
        public string confirmPassword { get; set; }

    }
}
