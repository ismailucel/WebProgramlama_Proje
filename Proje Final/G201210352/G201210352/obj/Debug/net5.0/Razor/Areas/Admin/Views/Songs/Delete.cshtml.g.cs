#pragma checksum "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1020629a751108b64391aa6ea1910ad3ac6944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Songs_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Songs/Delete.cshtml")]
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
#line 1 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using G201210352.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\_ViewImports.cshtml"
using G201210352.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b1020629a751108b64391aa6ea1910ad3ac6944", @"/Areas/Admin/Views/Songs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f69c1612f5aa4789f5d76f2d967e6b2d910b53", @"/Areas/Admin/Views/Songs/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Songs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<G201210352.Models.Song>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
   ViewData["Title"] = lang["Baslik"].Value; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
     if (Model.Active == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 10 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
Write(lang["Deaktiflestir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> ");
#nullable restore
#line 10 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
                                }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>");
#nullable restore
#line 13 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
Write(lang["Aktiflestir"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
#nullable restore
#line 13 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    <div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 19 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SongName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 22 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SongName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 25 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 28 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 31 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 37 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 40 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 43 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PublishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 46 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PublishYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 49 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 52 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n");
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 61 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ArtistId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 64 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Artist.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 67 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 70 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 73 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b1020629a751108b64391aa6ea1910ad3ac694413513", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2694, "~/images/", 2694, 9, true);
#nullable restore
#line 76 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 2703, Model.FirstPhoto, 2703, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 79 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.SecondPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b1020629a751108b64391aa6ea1910ad3ac694415624", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2964, "~/images/", 2964, 9, true);
#nullable restore
#line 82 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 2973, Model.SecondPhoto, 2973, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 85 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ThirdPhoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b1020629a751108b64391aa6ea1910ad3ac694417735", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3234, "~/images/", 3234, 9, true);
#nullable restore
#line 88 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
AddHtmlAttributeValue("", 3243, Model.ThirdPhoto, 3243, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1020629a751108b64391aa6ea1910ad3ac694419533", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b1020629a751108b64391aa6ea1910ad3ac694419812", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 94 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
                     if (Model.Active == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3576, "\"", 3600, 1);
#nullable restore
#line 97 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3584, lang["Deaktif"], 3584, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" /> ");
#nullable restore
#line 97 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
                                                                                          }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3678, "\"", 3700, 1);
#nullable restore
#line 100 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3686, lang["Aktif"], 3686, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-danger\" />");
#nullable restore
#line 100 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
                                                                               }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1020629a751108b64391aa6ea1910ad3ac694424645", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 3954, "\"", 3981, 1);
#nullable restore
#line 106 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Admin\Views\Songs\Delete.cshtml"
WriteAttributeValue("", 3962, lang["ListeyeDon"], 3962, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-primary\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<G201210352.lang> lang { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<G201210352.Models.Song> Html { get; private set; }
    }
}
#pragma warning restore 1591
