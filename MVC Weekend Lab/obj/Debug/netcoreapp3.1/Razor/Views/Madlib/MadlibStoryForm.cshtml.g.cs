#pragma checksum "C:\Users\nayan\source\repos\MVC Weekend Lab\MVC Weekend Lab\Views\Madlib\MadlibStoryForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c907ee3b930254c6b1706c0c05d7377251914f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Madlib_MadlibStoryForm), @"mvc.1.0.view", @"/Views/Madlib/MadlibStoryForm.cshtml")]
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
#line 1 "C:\Users\nayan\source\repos\MVC Weekend Lab\MVC Weekend Lab\Views\_ViewImports.cshtml"
using MVC_Weekend_Lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nayan\source\repos\MVC Weekend Lab\MVC Weekend Lab\Views\_ViewImports.cshtml"
using MVC_Weekend_Lab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c907ee3b930254c6b1706c0c05d7377251914f", @"/Views/Madlib/MadlibStoryForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acb6197404c97522f54c5d9c922c1e1f4676c34b", @"/Views/_ViewImports.cshtml")]
    public class Views_Madlib_MadlibStoryForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Madlib/MadlibStroryResult"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nayan\source\repos\MVC Weekend Lab\MVC Weekend Lab\Views\Madlib\MadlibStoryForm.cshtml"
  
    ViewData["Title"] = "MadlibStoryForm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Madlib Story Form</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59c907ee3b930254c6b1706c0c05d7377251914f4252", async() => {
                WriteLiteral(@"

    <h3>Please enter following:</h3><br />
    <input type=""text"" name=""Word1"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word2"" placeholder=""Last Name"" />
    <input type=""text"" name=""Word3"" placeholder=""Adjective"" /><br />
    <input type=""text"" name=""Word4"" placeholder=""Noun"" />
    <input type=""text"" name=""Word5"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word6"" placeholder=""Plural Noun"" /><br />
    <input type=""text"" name=""Word7"" placeholder=""Noun"" />
    <input type=""text"" name=""Word8"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word9"" placeholder=""Plural Noun"" /><br />
    <input type=""text"" name=""Word10"" placeholder=""Noun"" />
    <input type=""text"" name=""Word11"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word12"" placeholder=""Plural Noun"" /><br />
    <input type=""text"" name=""Word13"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word14"" placeholder=""Adjective"" />
    <input type=""text"" name=""Word15"" placeholder=""Noun"" /><b");
                WriteLiteral(@"r />
    <input type=""text"" name=""Word16"" placeholder=""Noun"" />
    <input type=""text"" name=""Word17"" placeholder=""Letter Of Alphabet"" />
    <input type=""text"" name=""Word18"" placeholder=""Noun"" /><br /><br />

    <input type=""Submit"" name=""name"" value=""Show me my Madlib story"" />

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
