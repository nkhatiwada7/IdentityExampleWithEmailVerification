#pragma checksum "D:\dev\repos\dotnet practice\Authentication\IdentityExampleEmailConfirmation\Views\Home\PasswordReset.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582f990651ce89e6824d6b6a01d3c8e1ccb1ddbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PasswordReset), @"mvc.1.0.view", @"/Views/Home/PasswordReset.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582f990651ce89e6824d6b6a01d3c8e1ccb1ddbf", @"/Views/Home/PasswordReset.cshtml")]
    public class Views_Home_PasswordReset : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n<h1>Reset Password</h1>\r\n<form action=\"/Home/PasswordReset\" method=\"POST\">\r\n    <input type=\"text\" name=\"username\"");
            BeginWriteAttribute("value", " value=\"", 122, "\"", 130, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" name=\"password\"");
            BeginWriteAttribute("value", " value=\"", 174, "\"", 182, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" type=\"text\" name=\"code\" id=\"token\"");
            BeginWriteAttribute("value", " value=\"", 247, "\"", 255, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <button type=""submit"">Submit</button>
</form>
</html>
<script type=""text/javascript"">
    window.onload = function getCode() {
        console.log(""get code called"");
        const queryString = window.location.search;
        const urlParams = new URLSearchParams(queryString);
        const code = urlParams.get('code');
        console.log(code);
        document.getElementById(""token"").value = code;
    }
</script>");
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
