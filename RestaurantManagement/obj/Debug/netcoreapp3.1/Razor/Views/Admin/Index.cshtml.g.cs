#pragma checksum "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9108a8c4c98d48e07161770c49c0cc4356d03d87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108a8c4c98d48e07161770c49c0cc4356d03d87", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c590e720df66ce541edd97d5ad8326a4a5746c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Управление пользователями";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card bg-default shadow"">
    <div class=""card-header bg-transparent border-0"">
        <h3 class=""text-white mb-0"">Пользователи</h3>
    </div>
<div>
    <div id=""PlaceHolder""></div>
    <button type=""button"" class=""btn btn-success btn-lg btn-block"" data-toggle=""ajax-modal"" data-target=""#userCreate"" data-url=""");
#nullable restore
#line 14 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                                                                                                                           Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
        <span class=""btn-inner--icon""><i class=""ni ni-single-02""></i></span>
        <span class=""btn-inner--text"">Создать пользователя</span>
    </button>
    <div class=""table-responsive"">
        <table class=""table align-items-center table-flush"">
            <thead class=""thead-dark"">
            <tr>
                <th scope=""col"" class=""align-items-center"" data-sort=""id"">ID</th>
                <th scope=""col"" class=""align-items-center"" data-sort=""name"">Имя пользователя</th>
                <th scope=""col"" class=""align-items-center"" data-sort=""email"">E-mail</th>
                <th scope=""col""></th>
            </tr>
            </thead>
            <tbody class=""list"">
");
#nullable restore
#line 29 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
             if (!Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td colspan=\"4\" class=\"text-white align-items-center\">Нет зарегистрированных пользователей</td></tr>\r\n");
#nullable restore
#line 32 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                 foreach (IdentityUser user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-white align-items-center\">");
#nullable restore
#line 38 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                                                             Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-white align-items-center\">");
#nullable restore
#line 39 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                                                             Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"text-white align-items-center\">");
#nullable restore
#line 40 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                                                             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td class=""text-right"">
                            <div class=""dropdown"">
                                <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""fas fa-ellipsis-v""></i>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9108a8c4c98d48e07161770c49c0cc4356d03d878819", async() => {
                WriteLiteral("Изменить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9108a8c4c98d48e07161770c49c0cc4356d03d8710301", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Admin\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
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
                        <i class=""fas fa-angle-right""></i>
                        <span class=""s");
            WriteLiteral("r-only\">Next</span>\r\n                    </a>\r\n                </li>\r\n            </ul>\r\n        </nav>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
