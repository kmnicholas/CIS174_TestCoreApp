#pragma checksum "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8620bd663592770081223f0d9b47d4cd0bfaec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Student), @"mvc.1.0.view", @"/Views/Shared/_Student.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Student.cshtml", typeof(AspNetCore.Views_Shared__Student))]
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
#line 1 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e8620bd663592770081223f0d9b47d4cd0bfaec", @"/Views/Shared/_Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"960e6ccb98a3b872e69da610e4c5b003252b85b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.StudentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 104, true);
            WriteLiteral("<!--This is the partial view for lower access \n    levels. This partial view shows no grades. \n    -->\n\n");
            EndContext();
            BeginContext(150, 19, true);
            WriteLiteral("\n<p>\n    Name: <em>");
            EndContext();
            BeginContext(170, 15, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_Student.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(185, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(187, 14, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_Student.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(201, 10, true);
            WriteLiteral("</em>\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIS174_TestCoreApp.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
