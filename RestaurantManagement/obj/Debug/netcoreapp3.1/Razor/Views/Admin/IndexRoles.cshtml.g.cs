#pragma checksum "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8a6d6202abf4ab9a940b1c02c35654df9eac458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_IndexRoles), @"mvc.1.0.view", @"/Views/Admin/IndexRoles.cshtml")]
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
#line 1 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\_ViewImports.cshtml"
using RestaurantManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\_ViewImports.cshtml"
using RestaurantManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a6d6202abf4ab9a940b1c02c35654df9eac458", @"/Views/Admin/IndexRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7061b44ab28a492c44f42110b6dab5d8a453bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_IndexRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::RestaurantManagement.Helpers.RoleUsersTagHelper __RestaurantManagement_Helpers_RoleUsersTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
  
    ViewData["Title"] = "???????????????????? ???????????? ??????????????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card bg-default shadow"">
    <div class=""card-header bg-transparent border-0"">
        <h3 class=""text-white mb-0"">???????? ??????????????????????????</h3>
    </div>
    <div>
        <div id=""PlaceHolder""></div>
        <button type=""button"" class=""btn btn-success btn-lg btn-block"" data-toggle=""ajax-modal"" data-target=""#roleCreate"" data-url=""");
#nullable restore
#line 13 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                                                                               Write(Url.Action("CreateRole"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <span class=""btn-inner--icon""><i class=""ni ni-hat-3""></i></span>
            <span class=""btn-inner--text"">?????????????? ???????? ????????????????????????</span>
        </button>
        <div class=""table-responsive"">
            <table class=""table align-items-center table-flush"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"" class=""align-items-center"" data-sort=""id"">??????????</th>
                        <th scope=""col"" class=""align-items-center"" data-sort=""name"">???????????????????????? ????????</th>
                        <th scope=""col"" class=""align-items-center"" data-sort=""email"">????????????????????????</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr><td colspan=\"4\" class=\"text-white align-items-center\">???????? ?????????????????????????? ?????? ???? ??????????????</td></tr>\r\n");
#nullable restore
#line 31 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                    }
                    else
                    {
                        int counter = 1;
                        foreach (IdentityRole role in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-white align-items-center\">");
#nullable restore
#line 38 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                     Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-white align-items-center\">");
#nullable restore
#line 39 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                     Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8a6d6202abf4ab9a940b1c02c35654df9eac4588048", async() => {
            }
            );
            __RestaurantManagement_Helpers_RoleUsersTagHelper = CreateTagHelper<global::RestaurantManagement.Helpers.RoleUsersTagHelper>();
            __tagHelperExecutionContext.Add(__RestaurantManagement_Helpers_RoleUsersTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                          WriteLiteral(role.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __RestaurantManagement_Helpers_RoleUsersTagHelper.Role = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("role-users", __RestaurantManagement_Helpers_RoleUsersTagHelper.Role, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <td class=""text-right"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fas fa-ellipsis-v""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8a6d6202abf4ab9a940b1c02c35654df9eac45810334", async() => {
                WriteLiteral("\r\n                                                <button type=\"submit\" class=\"btn btn-secondary btn-lg btn-block\">????????????????</button>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                          WriteLiteral(role.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <button type=\"button\" class=\"btn btn-secondary btn-lg btn-block\" data-toggle=\"ajax-modal\" data-target=\"#roleDelete\" data-url=\"");
#nullable restore
#line 50 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                                                                                                                                                                     Write(Url.Action($"DeleteRole/{role.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">??????????????</button>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 55 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\IndexRoles.cshtml"
                            counter++;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""card-footer py-4"">
            <nav aria-label=""..."">
                <ul class=""pagination justify-content-end mb-0"">
                    <li class=""page-item disabled"">
                        <a class=""page-link"" href=""#"" tabindex=""-1"">
                            <i class=""fas fa-angle-left""></i>
                            <span class=""sr-only"">Previous</span>
                        </a>
                    </li>
                    <li class=""page-item active"">
                        <a class=""page-link"" href=""#"">1</a>
                    </li>
                    <li class=""page-item"">
                        <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item"">
                        <a class=""page-link"" href=""#"">
              ");
            WriteLiteral("              <i class=\"fas fa-angle-right\"></i>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
