#pragma checksum "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\Shared\_Partial_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8125c0449280a79407c094e3008d342c10b8490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Partial_Header), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Partial_Header.cshtml")]
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
#line 1 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\Shared\_Partial_Header.cshtml"
using WebApp.Areas.Admin.Public;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8125c0449280a79407c094e3008d342c10b8490", @"/Areas/Admin/Views/Shared/_Partial_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Partial_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assetsAdmin/img/profile-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<header id=\"header\" class=\"header fixed-top d-flex align-items-center\">\r\n\r\n    <div class=\"d-flex align-items-center justify-content-between\">\r\n        <a href=\"index.html\" class=\"logo d-flex align-items-center\">\r\n");
            WriteLiteral("            <span class=\"d-none d-lg-block\">");
#nullable restore
#line 8 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\Shared\_Partial_Header.cshtml"
                                       Write(ClsPublic._Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
        </a>
        <i class=""bi bi-list toggle-sidebar-btn""></i>
    </div><!-- End Logo -->


    <nav class=""header-nav ms-auto"">
        <ul class=""d-flex align-items-center"">


            <li class=""nav-item dropdown pe-3"">

                <a class=""nav-link nav-profile d-flex align-items-center pe-0"" href=""#"" data-bs-toggle=""dropdown"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8125c0449280a79407c094e3008d342c10b84905444", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <span class=\"d-none d-md-block dropdown-toggle ps-2\"> ");
#nullable restore
#line 22 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Areas\Admin\Views\Shared\_Partial_Header.cshtml"
                                                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                </a><!-- End Profile Iamge Icon -->

                <ul class=""dropdown-menu dropdown-menu-end dropdown-menu-arrow profile"">
                    <li class=""dropdown-header"">
                        <h6>Setting</h6>
                    </li>
                    <li>
                        <hr class=""dropdown-divider"">
                    </li>

                    <li>
                        <hr class=""dropdown-divider"">
                    </li>

                    <li>
                        <a class=""dropdown-item d-flex align-items-center"" href=""users-profile.html"">
                            <i class=""bi bi-gear""></i>
                            <span>Change Pass</span>
                        </a>
                    </li>
                    <li>
                        <hr class=""dropdown-divider"">
                    </li>


                    <li>
                        <a class=""dropdown-item d-flex align-items-center"" href=""/admin/user/log");
            WriteLiteral(@"in"">
                            <i class=""bi bi-box-arrow-right""></i>
                            <span>Sign Out</span>
                        </a>
                    </li>

                </ul><!-- End Profile Dropdown Items -->
            </li><!-- End Profile Nav -->

        </ul>
    </nav><!-- End Icons Navigation -->

</header>
<!-- End Header -->");
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