#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4df3aa4adc3a05007d267c9a12130fac2aaad4c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4df3aa4adc3a05007d267c9a12130fac2aaad4c5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 577, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-2""></div>
        <div class=""col-8"">
            <div class=""row"">
                <div class=""col mt-4 mb-4 text-center""><h1>Welcome to CRUDelicious</h1></div>
            </div>
            <div class=""row"">
                <div class=""col mt-4 pb-4 border-bottom border-dark"">Check out some recent dishes!</div>
                <div class=""col mt-4 mb-4 text-right""><a href=""/new"">Add a Dish</a></div>
            </div>
            <div class=""row mt-4"">
                <div class=""col"">
");
            EndContext();
#line 14 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml"
                     foreach(var l in @Model)
                    {

#line default
#line hidden
            BeginContext(647, 90, true);
            WriteLiteral("                        <div class=\"row\">\r\n                            <div class=\"col\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 737, "\"", 754, 2);
            WriteAttributeValue("", 744, "/", 744, 1, true);
#line 17 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 745, l.DishId, 745, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(755, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(757, 6, false);
#line 17 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml"
                                                             Write(l.Name);

#line default
#line hidden
            EndContext();
            BeginContext(763, 8, true);
            WriteLiteral("</a> by ");
            EndContext();
            BeginContext(772, 6, false);
#line 17 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml"
                                                                            Write(l.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(778, 40, true);
            WriteLiteral("</div>\r\n                        </div>\r\n");
            EndContext();
#line 19 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\CRUDelicious\CRUDelicious\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(841, 78, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
