#pragma checksum "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dda696bfb967adb2452a3fbdbc849051026ba3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Explore), @"mvc.1.0.view", @"/Views/Blog/Explore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dda696bfb967adb2452a3fbdbc849051026ba3d", @"/Views/Blog/Explore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e5d687f11f1595049ebebf82e912346b348ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Explore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/blog.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FilterClicked", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
  
    Layout = "~/Views/Shared/_Layout1.cshtml";
    User User = ViewBag.User;
    IEnumerable<Blog> blogs = ViewBag.blogs;
    IEnumerable<Category> categories = ViewBag.category;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7dda696bfb967adb2452a3fbdbc849051026ba3d5452", async() => {
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
            BeginWriteAttribute("src", " src=", 590, "", 628, 1);
#nullable restore
#line 16 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue("", 595, Url.Content(@User.ProfilePicUrl), 595, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"br-50p mx-auto d-block\" width=\"50%\" style=\"aspect-ratio: 1/1; object-fit: cover;\" />\r\n                <p class=\"fs-5 mt-3\">");
#nullable restore
#line 17 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                Write(User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"mt-0 text-secondary\">\r\n                <div onclick=\"window.location.href=\'/blog/explore\'\"");
            BeginWriteAttribute("class", " class=\"", 909, "\"", 985, 2);
            WriteAttributeValue("", 917, "sidebar-action", 917, 14, true);
#nullable restore
#line 20 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue(" ", 931, (ViewBag.IsExplore != null) ? "active-action" : "", 932, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""material-icons pe-3"">dashboard</i>
                    Explore
                </div>
                <div onclick=""window.location.href='/blog/create'"" class=""sidebar-action"">
                    <i class=""material-icons pe-3"">&#xe147;</i>
                    Create Blog
                </div>
                <div");
            BeginWriteAttribute("class", " class=\"", 1342, "\"", 1421, 2);
            WriteAttributeValue("", 1350, "sidebar-action", 1350, 14, true);
#nullable restore
#line 28 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue(" ", 1364, (ViewBag.IsSavedBlogs != null) ? "active-action" : "", 1365, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"window.location.href=\'/blog/savedBlogs\'\">\r\n                    <i class=\"material-icons pe-3\">&#xe2bf;</i>\r\n                    Saved Blogs\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1617, "\"", 1692, 2);
            WriteAttributeValue("", 1625, "sidebar-action", 1625, 14, true);
#nullable restore
#line 32 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue(" ", 1639, (ViewBag.IsMyBlog != null) ? "active-action" : "", 1640, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""window.location.href='/blog/myBlog'"">
                    <i class=""material-icons pe-3"">bookmark</i>
                    My Blogs
                </div>
            </div>
            <div class=""text-secondary"">
                <div class=""sidebar-action"" onclick=""window.location.href='/user/updateProfile'"">
                    <i class=""material-icons pe-3"">&#xe853;</i>
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
    <div style=""height: 200vh;"" class=""col-9"">
            <div class=""blog-image pt-4 mt-5"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dda696bfb967adb2452a3fbdbc849051026ba3d10938", async() => {
                WriteLiteral(@"
                    <div class=""row gx-0"">
                        <div class=""col-1""></div>
                        <div class=""col-4"">
                            <select id=""category-writer"" class=""custom-select form-select form-select-md mx-2 my-1"" name=""category"" ");
                WriteLiteral(">\r\n");
#nullable restore
#line 57 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                 if (ViewBag.categorySelected == "0") {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dda696bfb967adb2452a3fbdbc849051026ba3d11823", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
                WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                }
                                else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dda696bfb967adb2452a3fbdbc849051026ba3d13672", async() => {
                    WriteLiteral("All");
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
                WriteLiteral("\r\n");
#nullable restore
#line 62 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 64 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                 foreach(var item in categories) {
                                    if (ViewBag.categoryText != null && item.type == ViewBag.categoryText)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dda696bfb967adb2452a3fbdbc849051026ba3d15583", async() => {
#nullable restore
#line 67 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                      Write(item.type);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
                WriteLiteral("                          \r\n");
#nullable restore
#line 68 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dda696bfb967adb2452a3fbdbc849051026ba3d18196", async() => {
#nullable restore
#line 71 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                         Write(item.type);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("           \r\n");
#nullable restore
#line 72 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </select>\r\n                        </div>\r\n                 \r\n                        <div class=\"col-5 \">\r\n                            <input class=\"form-control me-2\" type=\"search\" name=\"nameTitle\"");
                BeginWriteAttribute("value", " value=\"", 4164, "\"", 4191, 1);
#nullable restore
#line 78 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue("", 4172, ViewBag.searchText, 4172, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Search By Author and Title"" aria-label=""Search"">
                        </div>

                        <div class=""col-1"">
                            <button class=""btn bg-orange"" type=""submit"">Filter</button>
                        </div>
                    
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 88 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                 foreach (var item in blogs)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"mx-5 px-5\">\r\n                        <hr />\r\n\r\n                         <div class=\"row pt-3\" >\r\n                            <div class=\"col-1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=", 4810, "", 4855, 1);
#nullable restore
#line 95 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue("", 4815, Url.Content(@item.Author.ProfilePicUrl), 4815, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50%\" style=\"aspect-ratio: 1/1; object-fit: cover; border-radius: 50%;\" />\r\n                            </div>\r\n                            <div class=\"col-3 my-1\" style=\"font-size:30;margin-left:-30px\">\r\n                                ");
#nullable restore
#line 98 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                           Write(item.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-8 text-end\" style=\"font-size:10\">\r\n\r\n");
#nullable restore
#line 102 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                 if (ViewBag.IsSavedBlogs == null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                     if (item.SavedBlogs.Where(e => e.UserId == User.Id).Count() != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"material-icons me-3\" style=\"font-size:5;vertical-align:middle;color:var(--secondary);cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5631, "\"", 5667, 3);
            WriteAttributeValue("", 5641, "UnsaveBlog(this,", 5641, 16, true);
#nullable restore
#line 106 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue(" ", 5657, item.Id, 5658, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5666, ")", 5666, 1, true);
            EndWriteAttribute();
            WriteLiteral(">bookmark</i>\r\n");
#nullable restore
#line 107 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"material-icons me-3\" style=\"font-size:5;vertical-align:middle;color:lightgrey;cursor:pointer\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5946, "\"", 5980, 3);
            WriteAttributeValue("", 5956, "SaveBlog(this,", 5956, 14, true);
#nullable restore
#line 110 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue(" ", 5970, item.Id, 5971, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5979, ")", 5979, 1, true);
            EndWriteAttribute();
            WriteLiteral(">bookmark</i>\r\n");
#nullable restore
#line 111 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; <i class=\"material-icons\" style=\"color:grey; font-size:5;vertical-align:middle\">visibility</i>&nbsp; ");
#nullable restore
#line 114 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                       Write(item.views);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; &nbsp;\r\n\r\n");
#nullable restore
#line 116 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                 if (item.likeBlogs.Where(e => e.UserId == User.Id).Count() != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"material-icons \" style=\"vertical-align:middle;color:var(--secondary);font-size:5\">favorite</i> ");
#nullable restore
#line 118 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                        Write(item.likeBlogs.Count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                                                  
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"material-icons-outlined\" style=\"vertical-align:middle;color:lightgrey;font-size:5\">favorite</i> ");
#nullable restore
#line 122 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                         Write(item.likeBlogs.Count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                                                   
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                        </div>\r\n                         <a");
            BeginWriteAttribute("href", " href=\"", 6950, "\"", 6983, 2);
            WriteAttributeValue("", 6957, "/blog/viewBlog?Id=", 6957, 18, true);
#nullable restore
#line 128 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue("", 6975, item.Id, 6975, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none;color:black\">\r\n                         <div class=\"row\">\r\n                              <div class=\"col-7\">\r\n\r\n                                   <span class=\"my-1\" style=\"font-size:30px;font-weight:700px\">");
#nullable restore
#line 132 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                   <div class=\"text-start my-2\" style=\"color:grey; width: fit-content;\">\r\n                                        <div> ");
#nullable restore
#line 135 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                          Write((new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(item.DateTime)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                   </div>\r\n                                   <div style=\"width: fit-content; background-color:lightgrey;color:black;border-radius:20px;font-size:10px\" class=\"text-center py-1 px-3 mt-3\">");
#nullable restore
#line 137 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
                                                                                                                                                                           Write(item.category.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                  \r\n\r\n                              </div>\r\n\r\n                              <div class=\"col-5\">\r\n                                   <img");
            BeginWriteAttribute("src", " src=", 7891, "", 7929, 1);
#nullable restore
#line 143 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"
WriteAttributeValue("", 7896, Url.Content(@item.TitleImageUrl), 7896, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:96%;height:70%;border-radius:4px\"/>\r\n                               </div>\r\n                         </div>\r\n                         </a>\r\n                   </div>\r\n");
#nullable restore
#line 148 "D:\College Documents\Semester 5\WAD\Blog Website\BlogIt\Views\Blog\Explore.cshtml"

                   
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            
            </div>
    </div>
</div>

<script>

    async function UnsaveBlog(ele, id) {
        ele.style.color = 'lightgrey';
        const req = await fetch(""/blog/UnsaveBlog?id="" + id, {
            method: 'GET',
        });
    }

    async function SaveBlog(ele, id) {
        ele.style.color = '#ff914d';
        const req = await fetch(""/blog/SaveBlog?id=""+id, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        });
        const res = await req.json();
        console.log(res);
    }

</script>");
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
