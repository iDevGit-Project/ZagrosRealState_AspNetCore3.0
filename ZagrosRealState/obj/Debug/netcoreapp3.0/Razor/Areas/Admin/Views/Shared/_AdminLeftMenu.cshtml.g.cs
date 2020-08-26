#pragma checksum "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Shared\_AdminLeftMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c021f111db8ba9d09a10226797608866371d08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLeftMenu), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLeftMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Shared\_ViewImports.cshtml"
using ZagrosRealState;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Shared\_ViewImports.cshtml"
using ZagrosRealState.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c021f111db8ba9d09a10226797608866371d08b", @"/Areas/Admin/Views/Shared/_AdminLeftMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2dc5e82b4e9344c9cabbbdf7fbdba6d6c9d2df3", @"/Areas/Admin/Views/Shared/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__AdminLeftMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"slimscroll-menu\">\r\n\r\n    <!--- Sidemenu -->\r\n    <div id=\"sidebar-menu\">\r\n        <ul class=\"metismenu\" id=\"side-menu\">\r\n            <li class=\"mm-active\">\r\n                <a href=\"/Admin/Home/Index\">\r\n");
            WriteLiteral(@"                    <i class=""icon-home""></i>
                    <span> پیشخوان </span>
                </a>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-plus""></i>
                    <span>ثبت اطلاعات پایه </span>
                    <span class=""menu-arrow""></span>
                </a>
                <ul class=""nav-second-level"" aria-expanded=""false"">
                    <li>
                        <a href=""/Admin/Apartment/Create""> آپارتمان</a>
                    </li>
                    <li>
                        <a href=""/Admin/House/Create""> منزل</a>
                    </li>
                    <li>
                        <a href=""/Admin/Shop/Create"">مغازه</a>
                    </li>
                    <li>
                        <a href=""/Admin/ByeSell/Create"">خرید و فروش</a>
                    </li>
                    <li>
                        <a href=""/Admin/Customers/Create""> مشتریان");
            WriteLiteral(@"</a>
                    </li>
                    <li>
                        <a href=""/Admin/Willing/Create""> خواهان</a>
                    </li>
                </ul>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-layers""></i>
                    <span> مدیریت اطلاعات </span>
                    <span class=""menu-arrow""></span>
                </a>
                <ul class=""nav-second-level"" aria-expanded=""false"">
                    <li>
                        <a href=""/Admin/Apartment/Read""> اطلاعات آپارتمان</a>
                    </li>
                    <li>
                        <a href=""/Admin/House/Read""> اطلاعات منزل</a>
                    </li>
                    <li>
                        <a href=""/Admin/Shop/Read""> اطلاعات مغازه</a>
                    </li>
                    <li>
                        <a href=""/Admin/ByeSell/Read"">اطلاعات خرید و فروش</a>
                    </li>
 ");
            WriteLiteral(@"                   <li>
                        <a href=""/Admin/Customers/Read""> اطلاعات مشتریان</a>
                    </li>
                    <li>
                        <a href=""/Admin/Willing/Read""> اطلاعات خواهان</a>
                    </li>
                </ul>
            </li>
            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-envelope""></i>
                    <span class=""menu-arrow""></span>
                    <span> مدیریت پیام ها </span>
                </a>
                <ul class=""nav-second-level"" aria-expanded=""false"">
                    <li>
                        <a href=""#""> ارسال پیامک</a>
                    </li>
                    <li>
                        <a href=""#"">ارسال ایمیل</a>
                    </li>
                </ul>
            </li>
            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-speech""></i>
                    <span> مدیریت اخبار");
            WriteLiteral(@" </span>
                </a>
            </li>
            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-user-following""></i>
                    <span> مدیریت نقش ها </span>
                </a>
            </li>
            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-note""></i>
                    <span> مدیریت نظرات </span>
                </a>
            </li>
            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-printer""></i>
                    <span> گزارشات </span>
                </a>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-clock""></i>
                    <span class=""menu-arrow""></span>
                    <span> فعالیت های کاربران </span>
                </a>
                <ul class=""nav-second-level"" aria-expanded=""false"">
                    <li>
         ");
            WriteLiteral(@"               <a href=""#""> کاربران پایه</a>
                    </li>
                    <li>
                        <a href=""#""> کاربران پیشرفته </a>
                    </li>
                    <li>
                        <a href=""#""> کلیه کاربران </a>
                    </li>
                </ul>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-people""></i>
                    <span class=""badge badge-info float-right"">1</span>
                    <span> مدیریت کاربران </span>
                </a>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-location-pin""></i>
                    <span> نقشه ها </span>
                </a>

            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-pencil""></i>
                    <span> یادداشت ها </span>
                </a>
       ");
            WriteLiteral(@"     </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-screen-desktop""></i>
                    <span> پروفایل من </span>
                </a>
            </li>

            <li>
                <a href=""javascript: void(0);"">
                    <i class=""icon-power""></i>
                    <span> خروج از سیستم </span>
                </a>
            </li>

        </ul>

    </div>
    <!-- End Sidebar -->

    <div class=""clearfix""></div>

</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
