#pragma checksum "C:\Users\Justin\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5cda4139b013d79f0fdf705b484cb556fa7477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PawsClaws.Pages.Pages_Pets), @"mvc.1.0.razor-page", @"/Pages/Pets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Pets.cshtml", typeof(PawsClaws.Pages.Pages_Pets), null)]
namespace PawsClaws.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Justin\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\_ViewImports.cshtml"
using PawsClaws;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5cda4139b013d79f0fdf705b484cb556fa7477", @"/Pages/Pets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7824a7c591047c632f6fb408437fc1b2180c31df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pets : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Justin\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets.cshtml"
  
    ViewData["Title"] = "Pets";

#line default
#line hidden
            BeginContext(81, 8, true);
            WriteLiteral("    <h2>");
            EndContext();
            BeginContext(90, 17, false);
#line 6 "C:\Users\Justin\Source\Repos\celdridge2\Paws-Claws\PawsClaws\Pages\Pets.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
            BeginContext(118, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5cda4139b013d79f0fdf705b484cb556fa74773664", async() => {
                BeginContext(124, 183, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        .my-col {\r\n            background-color: #00ffff;\r\n            border: 1px solid #4cff00;\r\n            height: 120px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(318, 753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe5cda4139b013d79f0fdf705b484cb556fa74775048", async() => {
                BeginContext(324, 740, true);
                WriteLiteral(@"
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 1</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 2</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 3</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 4</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 5</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 6</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 7</div>
            <div class=""col-xs-8 col-sm-4 col-md-2 col-lg-1 my-col"">Pet 8</div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PawsClaws.Pages.PetsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PawsClaws.Pages.PetsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PawsClaws.Pages.PetsModel>)PageContext?.ViewData;
        public PawsClaws.Pages.PetsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
