#pragma checksum "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db93b6e570018d285a4a6efdbd227bc7111ffbbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mud.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml", typeof(Mud.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ConfirmEmail), null)]
namespace Mud.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\_ViewImports.cshtml"
using Mud.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Mud.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db93b6e570018d285a4a6efdbd227bc7111ffbbf", @"/Areas/Identity/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"161f5f8e45df1249899ad801a2d632a322afc9db", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d794d751cb7e4f09983ec132f82e697b749752c", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
            BeginContext(82, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(89, 17, false);
#line 7 "C:\Users\Ryan Newman\Desktop\MUD Maker\Mud-Project\MVC\Mud\Mud\Areas\Identity\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(106, 87, true);
            WriteLiteral("</h1>\r\n<div>\r\n    <p>\r\n        Thank you for confirming your email.\r\n    </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
