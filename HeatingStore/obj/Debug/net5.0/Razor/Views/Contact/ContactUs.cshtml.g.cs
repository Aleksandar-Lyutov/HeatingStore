#pragma checksum "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "949508d6bb71ed984e532b135ad1bd5b9b664c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactUs), @"mvc.1.0.view", @"/Views/Contact/ContactUs.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\_ViewImports.cshtml"
using HeatingStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\_ViewImports.cshtml"
using HeatingStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"949508d6bb71ed984e532b135ad1bd5b9b664c48", @"/Views/Contact/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5258406f354590aa097eef1a5100ea97bd35f1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("gradient-custom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
 if (TempData["MessageSent"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert\">");
#nullable restore
#line 3 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
              Write(TempData["MessageSent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
#nullable restore
#line 3 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949508d6bb71ed984e532b135ad1bd5b9b664c484793", async() => {
                WriteLiteral(@"
    <div class=""contact-container"">
        <div class=""contact-info"">
            <h3>Contact Information</h3>
            <div class=""contact-item"">
                <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Phone_font_awesome.svg/1200px-Phone_font_awesome.svg.png"" alt=""Phone"">
                <a href=""tel:+359882758161"">+359882758161</a>
            </div>
            <div class=""contact-item"">
                <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Envelope_alt_font_awesome.svg/1024px-Envelope_alt_font_awesome.svg.png"" alt=""Mail"">
                <a href=""mailto:sasho.lyutov@gmail.com"">sasho.lyutov@gmail.com</a>
            </div>
            <div class=""contact-item"">
                <img src=""https://cdn.pixabay.com/photo/2021/06/15/12/17/instagram-6338401_1280.png"" alt=""Instagram"">
                <a href=""https://www.instagram.com/alexanderlyutov/"">alexanderlyutov</a>
            </div>
            <div class=""contact-item"">
                <img sr");
                WriteLiteral(@"c=""https://cdn-icons-png.flaticon.com/512/124/124010.png"" alt=""Facebook"">
                <a href=""https://www.facebook.com/profile.php?id=100012376295193"">Alexander Lyutov</a>
            </div>
        </div>

        <div class=""contact-form"">
            <h3>Contact Form</h3>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "949508d6bb71ed984e532b135ad1bd5b9b664c486439", async() => {
                    WriteLiteral("\n                <div class=\"form-group\">\n                    <label for=\"firstName\">First Name</label>\n                    <input type=\"text\" class=\"form-control\" name=\"firstName\" id=\"firstName\"");
                    BeginWriteAttribute("value", " value=\"", 1653, "\"", 1677, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
WriteAttributeValue("", 1661, Model.FirstName, 1661, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required>\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"lastName\">Last Name</label>\n                    <input type=\"text\" class=\"form-control\" name=\"lastName\" id=\"lastName\"");
                    BeginWriteAttribute("value", " value=\"", 1902, "\"", 1925, 1);
#nullable restore
#line 35 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
WriteAttributeValue("", 1910, Model.LastName, 1910, 15, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required>\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"email\">Email</label>\n                    <input type=\"email\" class=\"form-control\" name=\"email\" id=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 2138, "\"", 2158, 1);
#nullable restore
#line 39 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
WriteAttributeValue("", 2146, Model.Email, 2146, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required>\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"comment\">Comment</label>\n                    <textarea class=\"form-control\" name=\"comment\" id=\"comment\" required>");
#nullable restore
#line 43 "C:\Users\User\Desktop\Александър Лютов\HeatingStore\HeatingStore\Views\Contact\ContactUs.cshtml"
                                                                                   Write(Model.Comment);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</textarea>\n                </div>\n                <button type=\"submit\" class=\"btn btn-primary\">Send</button>\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <style>
        .create-new-btn {
            background-color: #fe90d2;
            color: white;
            text-decoration: none;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            text-decoration: none;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .create-new-btn:hover {
                background-color: #ff6fba;
                text-decoration: none;
                color: black;
            }

            .create-new-btn:focus {
                outline: none;
            }

        .gradient-custom {
            background: linear-gradient(to bottom, #fe90d2, #fefa3f);
        }

        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
        }

        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        .body-container {
            max-width: 1160px;
            margin: 0 auto;
            pa");
            WriteLiteral(@"dding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
        }

        .container {
            width: 80%;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
        }

        .contact-container {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
        }

        .contact-info {
            border: 2px solid #ddd;
            padding: 20px;
            text-align: center;
            background-color: white;
            border-radius: 10px;
            margin: 20px;
            flex: 1;
            max-width: 500px;
        }

            .contact-info h3 {
                font-size: 24px;
                margin-bottom: 20px;
                color: #333;
                ");
            WriteLiteral(@"text-transform: uppercase;
            }

        .contact-item {
            font-size: 16px;
            margin-bottom: 10px;
            color: #666;
            line-height: 1.5;
            display: flex;
            align-items: center;
        }

            .contact-item img {
                width: 20px;
                height: 20px;
                margin-right: 10px;
            }

            .contact-item a {
                color: #333;
                text-decoration: none;
            }

                .contact-item a:hover {
                    color: #555;
                }

        .contact-form {
            border: 2px solid #ddd;
            padding: 20px;
            text-align: center;
            background-color: white;
            border-radius: 10px;
            margin: 20px;
            flex: 1;
            max-width: 500px;
        }

            .contact-form h3 {
                font-size: 24px;
                margin-bottom: 20px;
                color: #333;
                ");
            WriteLiteral(@"text-transform: uppercase;
            }

        .form-group {
            margin-bottom: 20px;
            text-align: left;
        }

            .form-group label {
                display: block;
                margin-bottom: 5px;
                color: #333;
                font-weight: bold;
            }

        .form-control {
            width: 100%;
            padding: 10px;
        }
    </style>
");
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