#pragma checksum "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddea05053811fa267a7444bc1c106c09d19d19f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ingredients_IngredientsIndex), @"mvc.1.0.view", @"/Views/Ingredients/IngredientsIndex.cshtml")]
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
#line 1 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
using RestaurantManagement.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddea05053811fa267a7444bc1c106c09d19d19f9", @"/Views/Ingredients/IngredientsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7061b44ab28a492c44f42110b6dab5d8a453bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Ingredients_IngredientsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ingredients>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
  
    ViewData["Title"] = "Управление ингредиентами";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card bg-default shadow"">
    <div class=""card-header bg-transparent border-0"">
        <h3 class=""text-white mb-0"">Ингредиенты</h3>
    </div>
    <div>
        <div id=""PlaceHolder""></div>
        <button type=""button"" class=""btn btn-success btn-lg btn-block"" data-toggle=""ajax-modal"" data-target=""#ingredientCreate"" data-url=""");
#nullable restore
#line 13 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                                                                                     Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
            <span class=""btn-inner--icon""><i class=""ni ni-archive-2""></i></span>
            <span class=""btn-inner--text"">Создать ингредиент</span>
        </button>
        <div class=""table-responsive"">
            <table class=""table align-items-center table-flush"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"" class=""align-items-center"" data-sort=""number"">Номер</th>
                        <th scope=""col"" class=""align-items-center"" data-sort=""name"">Ингредиент</th>
                        <th scope=""col"" class=""align-items-center"" data-sort=""email"">Единица измерения</th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
                <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                     if (!Model.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr><td colspan=\"4\" class=\"text-white align-items-center\">Ингредиенты еще не созданы</td></tr>\r\n");
#nullable restore
#line 31 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                    }
                    else
                    {
                        int counter = 1;
                        foreach (Ingredients ing in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-white align-items-center\">");
#nullable restore
#line 38 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                     Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-white align-items-center\">");
#nullable restore
#line 39 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                     Write(ing.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-white align-items-center\">");
#nullable restore
#line 40 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                     Write(ing.UnitOfMeasurement);

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
                                            <button type=""button"" class=""btn btn-secondary btn-lg btn-block"" data-toggle=""ajax-modal"" data-target=""#ingredientEdit"" data-url=""");
#nullable restore
#line 47 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                                                                                                                         Write(Url.Action($"Edit/{ing.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Изменить</button>\r\n                                            <button type=\"button\" class=\"btn btn-secondary btn-lg btn-block\" data-toggle=\"ajax-modal\" data-target=\"#ingredientDelete\" data-url=\"");
#nullable restore
#line 48 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"
                                                                                                                                                                           Write(Url.Action($"Delete/{ing.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Удалить</button>\r\n                                        </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 53 "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Ingredients\IngredientsIndex.cshtml"

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
            WriteLiteral("              <i class=\"fas fa-angle-right\"></i>\r\n                            <span class=\"sr-only\">Next</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ingredients>> Html { get; private set; }
    }
}
#pragma warning restore 1591