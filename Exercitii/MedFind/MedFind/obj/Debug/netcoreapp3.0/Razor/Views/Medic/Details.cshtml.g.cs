#pragma checksum "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd42853b7f1dff46b23526a2ac6e52d6ef3a607b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medic_Details), @"mvc.1.0.view", @"/Views/Medic/Details.cshtml")]
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
#line 1 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\_ViewImports.cshtml"
using MedFind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\_ViewImports.cshtml"
using MedFind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd42853b7f1dff46b23526a2ac6e52d6ef3a607b", @"/Views/Medic/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4e2fd01ded7bae63ac05d8f5dcb7b2e65f0c5b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Medic_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MedFind.Models.Medic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "_LayoutMedic";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Medic</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 37 "E:\User\Documents\GitHub\PSSC-2019\Exercitii\MedFind\MedFind\Views\Medic\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedFind.Models.Medic> Html { get; private set; }
    }
}
#pragma warning restore 1591
