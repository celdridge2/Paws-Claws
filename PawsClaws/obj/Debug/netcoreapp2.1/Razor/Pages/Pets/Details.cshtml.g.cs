#pragma checksum "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe750e6bb176a6c4649810d694625cda9fc4b9a"
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
#line 1 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\_ViewImports.cshtml"
using PawsClaws;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe750e6bb176a6c4649810d694625cda9fc4b9a", @"/Pages/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7824a7c591047c632f6fb408437fc1b2180c31df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pets_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 117, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Pet</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 44, false);
#line 15 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(312, 40, false);
#line 18 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(396, 49, false);
#line 21 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(489, 45, false);
#line 24 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.AtShelter));

#line default
#line hidden
            EndContext();
            BeginContext(534, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(578, 47, false);
#line 27 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(669, 43, false);
#line 30 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Species));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(756, 45, false);
#line 33 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(801, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(845, 41, false);
#line 36 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Breed));

#line default
#line hidden
            EndContext();
            BeginContext(886, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(930, 43, false);
#line 39 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 39, false);
#line 42 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1100, 44, false);
#line 45 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1188, 40, false);
#line 48 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1272, 51, false);
#line 51 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(1323, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1367, 47, false);
#line 54 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Spay_Neuter));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1458, 48, false);
#line 57 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 44, false);
#line 60 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.ShotsUTD));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1638, 45, false);
#line 63 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1727, 41, false);
#line 66 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1812, 49, false);
#line 69 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1905, 45, false);
#line 72 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.FurLength));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1994, 51, false);
#line 75 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2089, 47, false);
#line 78 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(2136, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2180, 43, false);
#line 81 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2267, 39, false);
#line 84 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Age));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2350, 51, false);
#line 87 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2401, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2445, 47, false);
#line 90 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pet.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2492, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2539, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe750e6bb176a6c4649810d694625cda9fc4b9a15445", async() => {
                BeginContext(2591, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
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
            BeginContext(2601, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2609, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe750e6bb176a6c4649810d694625cda9fc4b9a17787", async() => {
                BeginContext(2659, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Justin Carnes\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets\Details.cshtml"
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
            BeginContext(2667, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2675, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe750e6bb176a6c4649810d694625cda9fc4b9a20125", async() => {
                BeginContext(2697, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2713, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
