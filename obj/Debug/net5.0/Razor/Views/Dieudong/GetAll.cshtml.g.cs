#pragma checksum "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dieudong_GetAll), @"mvc.1.0.view", @"/Views/Dieudong/GetAll.cshtml")]
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
#line 1 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2ec5c7811103fd52b4d5e2bca32cbd3208b35b", @"/Views/Dieudong/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Dieudong_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Areas.Admin.Data.TDieudong>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Không duyệt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Chờ duyệt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Đã duyệt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dieudong", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Partial_Pager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
  
    ViewData["Title"] = "GetAll";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int No = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"mb-3\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 206, "\"", 245, 1);
#nullable restore
#line 11 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
WriteAttributeValue("", 213, Url.Action("GetAll","Dieudong"), 213, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-danger\">\r\n            Gte All \r\n        </a>\r\n\r\n");
#nullable restore
#line 15 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 388, "\"", 469, 1);
#nullable restore
#line 17 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
WriteAttributeValue("", 395, Url.Action("GetAll","Dieudong", new { _Trangthaiduyet = "Không duyệt"  }), 395, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-outline-primary\">\r\n                ");
#nullable restore
#line 18 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
           Write(item.Trangthaiduyet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </a>\r\n");
#nullable restore
#line 20 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
            ////https://localhost:5001/Dieudong?_NgayTh_Tu=2024-01-01&_NgayTh_Den=2026-01-01&_Trangthaiduyet=Kh%C3%B4ng+duy%E1%BB%87t
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b8417", async() => {
                WriteLiteral(@"
        <div class=""row mb-3"">

            <label for=""inputDate"" class=""col-auto col-form-label"" style=""color:darkblue; font-weight:bold"">Lịch điều động từ </label>
            <div class=""col-auto"">
                <input type=""date"" class=""form-control"" name=""_NgayTh_Tu"" required>
            </div>

            <label class=""col-auto col-form-label"" style=""color:darkblue; font-weight:bold"">đến</label>
            <div class=""col-auto"">
                <input type=""date"" class=""form-control"" name=""_NgayTh_Den"" required>
            </div>


            <div class=""col-auto"">
                

                <select class=""form-select"" name=""_Trangthaiduyet"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b9417", async() => {
                    WriteLiteral("\r\n                        <a");
                    BeginWriteAttribute("href", " href=\"", 1542, "\"", 1617, 1);
#nullable restore
#line 42 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
WriteAttributeValue("", 1549, Url.Action("GetAll","Dieudong", new { _Trangthaiduyet="Đã duyệt" }), 1549, 68, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"btn btn-sm btn-outline-primary\">\r\n                        </a>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b11009", async() => {
                    WriteLiteral(" Trạng thái");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b12581", async() => {
                    WriteLiteral("Không duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b13830", async() => {
                    WriteLiteral("Chờ duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b15077", async() => {
                    WriteLiteral("Đã duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </select>\r\n                \r\n                <select class=\"form-select\" name=\"_Trangthaiduyet\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b16451", async() => {
                    WriteLiteral(" Trạng thái");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b18023", async() => {
                    WriteLiteral("Không duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b19272", async() => {
                    WriteLiteral("Chờ duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b20519", async() => {
                    WriteLiteral("Đã duyệt");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                </select>\r\n            </div>\r\n            <div class=\"col-auto\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 2486, "\"", 2582, 2);
#nullable restore
#line 62 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
WriteAttributeValue("", 2493, Url.Action("GetAll","Dieudong", new { _Trangthaiduyet=  ViewBag.Trangthaiduyet }), 2493, 82, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2575, "class=", 2576, 7, true);
                EndWriteAttribute();
                WriteLiteral("btn btn-sm btn-outline-primary\">\r\n                    daxxxxxxxxxxxxxx\r\n                </a>\r\n            </div>\r\n            <div class=\"col-auto\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 2751, "\"", 2826, 1);
#nullable restore
#line 67 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
WriteAttributeValue("", 2758, Url.Action("GetAll","Dieudong", new { _Trangthaiduyet="Đã duyệt" }), 2758, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-sm btn-outline-primary"">
                    Đã
                </a>
            </div>
            <div class=""col-sm-2"">
                <button type=""submit"" class=""btn btn-outline-primary"">Tìm kiếm</button>
            </div>
        </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"




    <table class=""table table-bordered table-hover table-striped"">
        <thead>
            <tr class=""text-center"">
                <th>
                    TT
                </th>
                <th>
                    Đơn vị
                </th>
                <th>
                    Ngày đ.ký
                </th>
                <th>
                    Ngày t/hiện
                </th>
                <th class=""text-center"">
                    Loại xe
                </th>
                <th>
                    Công trình
                </th>
                <th>
                    Công việc
                </th>
                <th>
                    Trạng thái
                </th>

            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 112 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n");
            WriteLiteral("\r\n                        ");
#nullable restore
#line 118 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                    Write(++ViewBag.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 121 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TenDv));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 124 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(item.NgayDk.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 127 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(item.NgayTh.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 130 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tenloaixe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 133 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tenloaicongtrinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 136 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Noidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n");
#nullable restore
#line 139 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                         if (item.Trangthaiduyet == "Đã duyệt")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge rounded-pill bg-success\">");
#nullable restore
#line 141 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                                                                   Write(item.Trangthaiduyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 142 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                         if (item.Trangthaiduyet == "Chờ duyệt")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge rounded-pill bg-warning text-black\">");
#nullable restore
#line 145 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                                                                              Write(item.Trangthaiduyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 146 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                         if (item.Trangthaiduyet == "Không duyệt")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge rounded-pill bg-danger text-white\">");
#nullable restore
#line 149 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                                                                             Write(item.Trangthaiduyet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 150 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b30917", async() => {
                WriteLiteral(" <span style=\"color:blue\">chi tiết </span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
                                                  WriteLiteral(item.DieudongId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 156 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "af2ec5c7811103fd52b4d5e2bca32cbd3208b35b33409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#nullable restore
#line 159 "D:\ASP_NET_CORE\webdieuhanh\WebDieuHanh\Views\Dieudong\GetAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ViewBag.Pager;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Areas.Admin.Data.TDieudong>> Html { get; private set; }
    }
}
#pragma warning restore 1591