#pragma checksum "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PawsClaws.Pages.Pets.Pages_Pets_Details), @"mvc.1.0.razor-page", @"/Pages/Pets/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Pets/Details.cshtml", typeof(PawsClaws.Pages.Pets.Pages_Pets_Details), @"{id:int?}")]
namespace PawsClaws.Pages.Pets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\_ViewImports.cshtml"
using PawsClaws;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a0", @"/Pages/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7824a7c591047c632f6fb408437fc1b2180c31df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pets_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%; width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 628, true);
            WriteLiteral(@"
<style>
    #row{
        display:flex;
        flex-direction:row;
        justify-content:space-around;
    }
    #left{
        display:flex;
        flex-direction:column;
        width: 45%;
        justify-content: center;
    }
    #right{
        display:flex;
        flex-direction:column;
        width: 45%;
        justify-content: center;
    }
</style>

<h2>Details</h2>
<div id=""row""> 
    <div id=""left"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""5000"" style=""width:100% !important;"">
                <ol class=""carousel-indicators"">
");
            EndContext();
#line 33 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                       
                        int i = 0;
                        foreach (var f in Model.Images)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(951, 102, true);
            WriteLiteral("                                <li data-target=\"#myCarousel\" data-slide-to=\"0\" class=\"active\"></li>\r\n");
            EndContext();
#line 40 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            else
                            { 

#line default
#line hidden
            BeginContext(1150, 77, true);
            WriteLiteral("                                <li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(1228, 1, false);
#line 43 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 10, true);
            WriteLiteral("\"></li> \r\n");
            EndContext();
#line 44 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(1354, 117, true);
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\" role=\"listbox\" style=\"height: 100% !important;\">\r\n");
            EndContext();
#line 50 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                      
                        i = 0;
                        foreach (var f in Model.Images)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(1683, 95, true);
            WriteLiteral("                                <div class=\"item active\">\r\n                                    ");
            EndContext();
            BeginContext(1778, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a07902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1788, "~/images/", 1788, 9, true);
#line 57 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 1797, Model.Pet.ID, 1797, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1810, "/", 1810, 1, true);
#line 57 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 1811, i + ".jpg", 1811, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1883, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 59 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2021, 86, true);
            WriteLiteral("                               <div class=\"item\">\r\n                                   ");
            EndContext();
            BeginContext(2107, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a010348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2117, "~/images/", 2117, 9, true);
#line 63 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 2126, Model.Pet.ID, 2126, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2139, "/", 2139, 1, true);
#line 63 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 2140, i + ".jpg", 2140, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2212, 42, true);
            WriteLiteral("\r\n                               </div> \r\n");
            EndContext();
#line 65 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(2369, 637, true);
            WriteLiteral(@"
                </div>
                <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                    <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                    <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
        </div>
        <div style=""text-align:center"">
");
            EndContext();
#line 81 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(3070, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3086, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a013692", async() => {
                BeginContext(3138, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                                         WriteLiteral(Model.Pet.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3148, 88, true);
            WriteLiteral("\r\n                <span> | </span>\r\n                <a asp - page=\"./Edit\" asp - route -");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3236, "\"", 3254, 1);
#line 85 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
WriteAttributeValue("", 3241, Model.Pet.ID, 3241, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3255, 47, true);
            WriteLiteral("> Edit </a>\r\n                <span> | </span>\r\n");
            EndContext();
#line 87 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(3317, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3331, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c55c993b76a7d0c2a75ace9de01e55d7e8c5a016806", async() => {
                BeginContext(3353, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3369, 138, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div id=\"right\">\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3508, 44, false);
#line 96 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3552, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3608, 40, false);
#line 99 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3648, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3704, 49, false);
#line 102 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(3753, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3809, 45, false);
#line 105 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(3854, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3910, 47, false);
#line 108 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(3957, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4013, 43, false);
#line 111 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(4056, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4112, 45, false);
#line 114 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(4157, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4213, 41, false);
#line 117 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(4254, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4310, 43, false);
#line 120 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4353, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4409, 39, false);
#line 123 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4448, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4504, 44, false);
#line 126 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(4548, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4604, 40, false);
#line 129 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(4644, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4700, 51, false);
#line 132 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(4751, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4807, 47, false);
#line 135 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(4854, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4910, 48, false);
#line 138 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(4958, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5014, 44, false);
#line 141 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(5058, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5114, 45, false);
#line 144 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(5159, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5215, 41, false);
#line 147 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(5256, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5312, 49, false);
#line 150 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(5361, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5417, 45, false);
#line 153 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(5462, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5518, 51, false);
#line 156 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(5569, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5625, 47, false);
#line 159 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(5672, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5728, 43, false);
#line 162 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5771, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5827, 39, false);
#line 165 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5866, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5922, 51, false);
#line 168 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5973, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(6029, 47, false);
#line 171 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(6076, 60, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PawsClaws.Pages.Pets.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PawsClaws.Pages.Pets.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PawsClaws.Pages.Pets.DetailsModel>)PageContext?.ViewData;
        public PawsClaws.Pages.Pets.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
