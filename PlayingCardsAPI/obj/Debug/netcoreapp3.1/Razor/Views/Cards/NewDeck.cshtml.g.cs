#pragma checksum "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b596282fb4cb457783a99e170a7174f574211e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cards_NewDeck), @"mvc.1.0.view", @"/Views/Cards/NewDeck.cshtml")]
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
#line 1 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\_ViewImports.cshtml"
using PlayingCardsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\_ViewImports.cshtml"
using PlayingCardsAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b596282fb4cb457783a99e170a7174f574211e3", @"/Views/Cards/NewDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb935c1015b8d87631e2018caca91797e9acde06", @"/Views/_ViewImports.cshtml")]
    public class Views_Cards_NewDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Deck>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("GetHand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml"
  
    ViewData["Title"] = "NewDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>NewDeck</h1>\r\n\r\n<p>A new deck has been created</p>\r\n<ul>\r\n    <li>Deck id: ");
#nullable restore
#line 10 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml"
            Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Shuffled: ");
#nullable restore
#line 11 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml"
             Write(Model.shuffled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Remaining Cards: ");
#nullable restore
#line 12 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml"
                    Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b596282fb4cb457783a99e170a7174f574211e34932", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" id=\"deckid\" name=\"deckid\"");
                BeginWriteAttribute("value", " value=\"", 342, "\"", 364, 1);
#nullable restore
#line 15 "C:\DevBuild4\WebApps\PlayingCardsAPI\PlayingCardsAPI\Views\Cards\NewDeck.cshtml"
WriteAttributeValue("", 350, Model.deck_id, 350, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <input type=\"submit\" class=\"btn-info\" value=\"Get Hand\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Deck> Html { get; private set; }
    }
}
#pragma warning restore 1591
