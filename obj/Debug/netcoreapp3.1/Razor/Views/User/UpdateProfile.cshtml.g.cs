#pragma checksum "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369e5c9288f8e0c2354a1c7a89a0cbcfe86cedd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UpdateProfile), @"mvc.1.0.view", @"/Views/User/UpdateProfile.cshtml")]
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
#line 1 "S:\WAD\BlogWebsite\Views\_ViewImports.cshtml"
using BlogIt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\WAD\BlogWebsite\Views\_ViewImports.cshtml"
using BlogIt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369e5c9288f8e0c2354a1c7a89a0cbcfe86cedd7", @"/Views/User/UpdateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e5d687f11f1595049ebebf82e912346b348ce9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UpdateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout1.cshtml";
    User User = ViewBag.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "369e5c9288f8e0c2354a1c7a89a0cbcfe86cedd74913", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("navbar", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""row font-jost gx-0"">
    <div style=""z-index: 1; height: 100vh;"" class=""bg-seperator-90 d-none d-sm-block position-sticky top-0 start-0 col-3"">
        <div class=""d-flex pt-5 flex-column justify-content-evenly h-100"">
            <div class=""text-center text-light mx-seperator-90-auto"">
                <img");
            BeginWriteAttribute("src", " src=", 486, "", 524, 1);
#nullable restore
#line 14 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
WriteAttributeValue("", 491, Url.Content(@User.ProfilePicUrl), 491, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"br-50p mx-auto d-block\" width=\"50%\" style=\"aspect-ratio: 1/1;\" />\r\n                <p class=\"fs-5 mt-3\">");
#nullable restore
#line 15 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
                                Write(User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""mt-0 text-secondary"">
                <div onclick=""window.location.href='/blog/explore'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">dashboard</i>
                    Explore
                </div>
                <div onclick=""window.location.href='/blog/create'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">&#xe147;</i>
                    Create Blog
                </div>
                <div class=""sidebar-action"" onclick=""window.location.href='/blog/savedBlogs'"">
                    <i class=""material-icons pe-3"">&#xe2bf;</i>
                    Saved Blogs
                </div>
                <div class=""sidebar-action"">
                    <i class=""material-icons pe-3"">bookmark</i>
                    My Blogs
                </div>
            </div>
            <div class=""text-secondary"">
                <div class=""sidebar-action active-action"">
                    ");
            WriteLiteral(@"<i class=""material-icons pe-3"">&#xe853;</i>
                    Edit Profile
                </div>
                <div onclick=""window.location.href='/user/logout'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">logout</i>
                    Log Out
                </div>
            </div>
        </div>
    </div>
    <div style=""z-index: 1;"" class=""bg-orange d-sm-none col-12 border-orange border""></div>
    <div class=""col-9"">
        <center><img");
            BeginWriteAttribute("src", " src=\"", 2167, "\"", 2206, 1);
#nullable restore
#line 49 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
WriteAttributeValue("", 2173, Url.Content(@User.ProfilePicUrl), 2173, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"aspect-ratio: 1/1;border-radius:50%;width:10%;margin-top:130px\" /></center>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "369e5c9288f8e0c2354a1c7a89a0cbcfe86cedd79245", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2394, "\"", 2410, 1);
#nullable restore
#line 51 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
WriteAttributeValue("", 2402, User.Id, 2402, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <center><input type=""file"" name=""profilePic"" class=""form-control my-5"" style=""width:22%"" /></center>
            <div class=""row my-5 mx-5"">
                <div class=""col-3""></div>
                <div class=""col-1 my-1"">
                    <b>Name : </b>
                </div>
                <div class=""col-5"">
                    <input type=""text"" class=""form-control"" style=""vertical-align:middle"" name=""name""");
                BeginWriteAttribute("value", " value=\"", 2854, "\"", 2872, 1);
#nullable restore
#line 59 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
WriteAttributeValue("", 2862, User.Name, 2862, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                </div>
            </div>

            <div class=""row mx-5 my-5"">
                <div class=""col-3""></div>
                <div class=""col-1 my-1"">
                    <b>Password: </b>
                </div>
                <div class=""col-5"">
                    <input type=""text"" style=""vertical-align:middle"" class=""form-control"" name=""password""");
                BeginWriteAttribute("value", " value=\"", 3254, "\"", 3276, 1);
#nullable restore
#line 69 "S:\WAD\BlogWebsite\Views\User\UpdateProfile.cshtml"
WriteAttributeValue("", 3262, User.Password, 3262, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                </div>\r\n            </div>\r\n\r\n            <center><button class=\"btn bg-orange my-3\" style=\"border-radius:5px\" type = \"submit\">Update</button></center>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
