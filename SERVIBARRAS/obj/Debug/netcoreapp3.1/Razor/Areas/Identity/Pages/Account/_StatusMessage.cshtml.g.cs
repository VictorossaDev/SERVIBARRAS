#pragma checksum "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b43d1aa117202a1d7767cfccebd5d5c8c4a7ebaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
#line 1 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\_ViewImports.cshtml"
using SERVIBARRAS.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\_ViewImports.cshtml"
using SERVIBARRAS.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using SERVIBARRAS.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43d1aa117202a1d7767cfccebd5d5c8c4a7ebaa", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7bb5d19ff84623e4937aaaea1425407cd73e740", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e80a20ea2bb11c6711b1f9e7d793def7db2204", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 139, "\"", 196, 4);
            WriteAttributeValue("", 147, "alert", 147, 5, true);
            WriteAttributeValue(" ", 152, "alert-", 153, 7, true);
#nullable restore
#line 6 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
WriteAttributeValue("", 159, statusMessageClass, 159, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 178, "alert-dismissible", 179, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n        ");
#nullable restore
#line 8 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "C:\Users\Victor\Desktop\SERVIBARRAS\SERVIBARRAS\SERVIBARRAS\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
