#pragma checksum "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\Recipe\LeaveReview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544031c9dba94c72161c49b2f51c0ee19b45a563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_LeaveReview), @"mvc.1.0.view", @"/Views/Recipe/LeaveReview.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/LeaveReview.cshtml", typeof(AspNetCore.Views_Recipe_LeaveReview))]
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
#line 1 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
#line 2 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544031c9dba94c72161c49b2f51c0ee19b45a563", @"/Views/Recipe/LeaveReview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b98641faec7504165f0747649be861fc2a63e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_LeaveReview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment2.Models.Recipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LeaveReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 31, true);
            WriteLiteral("\n<h2>Leave a review for: <span>");
            EndContext();
            BeginContext(65, 11, false);
#line 3 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\Recipe\LeaveReview.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(76, 13, true);
            WriteLiteral("</span></h2>\n");
            EndContext();
            BeginContext(89, 567, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1503f4fd0c644bb8abad6fccb6b2bc74", async() => {
                BeginContext(158, 72, true);
                WriteLiteral("\n    <div class=\"w3-panel\">\n        <input type=\"hidden\" name=\"RecipeId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 230, "\"", 253, 1);
#line 6 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\Recipe\LeaveReview.cshtml"
WriteAttributeValue("", 238, Model.RecipeId, 238, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(254, 51, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"RecipeTitle\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 305, "\"", 325, 1);
#line 7 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\COMP229-Project\COMP229-Assignment2\COMP229-Assignment2\Assignment2\Views\Recipe\LeaveReview.cshtml"
WriteAttributeValue("", 313, Model.Title, 313, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(326, 323, true);
                WriteLiteral(@" />
        <p><input class=""w3-input w3-padding-16"" type=""text"" placeholder=""Username"" required name=""Username""></p>
        <p><input class=""w3-input w3-padding-16"" type=""text"" placeholder=""Comment"" required name=""Comment""</p>
    </div>
    <button type=""submit"" class=""w3-button w3-light-grey w3-section"">Save</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(656, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
