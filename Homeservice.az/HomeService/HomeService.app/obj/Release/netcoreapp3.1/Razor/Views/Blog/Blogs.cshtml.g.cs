#pragma checksum "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66f0b0c268d67e4cbc80c9b05bd5e3655197c8d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blogs), @"mvc.1.0.view", @"/Views/Blog/Blogs.cshtml")]
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
#line 1 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/_ViewImports.cshtml"
using HomeService.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/_ViewImports.cshtml"
using HomeService.service.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/_ViewImports.cshtml"
using HomeService.app.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f0b0c268d67e4cbc80c9b05bd5e3655197c8d5", @"/Views/Blog/Blogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23a38ab8ac031c3b949cc95557899dc78be734d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Blogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
  
    ViewData["Title"] = "Blogs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section id=\"blog\" class=\"blog\">\n    <div class=\"container\">\n        <div class=\"row align-items-center\">\n            <div class=\"col-md-8\">\n                <div class=\"section-title\">\n                    <h2>");
#nullable restore
#line 12 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                   Write(localizaer["Blog"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                </div>\n            </div>\n        \n        </div>\n        <div class=\"row\">\n");
#nullable restore
#line 18 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
             foreach (var item in Model.Blogs.Items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\n                    <div class=\"single-blog\">\n                        <div class=\"blog-image\">\n                            <a href=\"javascript:void(0)\">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66f0b0c268d67e4cbc80c9b05bd5e3655197c8d56146", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 775, "~/assets/images/blog/", 775, 21, true);
#nullable restore
#line 24 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
AddHtmlAttributeValue("", 796, item.ImageFile, 796, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </a>\n                            <span class=\"blog-tag\">\n\n");
#nullable restore
#line 28 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                 if ((localizaer["Language"] == "Az"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionAz);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                                                                  
                                }
                                else if ((localizaer["Language"] == "En"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionEn);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                                                                  
                                }
                                else
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Model.Positions.Items.FirstOrDefault(x => x.Id == item.PositionId).PositionRu);

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                                                                  
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\n                        </div>\n                        <div class=\"blog-content\">\n                            <h3>\n                                <a href=\"javascript:void(0)\">\n");
#nullable restore
#line 48 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                     if ((localizaer["Language"] == "Az"))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                   Write(Html.Raw(item.TitleAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                               
                                    }
                                    else if ((localizaer["Language"] == "En"))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                   Write(Html.Raw(item.TitleEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                               
                                    }
                                    else
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                   Write(Html.Raw(item.TitleRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                               
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\n                            </h3>\n                            <p>\n");
#nullable restore
#line 66 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                 if ((localizaer["Language"] == "Az"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionAz));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                 
                                }
                                else if ((localizaer["Language"] == "En"))
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionEn));

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                 

                                }
                                else
                                {

                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                               Write(Html.Raw(item.DescriptionRu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                 

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66f0b0c268d67e4cbc80c9b05bd5e3655197c8d515178", async() => {
#nullable restore
#line 84 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                                                              Write(localizaer["Read More"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 88 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Views/Blog/Blogs.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</section>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Localization.IStringLocalizer<SharedResource> localizaer { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
