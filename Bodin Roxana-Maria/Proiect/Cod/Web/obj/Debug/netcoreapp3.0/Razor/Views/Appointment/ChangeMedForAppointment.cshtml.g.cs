#pragma checksum "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54b3dc5bb78bbc4ce2d05ab0bde8e423201bf1b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_ChangeMedForAppointment), @"mvc.1.0.view", @"/Views/Appointment/ChangeMedForAppointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b3dc5bb78bbc4ce2d05ab0bde8e423201bf1b0", @"/Views/Appointment/ChangeMedForAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_ChangeMedForAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.AppointmentDto>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
  
    ViewData["Title"] = "Update Med for Appointment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
    
    ViewBag.Title = "www.compilemode.com";  

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54b3dc5bb78bbc4ce2d05ab0bde8e423201bf1b04022", async() => {
                WriteLiteral("\r\n    <fieldset>\r\n        <div>\r\n        <legend>Enter Med Name:</legend>\r\n        </div>\r\n    </fieldset>\r\n");
#nullable restore
#line 17 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
     using (Html.BeginForm("UpdateMedForAppointment", "Appointment", FormMethod.Post)) 
    {  
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-horizontal\" align=\"left\">  \r\n            ");
#nullable restore
#line 22 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                 <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
               Write(Html.LabelFor(u => u.MedName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
               Write(Html.TextBoxFor(u => u.MedName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
               Write(Html.ValidationMessageFor(u => u.MedName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <p></p>\r\n                <button type=\"submit\" name=\"Id\"");
                BeginWriteAttribute("value", " value=", 997, "", 1013, 1);
#nullable restore
#line 31 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
WriteAttributeValue("", 1004, Model.Id, 1004, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Update Med</button>\r\n        </div> \r\n");
#nullable restore
#line 33 "C:\Users\Bodin Roxana-Maria\Downloads\wetransfer-950a96\PSSC-2019-example\Bodin Roxana-Maria\Cod_proiect\Web\Views\Appointment\ChangeMedForAppointment.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.AppointmentDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
