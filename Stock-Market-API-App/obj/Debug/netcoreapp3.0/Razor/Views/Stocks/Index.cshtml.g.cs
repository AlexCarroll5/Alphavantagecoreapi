#pragma checksum "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e4f4de976690ea617918a6c3d628e0b53748c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stocks_Index), @"mvc.1.0.view", @"/Views/Stocks/Index.cshtml")]
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
#line 1 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/_ViewImports.cshtml"
using Stock_Market_API_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/_ViewImports.cshtml"
using Stock_Market_API_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e4f4de976690ea617918a6c3d628e0b53748c2", @"/Views/Stocks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e656bc33aa19d031dd24645f8ca77eb60f99467", @"/Views/_ViewImports.cshtml")]
    public class Views_Stocks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Stock_Market_API_App.Models.StocksViewModel.StockInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<table>\n    <tr>\n        <th>Symbol</th>\n        <th>Name</th>\n        <th>Type</th>\n        <th>Region</th>\n        <th>Market Open</th>\n        <th>Market Close</th>\n        <th>Time Zone</th>\n        <th>Currency</th>\n    </tr>\n\n");
#nullable restore
#line 16 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
 foreach(Stock_Market_API_App.Models.StocksViewModel.StockInfo stock in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>");
#nullable restore
#line 19 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.Symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 20 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 21 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 22 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 23 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.MarketOpen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 24 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.MarketClose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 25 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.TimeZone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 26 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
       Write(stock.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 28 "/Users/mitchdorsey/Projects/Alphavantagecoreapi/Stock-Market-API-App/Views/Stocks/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Stock_Market_API_App.Models.StocksViewModel.StockInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
