#pragma checksum "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12a88d9481699cf42d4b7a840099e6b684b958b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cost_Update), @"mvc.1.0.view", @"/Areas/Admin/Views/Cost/Update.cshtml")]
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
#line 1 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.CommentDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.AdvantageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.QuestionDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.CostDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.PositionDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.BlogDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.MessageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.SeoDescriptionDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.SeoKeyWordDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.service.Dtos.SeoTagDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/_ViewImports.cshtml"
using HomeService.app.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a88d9481699cf42d4b7a840099e6b684b958b0", @"/Areas/Admin/Views/Cost/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad46d7ecc6abe436f689901bfd1a02c4a8e6cff", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Cost_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CostVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 text text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div style=\"background-color:gainsboro\" class=\"container\">\n    <div class=\"card-body row\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b010043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b011675", async() => {
                WriteLiteral("\n\n            <div class=\"row\">\n\n                <div class=\"col-md-4 mb-2 \">\n                    <label>Başlıq Az</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"TitleAz\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 16 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                  Write(Model.CostGetDto.TitleAz);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"TitleAz\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b012658", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"col-md-4 mb-2 \">\n                    <label> Başlıq En</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"TitleEn\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 22 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                  Write(Model.CostGetDto.TitleEn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"TitleEn\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b015049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 24 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"col-md-4 mb-2 \">\n                    <label>Başlıq Ru</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"TitleRu\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 28 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                  Write(Model.CostGetDto.TitleRu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"TitleRu\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b017439", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n\n                <div class=\"col-md-4 mb-2 \">\n                    <label>Açıqlama Az</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"DescriptionAz\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 35 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                        Write(Model.CostGetDto.DescriptionAz);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"DescriptionAz\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b019857", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 37 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"col-md-4 mb-2 \">\n                    <label> Açıqlama En</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"DescriptionEn\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 41 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                        Write(Model.CostGetDto.DescriptionEn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"DescriptionEn\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b022274", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 43 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n                <div class=\"col-md-4 mb-2 \">\n                    <label>Açıqlama Ru</label>\n                    <textarea name=\"CostPostDto.Texts\" id=\"DescriptionRu\" type=\"text\" class=\" form-control \">");
#nullable restore
#line 47 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                                                                                                        Write(Model.CostGetDto.DescriptionRu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                    <input class=\"d-none\" name=\"CostPostDto.Keys\" value=\"DescriptionRu\" />\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b024690", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 49 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.CostPostDto.Texts);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n\n\n\n\n\n                <div class=\"form-row col-12\" id=\"skills\">\n\n");
#nullable restore
#line 58 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                     foreach (var item in Model.CostGetDto.Skills)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group col-md-6\" data-index=\"0\">\n                            <label>Skill adı</label>\n                            <input class=\"form-control\" type=\"text\" name=\"CostPostDto.SkillTexts\"");
                BeginWriteAttribute("value", " value=\"", 3465, "\"", 3489, 1);
#nullable restore
#line 62 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
WriteAttributeValue("", 3473, item.SkillTitle, 3473, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <span class=""text-danger  field-validation-valid"" data-valmsg-for=""CostPostDto.SkillTexts"" data-valmsg-replace=""true""></span>
                            <label> Skil Contenti </label>
                            <input class=""form-control"" type=""text"" name=""CostPostDto.SkillContents""");
                BeginWriteAttribute("value", " value=\"", 3805, "\"", 3831, 1);
#nullable restore
#line 65 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
WriteAttributeValue("", 3813, item.SkillContent, 3813, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <span class=""text-danger field-validation-valid"" data-valmsg-for=""CostPostDto.SkillContents"" data-valmsg-replace=""true""></span>
                            <span><i style=""cursor:pointer"" class=""fas fa-minus delete-feature""> </i></span>
                        </div>
");
#nullable restore
#line 69 "/Users/ehedtagiyev/Desktop/MyHomeService/Homeservice.az/HomeService/HomeService.app/Areas/Admin/Views/Cost/Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
                <div class=""form-row justify-content-center"">
                    <div class=""form-group"">
                        <button data-nextIndex=""2"" class=""add-social btn btn-primary"">+</button>
                    </div>
                </div>

                <div class=""col-md-12 mt-3"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b029088", async() => {
                    WriteLiteral("<i class=\"fas fa-undo\"></i> Geriyə");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-primary\">Dəyişikliyi Qeyd et</button>\n                </div>\n            </div>\n\n\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.3/jquery.validate.min.js"" integrity=""sha512-37T7leoNS06R80c8Ulq7cdCDU5MNQBwlYoy1TX/WUsLFC2eYNqtKlV0QjH7r8JpG/S0GUMZwebnVFLPd6SU5yg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.12/jquery.validate.unobtrusive.min.js"" integrity=""sha512-o6XqxgrUsKmchwy9G5VRNWSSxTS4Urr4loO6/0hYdpWmFUfHqGzawGxeQGMDqYzxjY9sbktPbNlkIQJWagVZQg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
");
            }
            );
            WriteLiteral("\n\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>

    <script>
        $(document).ready(function () {
            $(document).on(""click"", "".add-social"", function (e) {
                e.preventDefault();
                var nextIndex = $(this).attr(""data-nextIndex"");
                var inputGroup = `
                 <div class=""form-group col-md-6"" data-index=""0"">
                                <label>Skill adı</label>
                                <input class=""form-control"" type=""text""  name=""CostPostDto.SkillTexts"" value="""">
                                <span class=""text-danger  field-validation-valid"" data-valmsg-for=""CostPostDto.SkillTexts"" data-valmsg-replace=""true""></span>
                                <label> Skil Contenti </label>
                                <input class=""form-contr");
                WriteLiteral(@"ol"" type=""text""  name=""CostPostDto.SkillContents"" value="""">
                                <span class=""text-danger field-validation-valid"" data-valmsg-for=""CostPostDto.SkillContents"" data-valmsg-replace=""true""></span>
                                <span><i style=""cursor:pointer"" class=""fas fa-minus delete-feature""> </i></span>
                            </div>
                `
                $(""#skills"").append($(inputGroup))
                nextIndex = +nextIndex + 1;
                console.log(nextIndex)
                $(this).attr(""data-nextIndex"", nextIndex)
            })
            $(document).on(""click"", "".delete-feature"", function (e) {
                e.preventDefault();
                $(this).parents("".form-group"").empty();
            })
        })
    </script>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12a88d9481699cf42d4b7a840099e6b684b958b034861", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        CKEDITOR.replace(""TitleAz"")
        CKEDITOR.replace(""TitleEn"")
        CKEDITOR.replace(""TitleRu"")
        CKEDITOR.replace(""DescriptionAz"")
        CKEDITOR.replace(""DescriptionEn"")
        CKEDITOR.replace(""DescriptionRu"")

    </script>
");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CostVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
