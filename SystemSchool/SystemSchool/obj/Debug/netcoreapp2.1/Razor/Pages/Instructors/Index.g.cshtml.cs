#pragma checksum "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c17713e46e424d8c10c5cbf17bf57eaed88535a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SystemSchool.Pages.Instructors.Pages_Instructors_Index), @"mvc.1.0.razor-page", @"/Pages/Instructors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Instructors/Index.cshtml", typeof(SystemSchool.Pages.Instructors.Pages_Instructors_Index), @"{id:int?}")]
namespace SystemSchool.Pages.Instructors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\_ViewImports.cshtml"
using SystemSchool;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c17713e46e424d8c10c5cbf17bf57eaed88535a", @"/Pages/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4e1d96807e89c5d734ceb94501c8cd70137dd07", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Instructors_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";


#line default
#line hidden
            BeginContext(120, 37, true);
            WriteLiteral("\r\n\r\n<h2>Instructors</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(157, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee3b6345fdb2412787ff762f729352d6", async() => {
                BeginContext(178, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(192, 281, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Instructors)
        {
            string selectedRow = "";
            if (item.ID == Model.InstructorID)
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(703, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 718, "\"", 738, 1);
#line 35 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 726, selectedRow, 726, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 47, true);
            WriteLiteral(">\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(787, 43, false);
#line 38 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(830, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(898, 47, false);
#line 41 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(945, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1013, 43, false);
#line 44 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 47 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1208, 30, false);
#line 49 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                   Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 49 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                                       
                    }

#line default
#line hidden
            BeginContext(1263, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 53 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                      
                        foreach (var course in item.CourseAssignments)
                        {
                            

#line default
#line hidden
            BeginContext(1460, 22, false);
#line 56 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                       Write(course.Course.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1485, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(1488, 19, false);
#line 56 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                                   Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1507, 9, true);
            WriteLiteral(" <br />\r\n");
            EndContext();
#line 57 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1566, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1631, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ce0c7117ea472dbdd758255b7118f6", async() => {
                BeginContext(1677, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1687, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1711, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b7749c4d7f04a729b06632633606225", async() => {
                BeginContext(1756, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1764, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1788, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb2f5149b72e408cb1744b6725ecc0fe", async() => {
                BeginContext(1836, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1847, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1871, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "652952efe60d4cb8b7f1ee48757814a1", async() => {
                BeginContext(1918, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1928, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 67 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1983, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
#line 72 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
 if (Model.Instructor.Courses != null)
{

#line default
#line hidden
            BeginContext(2054, 223, true);
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 83 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == Model.CourseID)
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2505, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2520, "\"", 2540, 1);
#line 90 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
WriteAttributeValue("", 2528, selectedRow, 2528, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2541, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2586, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb40a6fad7f462dacdd4f1700722dd8", async() => {
                BeginContext(2644, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
                                                  WriteLiteral(item.CourseID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2654, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2722, 13, false);
#line 95 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
            EndContext();
            BeginContext(2735, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2803, 10, false);
#line 98 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2813, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2881, 20, false);
#line 101 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2901, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 104 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2956, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 107 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
}

#line default
#line hidden
#line 108 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
 if (Model.Instructor.Enrollments != null)
{

#line default
#line hidden
            BeginContext(3022, 178, true);
            WriteLiteral("    <h3>\r\n        Students Enrolled in Selected Course\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
            EndContext();
#line 118 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
         foreach (var item in Model.Instructor.Enrollments)
        {

#line default
#line hidden
            BeginContext(3272, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3333, 21, false);
#line 122 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3354, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3422, 40, false);
#line 125 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3462, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 128 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3517, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 130 "C:\Users\shreeya\source\repos\SystemSchool\SystemSchool\Pages\Instructors\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemSchool.Pages.Instructors.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SystemSchool.Pages.Instructors.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SystemSchool.Pages.Instructors.IndexModel>)PageContext?.ViewData;
        public SystemSchool.Pages.Instructors.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
