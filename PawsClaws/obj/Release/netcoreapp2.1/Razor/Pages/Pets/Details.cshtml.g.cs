#pragma checksum "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9439efafe635d0076c327399d8299e67a4a9df7d"
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
#line 1 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\_ViewImports.cshtml"
using PawsClaws;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9439efafe635d0076c327399d8299e67a4a9df7d", @"/Pages/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7824a7c591047c632f6fb408437fc1b2180c31df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pets_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100%; width:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-CurrentPage", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 632, true);
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


<div id=""row"" style=""padding: 5%""> 
    <div id=""left"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""5000"" style=""width:100% !important;"">
                <ol class=""carousel-indicators"">
");
            EndContext();
#line 33 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                       
                        int i = 0;
                        foreach (var f in Model.Images)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(955, 102, true);
            WriteLiteral("                                <li data-target=\"#myCarousel\" data-slide-to=\"0\" class=\"active\"></li>\r\n");
            EndContext();
#line 40 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            else
                            { 

#line default
#line hidden
            BeginContext(1154, 77, true);
            WriteLiteral("                                <li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(1232, 1, false);
#line 43 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                                                                        Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 10, true);
            WriteLiteral("\"></li> \r\n");
            EndContext();
#line 44 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(1358, 117, true);
            WriteLiteral("                </ol>\r\n                <div class=\"carousel-inner\" role=\"listbox\" style=\"height: 100% !important;\">\r\n");
            EndContext();
#line 50 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                      
                        i = 0;
                        foreach (var f in Model.Images)
                        {
                            if (i == 0)
                            {

#line default
#line hidden
            BeginContext(1687, 95, true);
            WriteLiteral("                                <div class=\"item active\">\r\n                                    ");
            EndContext();
            BeginContext(1782, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9439efafe635d0076c327399d8299e67a4a9df7d8943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1792, "~/images/", 1792, 9, true);
#line 57 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 1801, Model.Pet.ID, 1801, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1814, "/", 1814, 1, true);
#line 57 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 1815, i + ".jpg", 1815, 13, false);

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
            BeginContext(1887, 42, true);
            WriteLiteral("\r\n                                </div>\r\n");
            EndContext();
#line 59 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2025, 86, true);
            WriteLiteral("                               <div class=\"item\">\r\n                                   ");
            EndContext();
            BeginContext(2111, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9439efafe635d0076c327399d8299e67a4a9df7d11416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2121, "~/images/", 2121, 9, true);
#line 63 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 2130, Model.Pet.ID, 2130, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2143, "/", 2143, 1, true);
#line 63 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
AddHtmlAttributeValue("", 2144, i + ".jpg", 2144, 13, false);

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
            BeginContext(2216, 42, true);
            WriteLiteral("\r\n                               </div> \r\n");
            EndContext();
#line 65 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
                            }
                            i++;
                        }
                    

#line default
#line hidden
            BeginContext(2373, 637, true);
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
#line 81 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(3074, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(3090, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9439efafe635d0076c327399d8299e67a4a9df7d14796", async() => {
                BeginContext(3142, 6, true);
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
#line 83 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
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
            BeginContext(3152, 52, true);
            WriteLiteral("\r\n                <span> | </span>\r\n                ");
            EndContext();
            BeginContext(3204, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9439efafe635d0076c327399d8299e67a4a9df7d17189", async() => {
                BeginContext(3254, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
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
            BeginContext(3262, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(3279, 160, true);
            WriteLiteral("\r\n            \r\n        </div>\r\n    </div>\r\n    <div id=\"right\" style=\"font-size:15px;\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3440, 44, false);
#line 94 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3484, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3540, 40, false);
#line 97 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3580, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3636, 49, false);
#line 100 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(3685, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3741, 45, false);
#line 103 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(3786, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(3842, 47, false);
#line 106 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(3889, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3945, 43, false);
#line 109 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(3988, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4044, 45, false);
#line 112 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(4089, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4145, 41, false);
#line 115 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(4186, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4242, 43, false);
#line 118 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4285, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4341, 39, false);
#line 121 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(4380, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4436, 44, false);
#line 124 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(4480, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4536, 40, false);
#line 127 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(4576, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4632, 51, false);
#line 130 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(4683, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4739, 47, false);
#line 133 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(4786, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(4842, 48, false);
#line 136 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(4890, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(4946, 44, false);
#line 139 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(4990, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5046, 45, false);
#line 142 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(5091, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5147, 41, false);
#line 145 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(5188, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5244, 49, false);
#line 148 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(5293, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5349, 45, false);
#line 151 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(5394, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5450, 51, false);
#line 154 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(5501, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5557, 47, false);
#line 157 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(5604, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5660, 43, false);
#line 160 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5703, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5759, 39, false);
#line 163 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(5798, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(5854, 51, false);
#line 166 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5905, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(5961, 47, false);
#line 169 "C:\Users\haora\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
           Write(Html.DisplayFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(6008, 325, true);
            WriteLiteral(@"
            </dd>
        </dl>
        <hr />
        <a href=""https://nphadmin.wufoo.com/forms/q191z0tm1osxnnx/"" style=""text-align:center; font-size: 20px"">Apply to adopt!</a>
        <a href=""https://nphadmin.wufoo.com/forms/w1pgzcbk0adtw0g/"" style=""text-align:center; font-size: 20px"">Apply to foster!</a>
        ");
            EndContext();
            BeginContext(6333, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9439efafe635d0076c327399d8299e67a4a9df7d31375", async() => {
                BeginContext(6407, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CurrentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CurrentPage"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6423, 26, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
