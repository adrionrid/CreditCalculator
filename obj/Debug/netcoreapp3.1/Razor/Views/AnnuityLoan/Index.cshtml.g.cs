#pragma checksum "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1ad690f6a65a060711ec5aeffcaa079ac4111f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnnuityLoan_Index), @"mvc.1.0.view", @"/Views/AnnuityLoan/Index.cshtml")]
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
#line 1 "C:\Games\WebDev\sites\CreditCalculator\Views\_ViewImports.cshtml"
using CreditCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games\WebDev\sites\CreditCalculator\Views\_ViewImports.cshtml"
using CreditCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1ad690f6a65a060711ec5aeffcaa079ac4111f", @"/Views/AnnuityLoan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaec91eae57b331ca56de67b63cc456dbb83ac96", @"/Views/_ViewImports.cshtml")]
    public class Views_AnnuityLoan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreditCalculator.Models.AnnuityLoan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
  
    ViewData["Title"] = Html.DisplayNameForModel();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
 using (Html.BeginForm("Index", "AnnuityLoan", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
                            ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 10 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
   Write(Html.DisplayNameForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <div class=\"form-row\">\r\n        ");
#nullable restore
#line 13 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
       Write(Html.LabelFor(model => model.Amount, new { @class = "control-label col-md-10" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 17 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Amount, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.Amount, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
       Write(Html.LabelFor(model => model.Rate, new { @class = "control-label col-md-10" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Rate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.Rate, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
       Write(Html.LabelFor(model => model.Term, new { @class = "control-label col-md-10" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.TextBoxFor(model => model.Term, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.Term, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <input type=\"submit\" value=\"Рассчитать\" class=\"form-group btn btn-outline-primary col\" />\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].MainDebt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].Percent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Payments[0].Debt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 63 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
         foreach (var item in Model.Payments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MainDebt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Percent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Debt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"6\" class=\"text-right\">\r\n                ");
#nullable restore
#line 90 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OverpaymentAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 91 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
           Write(Html.DisplayFor(model => model.OverpaymentAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
#nullable restore
#line 96 "C:\Games\WebDev\sites\CreditCalculator\Views\AnnuityLoan\Index.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreditCalculator.Models.AnnuityLoan> Html { get; private set; }
    }
}
#pragma warning restore 1591