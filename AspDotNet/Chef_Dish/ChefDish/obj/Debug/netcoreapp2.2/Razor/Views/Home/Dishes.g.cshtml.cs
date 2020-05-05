#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0f088e46af337f4c9089439b518738d8e0c10a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\_ViewImports.cshtml"
using ChefDish;

#line default
#line hidden
#line 2 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\_ViewImports.cshtml"
using ChefDish.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0f088e46af337f4c9089439b518738d8e0c10a8", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8613bb576166f5a5f0d6f919b797a7e6d2fa1b37", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1205, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-8"">
            <div class=""row"">
                <div class=""col-2""></div>
                <div class=""col-8 text-center""><h1><a href=""/"">Chefs</a> | Dishes</h1></div>
                <div class=""col-2""><a href=""/dishes/new"">Add a Dish</a></div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <div class=""row border-bottom border-dark pt-4 pb-4"">
                    <div class=""col""><h3>Yum, take a look at our tasty dishes!</h3></div>
                    </div>
                    <div class=""row mt-4"">
                        <div style=""height:240px; width:100%; overflow:auto;"" class=""col-12 border border-dark"">
                            <table class=""table table-striped"">
                                <tr>
                                    <th>Name</th>
                                    <th>Chef</th>
                      ");
            WriteLiteral("              <th>Tastiness</th>\r\n                                    <th>Calories</th>\r\n                                    <th>Option</th>\r\n                                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                 foreach(var l in Model)
                                {

#line default
#line hidden
            BeginContext(1298, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1385, 6, false);
#line 28 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                       Write(l.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1443, 19, false);
#line 29 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                       Write(l.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1462, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1464, 18, false);
#line 29 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                                            Write(l.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1534, 11, false);
#line 30 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                       Write(l.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(1545, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1597, 10, false);
#line 31 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                       Write(l.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(1607, 53, true);
            WriteLiteral("</td>\r\n                                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1660, "\"", 1687, 2);
            WriteAttributeValue("", 1667, "deleteDish/", 1667, 11, true);
#line 32 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
WriteAttributeValue("", 1678, l.DishId, 1678, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1688, 61, true);
            WriteLiteral(">Delete</a></td>\r\n                                    </tr>\r\n");
            EndContext();
#line 34 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ChefDish\Views\Home\Dishes.cshtml"
                                }

#line default
#line hidden
            BeginContext(1784, 176, true);
            WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
