#pragma checksum "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\User\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e8c5aaf35f9ec1a8e1b08a4d6b00fbf70e6eab0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Dashboard), @"mvc.1.0.view", @"/Views/User/Dashboard.cshtml")]
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
#line 1 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\_ViewImports.cshtml"
using BlogIt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\_ViewImports.cshtml"
using BlogIt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e8c5aaf35f9ec1a8e1b08a4d6b00fbf70e6eab0", @"/Views/User/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e5d687f11f1595049ebebf82e912346b348ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogIt.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\User\Dashboard.cshtml"
  
    Layout = "~/Views/Shared/_Layout1.cshtml";

    User user = ViewBag.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e8c5aaf35f9ec1a8e1b08a4d6b00fbf70e6eab04136", async() => {
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
            WriteLiteral("\r\n\r\n");
            DefineSection("Navbar", async() => {
                WriteLiteral("\r\n    \r\n");
            }
            );
            WriteLiteral(@"
<div class=""row font-jost gx-0"">
    <div style=""z-index: 1; height: 100vh;"" class=""bg-seperator-90 d-none d-sm-block position-sticky top-0 start-0 col-3"">
        <div class=""d-flex pt-5 flex-column justify-content-evenly h-100"">
            <div class=""text-center text-light mx-seperator-90-auto"">
                <img");
            BeginWriteAttribute("src", " src=\"", 650, "\"", 675, 1);
#nullable restore
#line 23 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\User\Dashboard.cshtml"
WriteAttributeValue("", 656, user.ProfilePicUrl, 656, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"br-50p mx-auto d-block\" width=\"50%\" style=\"aspect-ratio: 1/1;\" />\r\n                <p class=\"fs-5 mt-3\">");
#nullable restore
#line 24 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\User\Dashboard.cshtml"
                                Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""mt-0 text-secondary"">
                <div onclick=""window.location.href='/user/dashboard'"" class=""sidebar-action active-action"">
                    <i class=""material-icons pe-3"">dashboard</i>
                    Explore
                </div>
                <div onclick=""window.location.href='/blog/create'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">&#xe147;</i>
                    Create Blog
                </div>
                <div class=""sidebar-action"">
                    <i class=""material-icons pe-3"">&#xe2bf;</i>
                    Saved Blogs
                </div>
                <div class=""sidebar-action"">
                    <i class=""material-icons pe-3"">bookmark</i>
                    My Blogs
                </div>
            </div>
            <div class=""text-secondary"">
                <div class=""sidebar-action"">
                    <i class=""material-icons pe-3"">&#xe853;</i>
   ");
            WriteLiteral(@"                 Edit Profile
                </div>
                <div onclick=""window.location.href='/user/logout'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">logout</i>
                    Log Out
                </div>
            </div>
        </div>
    </div>
    <div style=""z-index: 1;"" class=""bg-orange d-sm-none col-12 border-orange border""></div>
    <div style=""height: 200vh;"" class=""col-9""></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogIt.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591