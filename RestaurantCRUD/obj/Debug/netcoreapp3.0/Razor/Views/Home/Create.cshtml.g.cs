#pragma checksum "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c517cf89206d20fce1448a44352a225a5f9e5d65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
#line 1 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
using Microsoft.EntityFrameworkCore.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
using RestaurantCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c517cf89206d20fce1448a44352a225a5f9e5d65", @"/Views/Home/Create.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantCRUD.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n \r\n");
#nullable restore
#line 6 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
   
     Layout = "~/Pages/Shared/_Layout.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
            WriteLiteral(@"        
<div class=""row"">
    <div class=""col-md-2""></div><div class=""col-md-8"">
        <div class=""text-center""><h3 style=""color: #2270C0;"">Add Restaurant</h3></div>
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" name=""Name"" class=""form-control""/>
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cuisine"" class=""control-label""></label>
                <select asp-for=""Cuisine"" name=""Cuisine"" class=""form-control"">

");
#nullable restore
#line 27 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
                     foreach (CuisineType c in (CuisineType[]) Enum.GetValues(typeof(CuisineType)))
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1160, "\"", 1187, 1);
#nullable restore
#line 30 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
WriteAttributeValue("", 1168, Convert.ToInt32(c), 1168, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"
                                                       Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 31 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Create.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <span asp-validation-for=\"Cuisine\" class=\"text-danger\"></span>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1430, "\"", 1440, 0);
            EndWriteAttribute();
            WriteLiteral(" value=\"Save\" class=\"btn btn-info\"/>\r\n            </div>\r\n        </form>\r\n    </div>\r\n     </div><div class=\"col-md-2\"></div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantCRUD.Models.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
