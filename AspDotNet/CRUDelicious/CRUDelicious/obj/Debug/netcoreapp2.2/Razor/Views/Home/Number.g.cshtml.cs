#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbd0452c3c64ff56321436279edfa656062a075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Number), @"mvc.1.0.view", @"/Views/Home/Number.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Number.cshtml", typeof(AspNetCore.Views_Home_Number))]
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
#line 1 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbd0452c3c64ff56321436279edfa656062a075", @"/Views/Home/Number.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Number : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 340, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-2""></div>
            <div class=""col-8"">
                <div class=""row"">
                    <div class=""col""><a href=""/"">Home</a></div>
                </div>
                <div class=""row"">
                    <div class=""col text-center""><h1>");
            EndContext();
            BeginContext(341, 10, false);
#line 9 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(351, 156, true);
            WriteLiteral("</h1></div>\r\n                </div>\r\n                <div class=\"row pb-4 border-bottom border-dark\">\r\n                    <div class=\"col text-center\"><h3>");
            EndContext();
            BeginContext(508, 10, false);
#line 12 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
                                                Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(518, 254, true);
            WriteLiteral("</h3></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-4\">\r\n            <div class=\"col-2\"></div>\r\n            <div class=\"col-8\">\r\n                <div class=\"row mt-4\">\r\n                    <div class=\"col\">");
            EndContext();
            BeginContext(773, 17, false);
#line 20 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
                                Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(790, 136, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"row mt-4\">\r\n                    <div class=\"col\"><strong>Calories:</strong> ");
            EndContext();
            BeginContext(927, 14, false);
#line 23 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
                                                           Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(941, 137, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"row mt-4\">\r\n                    <div class=\"col\"><strong>Tastiness:</strong> ");
            EndContext();
            BeginContext(1079, 15, false);
#line 26 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
                                                            Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(1094, 131, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"row mt-4\">\r\n                    <div class=\"col text-center\"><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1253, 2);
            WriteAttributeValue("", 1232, "/delete/", 1232, 8, true);
#line 29 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
WriteAttributeValue("", 1240, Model.DishId, 1240, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1254, 87, true);
            WriteLiteral(">Delete</a></button></div>\r\n                    <div class=\"col text-center\"><button><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1341, "\"", 1367, 2);
            WriteAttributeValue("", 1348, "/edit/", 1348, 6, true);
#line 30 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\Views\Home\Number.cshtml"
WriteAttributeValue("", 1354, Model.DishId, 1354, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1368, 96, true);
            WriteLiteral(">Edit</a></button></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
