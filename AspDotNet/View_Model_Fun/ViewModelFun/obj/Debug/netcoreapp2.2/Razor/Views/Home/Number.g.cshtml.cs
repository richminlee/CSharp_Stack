#pragma checksum "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\Home\Number.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a187183f26e70f652be90cc294856a58597320a0"
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
#line 1 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun;

#line default
#line hidden
#line 2 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\_ViewImports.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a187183f26e70f652be90cc294856a58597320a0", @"/Views/Home/Number.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7312364e6c23e4cb7805f9e5f986831fce186000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Number : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 304, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-6 text-center m-4"">
            <h2>Here are some numbers!</h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-3""></div>
        <div class=""col-6 text-center m-4"">
");
            EndContext();
#line 12 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\Home\Number.cshtml"
             foreach(var number in Model)
            {

#line default
#line hidden
            BeginContext(376, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(396, 6, false);
#line 14 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\Home\Number.cshtml"
              Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(402, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 14 "C:\Users\leeri\Desktop\Coding_Dojo\C#Stack\AspDotNet\ViewModelFun\Views\Home\Number.cshtml"
                              ;
            }

#line default
#line hidden
            BeginContext(424, 37, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int[]> Html { get; private set; }
    }
}
#pragma warning restore 1591