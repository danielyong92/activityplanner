#pragma checksum "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e03ad80164bffdb626e10e8039c0c9b50d9e7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e03ad80164bffdb626e10e8039c0c9b50d9e7a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3ebe52704f92416eecb1ad36f04801210d7a366", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<h1>Dojo Activity Center - Welcome ");
            EndContext();
            BeginContext(36, 17, false);
#line 1 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                              Write(ViewBag.firstname);

#line default
#line hidden
            EndContext();
            BeginContext(53, 261, true);
            WriteLiteral(@"!</h1>
<a href=""logout"">Log off</a>

<table class=""table"">
    <tr>
        <th>Activity</th>
        <th>Date and Time</th>
        <th>Duration</th>
        <th>Event Coordinator</th>
        <th>Number of Participants</th>
        <th>Actions</th>
    </tr>
");
            EndContext();
#line 13 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
     foreach(var thisactivity in ViewBag.allactivities)
    {

#line default
#line hidden
            BeginContext(376, 31, true);
            WriteLiteral("        <tr>\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 407, "\"", 447, 2);
            WriteAttributeValue("", 414, "activity/", 414, 9, true);
#line 16 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 423, thisactivity.ActivityID, 423, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(448, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(450, 18, false);
#line 16 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                                                       Write(thisactivity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(468, 26, true);
            WriteLiteral("</a></td>\n            <td>");
            EndContext();
            BeginContext(495, 35, false);
#line 17 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
           Write(thisactivity.Date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(530, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(534, 17, false);
#line 17 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                                                  Write(thisactivity.Time);

#line default
#line hidden
            EndContext();
            BeginContext(551, 7, true);
            WriteLiteral(" </td>\n");
            EndContext();
#line 18 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
             if(thisactivity.Duration <= 60)
            {

#line default
#line hidden
            BeginContext(617, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(638, 21, false);
#line 20 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
               Write(thisactivity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(659, 14, true);
            WriteLiteral(" Minutes</td>\n");
            EndContext();
#line 21 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
            }
            else if(thisactivity.Duration <= 1440)
            {   
                int duration = thisactivity.Duration/60;

#line default
#line hidden
            BeginContext(812, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(833, 8, false);
#line 25 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
               Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(841, 14, true);
            WriteLiteral(" Hour(s)</td>\n");
            EndContext();
#line 26 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
            }
            else
            {
                int duration = thisactivity.Duration/1440;

#line default
#line hidden
            BeginContext(959, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(980, 8, false);
#line 30 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
               Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(988, 13, true);
            WriteLiteral(" Day(s)</td>\n");
            EndContext();
#line 31 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
            BeginContext(1015, 44, true);
            WriteLiteral("        \n            <td>event coordinator: ");
            EndContext();
            BeginContext(1060, 24, false);
#line 33 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                              Write(thisactivity.Coordinator);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 42, true);
            WriteLiteral("</td>\n           \n\n            <td>Count: ");
            EndContext();
            BeginContext(1127, 33, false);
#line 36 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                  Write(thisactivity.ActivityToUser.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 35, true);
            WriteLiteral("</td>\n           \n            <td>\n");
            EndContext();
#line 39 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                 if(thisactivity.UserID == @ViewBag.sessionid)
                {

#line default
#line hidden
            BeginContext(1276, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1298, "\"", 1336, 2);
            WriteAttributeValue("", 1305, "delete/", 1305, 7, true);
#line 41 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1312, thisactivity.ActivityID, 1312, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1337, 12, true);
            WriteLiteral(">Delete</a>\n");
            EndContext();
#line 42 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(1367, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 43 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                 if(thisactivity.ActivityToUser.Count == 0)
                {

#line default
#line hidden
            BeginContext(1445, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1467, "\"", 1522, 4);
            WriteAttributeValue("", 1474, "join/", 1474, 5, true);
#line 45 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1479, thisactivity.ActivityID, 1479, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 1503, "/", 1503, 1, true);
#line 45 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1504, ViewBag.sessionid, 1504, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1523, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 46 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                    
                }

#line default
#line hidden
            BeginContext(1572, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 48 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                 if(thisactivity.ActivityToUser.Count > 0)
                {
                    bool join = false;
                    int partid = 0;
                    

#line default
#line hidden
#line 52 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                     foreach(var Y in thisactivity.ActivityToUser)
                    {
                        

#line default
#line hidden
#line 54 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                         if(Y.UserID == @ViewBag.sessionid)
                        {
                            join = true;
                            partid = Y.ParticipateID;
                        }

#line default
#line hidden
#line 58 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                         
                    }

#line default
#line hidden
#line 60 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                     if( join == true)
                    {

#line default
#line hidden
            BeginContext(2103, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2129, "\"", 2149, 2);
            WriteAttributeValue("", 2136, "leave/", 2136, 6, true);
#line 62 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2142, partid, 2142, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2150, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 63 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#line 64 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                     if( join == false)
                    {

#line default
#line hidden
            BeginContext(2245, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2271, "\"", 2326, 4);
            WriteAttributeValue("", 2278, "join/", 2278, 5, true);
#line 66 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2283, thisactivity.ActivityID, 2283, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 2307, "/", 2307, 1, true);
#line 66 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2308, ViewBag.sessionid, 2308, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2327, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 67 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                    }

#line default
#line hidden
#line 67 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2377, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 71 "/Users/danny/Documents/coding_dojo/c_sharp/entity_framework/BeltExam2/Views/Home/Dashboard.cshtml"
    }

#line default
#line hidden
            BeginContext(2415, 67, true);
            WriteLiteral("</table>\n\n\n\n<a href=\"NewActivity\"><button>New Activity</button></a>");
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