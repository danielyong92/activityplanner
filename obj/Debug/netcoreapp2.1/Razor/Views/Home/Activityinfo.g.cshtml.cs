#pragma checksum "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a748635303337d81c89d3e4aa8d76ebf48ad669e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Activityinfo), @"mvc.1.0.view", @"/Views/Home/Activityinfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Activityinfo.cshtml", typeof(AspNetCore.Views_Home_Activityinfo))]
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
#line 1 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/_ViewImports.cshtml"
using BeltExam2;

#line default
#line hidden
#line 2 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/_ViewImports.cshtml"
using BeltExam2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a748635303337d81c89d3e4aa8d76ebf48ad669e", @"/Views/Home/Activityinfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ebe52704f92416eecb1ad36f04801210d7a366", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Activityinfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 102, true);
            WriteLiteral("<h1>Activity Details</h1>\n<a href=\"/Dashboard\"> Home</a>\n<a href=\"logout\">Log off</a><br>\n\n<h2>Title: ");
            EndContext();
            BeginContext(103, 26, false);
#line 5 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
      Write(ViewBag.thisactivity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(129, 29, true);
            WriteLiteral("</h2>\n<h4>Event Coordinator: ");
            EndContext();
            BeginContext(159, 25, false);
#line 6 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
                  Write(ViewBag.theUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(184, 23, true);
            WriteLiteral("<h4>\n\n<h4>Description: ");
            EndContext();
            BeginContext(208, 32, false);
#line 8 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
            Write(ViewBag.thisactivity.Description);

#line default
#line hidden
            EndContext();
            BeginContext(240, 26, true);
            WriteLiteral("</h4>\n\nParticipants:\n<ul>\n");
            EndContext();
#line 12 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
     foreach(var x in @ViewBag.acttouser.ActivityToUser)
    {

#line default
#line hidden
            BeginContext(329, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(342, 17, false);
#line 14 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
       Write(x.Users.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(359, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(361, 16, false);
#line 14 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
                          Write(x.Users.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(377, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 15 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Activityinfo.cshtml"
    }

#line default
#line hidden
            BeginContext(389, 7, true);
            WriteLiteral("</ul>\n\n");
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
