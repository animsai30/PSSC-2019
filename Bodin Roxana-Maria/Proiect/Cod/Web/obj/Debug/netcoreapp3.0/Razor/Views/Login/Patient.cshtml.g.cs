#pragma checksum "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4adc2b27202db4fcdb047aea883ac6a8799a304e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Patient), @"mvc.1.0.view", @"/Views/Login/Patient.cshtml")]
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
#line 1 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4adc2b27202db4fcdb047aea883ac6a8799a304e", @"/Views/Login/Patient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Patient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
  
    ViewData["Title"] = "Pacient Login Page";
    Layout = "~/Views/Shared/_LayoutWithoutRights.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
Write(Html.ValidationSummary(true, "Login failed. Check your login details."));

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
                                                                            ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <fieldset>\r\n            <legend>Welcome Pacient</legend>\r\n            <div class=\"editor-label\">\r\n                ");
#nullable restore
#line 13 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.LabelFor(u => u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
#nullable restore
#line 16 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.TextBoxFor(u => u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.ValidationMessageFor(u => u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-label\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.LabelFor(u => u.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-field\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.PasswordFor(u => u.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.ValidationMessageFor(u => u.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"editor-label\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.CheckBoxFor(u => u.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
           Write(Html.LabelFor(u => u.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <input type=\"submit\" value=\"Log In\"/>\r\n        </fieldset>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Login\Patient.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
