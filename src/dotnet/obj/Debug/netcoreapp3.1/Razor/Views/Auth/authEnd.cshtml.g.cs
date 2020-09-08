#pragma checksum "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\Auth\authEnd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "414ca9a93884c2142e22effdc248456d5ec84c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_authEnd), @"mvc.1.0.view", @"/Views/Auth/authEnd.cshtml")]
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
#line 1 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\_ViewImports.cshtml"
using msteams_tabs_sso_sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\_ViewImports.cshtml"
using msteams_tabs_sso_sample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"414ca9a93884c2142e22effdc248456d5ec84c02", @"/Views/Auth/authEnd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9972ec5bc2a9f9acd9fdbe738d10977be341f588", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_authEnd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\GitHub\msteams-tabs-sso-sample-nodejs\src\dotnet\Views\Auth\authEnd.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414ca9a93884c2142e22effdc248456d5ec84c023505", async() => {
                WriteLiteral("\r\n    <title>Auth End Page</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "414ca9a93884c2142e22effdc248456d5ec84c024507", async() => {
                WriteLiteral("\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 128, "\"", 205, 2);
                WriteAttributeValue("", 134, "https://unpkg.com/", 134, 18, true);
                WriteLiteral("@");
                WriteAttributeValue("", 154, "microsoft/teams-js@1.5.0/dist/MicrosoftTeams.min.js", 154, 51, true);
                EndWriteAttribute();
                WriteLiteral(@" crossorigin=""anonymous""></script>
    <script src=""https://secure.aadcdn.microsoftonline-p.com/lib/1.0.15/js/adal.min.js"" integrity=""sha384-lIk8T3uMxKqXQVVfFbiw0K/Nq+kt1P3NtGt/pNexiDby2rKU6xnDY8p16gIwKqgI"" crossorigin=""anonymous""></script>

    <script>
        microsoftTeams.initialize();

        localStorage.removeItem(""auth.error"");
        let hashParams = getHashParameters();

        if (hashParams[""error""]) {
            // Authentication/authorization failed
            localStorage.setItem(""auth.error"", JSON.stringify(hashParams));
            microsoftTeams.authentication.notifyFailure(hashParams[""error""]);
        } else if (hashParams[""access_token""]) {
            // Get the stored state parameter and compare with incoming state
            let expectedState = localStorage.getItem(""auth.state"");
            if (expectedState !== hashParams[""state""]) {
                // State does not match, report error
                localStorage.setItem(""auth.error"", JSON.stringify(hashPar");
                WriteLiteral(@"ams));
                microsoftTeams.authentication.notifyFailure(""StateDoesNotMatch"");
            } else {
                // Success -- return token information to the parent page.
                // Use localStorage to avoid passing the token via notifySuccess; instead we send the item key.
                let key = ""auth.result"";
                // TODO: not sure why this isn't being set
                localStorage.setItem(key, JSON.stringify({
                    idToken: hashParams[""id_token""],
                    accessToken: hashParams[""access_token""],
                    tokenType: hashParams[""token_type""],
                    expiresIn: hashParams[""expires_in""]
                }));
                microsoftTeams.authentication.notifySuccess(key);
            }
        } else {
            // Unexpected condition: hash does not contain error or access_token parameter
            localStorage.setItem(""auth.error"", JSON.stringify(hashParams));
            microsoftTeams.authenticat");
                WriteLiteral(@"ion.notifyFailure(""UnexpectedFailure"");
        }
        // Parse hash parameters into key-value pairs
        function getHashParameters() {
            let hashParams = {};
            location.hash.substr(1).split(""&"").forEach(function (item) {
                let s = item.split(""=""),
                    k = s[0],
                    v = s[1] && decodeURIComponent(s[1]);
                hashParams[k] = v;
            });
            return hashParams;
        }
    </script>
");
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
            WriteLiteral("\r\n</html>");
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
