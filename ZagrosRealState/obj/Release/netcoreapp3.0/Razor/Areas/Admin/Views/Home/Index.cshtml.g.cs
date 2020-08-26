#pragma checksum "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "573ed801307263e427a1b07866ff8842ae2bec24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"573ed801307263e427a1b07866ff8842ae2bec24", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ZagrosRealState.ViewModels.Views.ViewDataApartmentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropzone-DATE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "سامانه اسناد املاک زاگرس | پنل مدیریت";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n\r\n    <!-- start page title -->\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <div class=\"page-title-box\">\r\n                <div class=\"page-title-right\">\r\n                </div>\r\n");
            WriteLiteral(@"            </div>
            <br />
        </div>
    </div>
    <!-- end page title -->
    <div class=""row"">

        <div class=""col-xl-3"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات آپارتمان ها</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
");
            WriteLiteral(@"                        <a href=""/Admin/Apartment/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>

                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 44 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsApartment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات منزل</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""/Admin/House/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 63 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsHouse"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-xl-3"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات خرید و فروش ها</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""/Admin/ByeSell/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 84 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsByeSell"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات مغازه ها</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""/Admin/Shop/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 102 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsShop"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-xl-3"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات مشتریان</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""/Admin/Customers/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 123 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsCustomers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">جزئیات خواهان</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""/Admin/Willing/Read"" class=""dropdown-item"">نمایش کلیه اطلاعات</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""slimScrollDiv col-sm-12"">
                        ");
#nullable restore
#line 141 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("_DetailsWilling"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-xl-3\">\r\n            <div class=\"card-box ribbon-box\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "573ed801307263e427a1b07866ff8842ae2bec2411981", async() => {
                WriteLiteral("\r\n                    <div class=\"dz-message needsclick\">\r\n                        <i class=\"h1 text-muted mdi mdi-calendar-blank-outline\"></i>\r\n                        <br />\r\n                        <span class=\"text-muted font-15\"> ");
#nullable restore
#line 152 "C:\Users\iDevTeam\Desktop\Project\WebProject\Zagros RealState\RealState\ZagrosRealState\Areas\Admin\Views\Home\Index.cshtml"
                                                     Write(convertDate.ConvertMiladiToShamsi(DateTime.Now, "dddd d MMMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>

        </div>
        <div class=""col-xl-6"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">مدیریت کاربران</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""javascript:void(0);"" class=""dropdown-item"">نمایش کلیه کاربران</a>
                        <!-- item-->
                    </div>
                </div>
                <div class=""ribbon-content"">
                    <div class=""col-sm-12"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <ol class=""breadcrumb"">
             ");
            WriteLiteral(@"                       <li class=""active"">در حال حاظر هیچ داده ای جهت نمایش وجود ندارد...!</li>
                                </ol>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class=""col-xl-6"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">مدیریت پیام ها</div>
                <div class=""dropdown float-right"">
                    <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                        <i class=""mdi mdi-dots-horizontal""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <!-- item-->
                        <a href=""javascript:void(0);"" class=""dropdown-item"">نمایش کلیه پیام ها</a>
                        <!-- item-->
                    </div>
                </div>
   ");
            WriteLiteral(@"             <div class=""ribbon-content"">
                    <div class=""col-sm-12"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <ol class=""breadcrumb"">
                                    <li class=""active"">در حال حاظر هیچ داده ای جهت نمایش وجود ندارد...!</li>
                                </ol>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>

        <div class=""col-xl-12"">
            <div class=""card-box ribbon-box"">
                <div class=""ribbon ribbon-primary float-left"">آمار بازدید در 10 روز گذشته</div>
                <div class=""ribbon-content"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""mt-4"">
                                <div id=""chart-with-area"" class=""ct-chart ct-golden-section"">
                  ");
            WriteLiteral("              </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ZagrosRealState.Common.PublicClasses.ConvertDate convertDate { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ZagrosRealState.ViewModels.Views.ViewDataApartmentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591