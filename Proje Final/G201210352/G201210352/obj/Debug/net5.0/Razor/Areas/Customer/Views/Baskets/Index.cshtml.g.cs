#pragma checksum "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Baskets_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Baskets/Index.cshtml")]
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
#line 1 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\_ViewImports.cshtml"
using G201210352.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\_ViewImports.cshtml"
using G201210352.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb0", @"/Areas/Customer/Views/Baskets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79f69c1612f5aa4789f5d76f2d967e6b2d910b53", @"/Areas/Customer/Views/Baskets/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Baskets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<G201210352.Models.BasketItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width : 250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SongDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Baskets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuySongs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
   ViewData["Title"] = "Emusic"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"static about-sec\">\n    <div class=\"container\">\n");
#nullable restore
#line 12 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
         if (TempData["SiparisMesaj"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    <h4>");
#nullable restore
#line 15 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
   Write(TempData["SiparisMesaj"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n</div>\n                <div class=\"row\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb08988", async() => {
                WriteLiteral("\n                        <div class=\"form-group\">\n                            <input type=\"submit\"");
                BeginWriteAttribute("value", " value=", 739, "", 766, 1);
#nullable restore
#line 20 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
WriteAttributeValue("", 746, lang["AnasayfaDon"], 746, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-block btn-primary\" />\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div> ");
#nullable restore
#line 23 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Sepetim</h2>\n                <div class=\"recent-book-sec\">\n                    <div class=\"row\">\n");
#nullable restore
#line 29 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                         if (Model != null)
                        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
 foreach (var _basket in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-3\">\n    <div class=\"item m-5 p-5\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb012625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1232, "~/images/", 1232, 9, true);
#nullable restore
#line 37 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
AddHtmlAttributeValue("", 1241, _basket.Song.FirstPhoto, 1241, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb014319", async() => {
#nullable restore
#line 38 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                                                                          Write(_basket.Song.SongName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                                                      WriteLiteral(_basket.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-searchId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\n        <h6><span class=\"price\">");
#nullable restore
#line 39 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                           Write(_basket.Song.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tl</span> / ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb017346", async() => {
                WriteLiteral("Sepetten Kaldır");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-songId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                                                                                                                                    WriteLiteral(_basket.Song.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["songId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-songId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["songId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\n    </div>\n</div>");
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
         }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"margin-left:50px;\">Sepet Boş</p>");
#nullable restore
#line 44 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                </div>\n");
#nullable restore
#line 47 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                 if (Model != null)
                                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                 if (Model.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51807ca40ed8befcfaaf1cc1ffa424d7a1eb5cb021665", async() => {
                WriteLiteral("\n        <div class=\"btn-sec\">\n            <span>");
#nullable restore
#line 54 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
             Write(lang["ToplamFiyat"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<span>");
#nullable restore
#line 54 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                       Write(ViewData["ToplamFiyat"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\n            <button name=\"basketId\"");
                BeginWriteAttribute("value", " value=\"", 2161, "\"", 2190, 1);
#nullable restore
#line 55 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
WriteAttributeValue("", 2169, ViewData["BasketID"], 2169, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left : 20px;\" class=\"btn black\">");
#nullable restore
#line 55 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
                                                                                                           Write(lang["OdemeGec"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
#nullable restore
#line 58 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\İSMAİL\Desktop\WEB PROJEM\YEDEK\G201210352\G201210352\Areas\Customer\Views\Baskets\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</section>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<G201210352.lang> lang { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<G201210352.Data.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<G201210352.Models.BasketItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
