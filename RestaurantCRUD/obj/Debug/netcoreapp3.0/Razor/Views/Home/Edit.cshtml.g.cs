#pragma checksum "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e862b0b8309fcc3e4f7ebf4ab96f0f5bced90a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
using RestaurantCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e862b0b8309fcc3e4f7ebf4ab96f0f5bced90a7c", @"/Views/Home/Edit.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantCRUD.Models.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n");
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-2""></div><div class=""col-md-8"">
        <div class=""text-center""><h3 style=""color: #2270C0;"">Edit Restaurant</h3></div>
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" name=""Name""");
            BeginWriteAttribute("value", " value=\"", 617, "\"", 636, 1);
#nullable restore
#line 18 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
WriteAttributeValue("", 625, Model.Name, 625, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  class=""form-control""/>
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cuisine"" class=""control-label""></label>
                <select asp-for=""Cuisine"" name=""Cuisine"" class=""form-control"">

");
#nullable restore
#line 25 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
                     foreach (CuisineType c in (CuisineType[]) Enum.GetValues(typeof(CuisineType)))
                    {
                        if (@c==@Model.Cuisine)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1188, "\"", 1215, 1);
#nullable restore
#line 29 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1196, Convert.ToInt32(c), 1196, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 29 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
                                                                    Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1358, "\"", 1385, 1);
#nullable restore
#line 33 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
WriteAttributeValue("", 1366, Convert.ToInt32(c), 1366, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
                                                           Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 34 "C:\Users\WAKA\RiderProjects\RestaurantCRUD\RestaurantCRUD\Views\Home\Edit.cshtml"
                        }
                        

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <span asp-validation-for=\"Cuisine\" class=\"text-danger\"></span>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1681, "\"", 1691, 0);
            EndWriteAttribute();
            WriteLiteral("  value=\"Save Changes\" class=\"btn btn-primary\"/>\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div><div class=\"col-md-2\"></div>\r\n");
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
