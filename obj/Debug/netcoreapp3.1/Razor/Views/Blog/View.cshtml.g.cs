#pragma checksum "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6725936ac0428dd69dd6addad6f99ec5a6c9afd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_View), @"mvc.1.0.view", @"/Views/Blog/View.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6725936ac0428dd69dd6addad6f99ec5a6c9afd9", @"/Views/Blog/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e5d687f11f1595049ebebf82e912346b348ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 4 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
  
    User User = ViewBag.user;
    Blog blog = ViewBag.blog;
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("navbar", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6725936ac0428dd69dd6addad6f99ec5a6c9afd94213", async() => {
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
            WriteLiteral(@"

<div class=""row font-jost gx-0"">
    <div style=""z-index: 1; height: 100vh;"" class=""bg-seperator-90 d-none d-sm-block position-sticky top-0 start-0 col-3"">
        <div class=""d-flex pt-5 flex-column justify-content-evenly h-100"">
            <div class=""text-center text-light mx-seperator-90-auto"">
                <img");
            BeginWriteAttribute("src", " src=\"", 644, "\"", 669, 1);
#nullable restore
#line 20 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
WriteAttributeValue("", 650, User.ProfilePicUrl, 650, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"br-50p mx-auto d-block\" width=\"50%\" style=\"aspect-ratio: 1/1;\" />\r\n                <p class=\"fs-5 mt-3\">");
#nullable restore
#line 21 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
                                Write(User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            <div class=""mt-0 text-secondary"">
                <div onclick=""window.location.href='/user/dashboard'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">dashboard</i>
                    Explore
                </div>
                <div onclick=""window.location.href='/blog/create'"" class=""sidebar-action active-action"">
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

    <div class=""p-5 col-9"">
        <div class=""blog-image pt-4"">
            <h2 class=""fw-bold my-5 text-center"">
                ");
#nullable restore
#line 58 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
           Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h2>\r\n            <div class=\"blog-image\">\r\n                <img id=\"blog-image\"");
            BeginWriteAttribute("src", " src=\"", 2463, "\"", 2488, 1);
#nullable restore
#line 61 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
WriteAttributeValue("", 2469, blog.TitleImageUrl, 2469, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""br-10 mx-auto d-block"" width=""1000"" style=""aspect-ratio: 5/2;"" />
            </div>
            <img class=""br-50p mx-auto my-4 border-orange border d-block"" width=""50"" style=""aspect-ratio: 1/1;"" />

            <h6 class=""text-center text-secondary"">
                Written By ");
#nullable restore
#line 66 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
                      Write(User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h6>

            <div id=""blog-content"" class=""main-content text-start text-dark pt-5"">

            </div>
        </div>
    </div>
</div>

<script>
    function htmlDecode(input) {
        var doc = new DOMParser().parseFromString(input, ""text/html"");
        return doc.documentElement.textContent;
    }
    document.getElementById(""blog-content"").innerHTML = """" + htmlDecode(`");
#nullable restore
#line 81 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\View.cshtml"
                                                                    Write(blog.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("`);\r\n</script>\r\n\r\n");
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