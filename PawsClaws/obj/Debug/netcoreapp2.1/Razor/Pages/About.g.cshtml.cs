#pragma checksum "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9e1ff697c9692707c5bbca954242701ee664c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PawsClaws.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(PawsClaws.Pages.Pages_About), null)]
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
#line 1 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\_ViewImports.cshtml"
using PawsClaws;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9e1ff697c9692707c5bbca954242701ee664c38", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7824a7c591047c632f6fb408437fc1b2180c31df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(67, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(72, 17, false);
#line 6 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(89, 15, true);
            WriteLiteral("</h2>\r\n<!--<h3>");
            EndContext();
            BeginContext(105, 13, false);
#line 7 "C:\Users\Charles\Source\Repos\Paws-Claws\PawsClaws\Pages\About.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(118, 2505, true);
            WriteLiteral(@"</h3>-->

<style>
    .wrapper-class{
        width:100%;
        margin-top:45px;
    }

    .inner-wrapper{
        padding-left:45px;
        padding-right:45px;
    }

    .description-section{
        float:left;
        width:150px;
    }

    .dog_image{
        float:right;
    }
</style>

<div  class=""wrapper-class"">
    <div class=""inner-wrapper"">
       
        <div class=""description-section"">
            <h2>Our Story</h2>
            <div class=""story-section"">
                <p>
                    Latom when john is killed. David what are we going to have for breakfast.
                    Apples are orange when the sun is kissed on the belly button.
                    Don't worry, we'll be ok as long as we stick together.She was too short to see over the fence.
                    The sky is clear; the stars are twinkling.
                    It was getting dark, and we weren’t there yet.
                    Writing a list of random sentences is harder th");
            WriteLiteral(@"an I initially thought it would be.
                    The quick brown fox jumps over the lazy dog.
                    If Purple People Eaters are real… where do they find purple people to eat?
                </p>

                <p>
                    The stranger officiates the meal.
                    He ran out of money, so he had to stop playing poker.
                    Lets all be unique together until we realise we are all the same.
                    She wrote him a long letter, but he didn't read it.
                    If the Easter Bunny and the Tooth Fairy had babies would they take your teeth and leave chocolate for you?
                    He said he was not there yesterday; however, many people saw him there.
                    I will never be this young again. Ever. Oh damn… I just got older.
                    I really want to go to work, but I am too sick to drive.
                    I am happy to take your donation; any amount will be greatly appreciated.
        ");
            WriteLiteral(@"            A glittering gem is not enough.
                </p>
            </div>
        </div>

        <div class=""dog_image"">
            <img src=""https://scontent-dfw5-1.xx.fbcdn.net/v/t1.0-9/73292707_2484053138315378_3667788408769478656_n.jpg?_nc_cat=100&_nc_oc=AQkMy8AlLgiQkwWXjEFY2mjSEnR5bJDAcnvylOyDhYVFFhZGd-2YEW4BptJyYwoW9a4&_nc_ht=scontent-dfw5-1.xx&oh=f055eecbd135ecaad5d22d86fffc9734&oe=5E5EA7EE""
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
