#pragma checksum "C:\Anton\CS programms\RestaurantManagement\RestaurantManagement\Views\Profile\ProfileIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "947af84946dfcc334ce6084ed23193543b827033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_ProfileIndex), @"mvc.1.0.view", @"/Views/Profile/ProfileIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"947af84946dfcc334ce6084ed23193543b827033", @"/Views/Profile/ProfileIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7061b44ab28a492c44f42110b6dab5d8a453bd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_ProfileIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RestaurantManagement.Data.AdditionalUserInformation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/img-1-1000x600.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/theme/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""header pb-6 d-flex align-items-center"" style=""min-height: 500px; background-image: url(~/img/theme/profile-cover.jpg); background-size: cover; background-position: center top;"">
        <!-- Mask -->
        <span class=""mask bg-gradient-default opacity-8""></span>
        <!-- Header container -->
        <div class=""container-fluid d-flex align-items-center"">
            <div class=""row"">
                <div class=""col-lg-7 col-md-10"">
                    <h1 class=""display-2 text-white"">Hello Jesse</h1>
                    <p class=""text-white mt-0 mb-5"">This is your profile page. You can see the progress you've made with your work and manage your projects or assigned tasks</p>
                    <a href=""#!"" class=""btn btn-neutral"">Edit profile</a>
                </div>
            </div>
        </div>
    </div>
    <!-- Page content -->
    <div class=""container-fluid mt--6"">
        <div class=""row"">
            <div class=""col-xl-4 order-xl-2"">
                <d");
            WriteLiteral("iv class=\"card card-profile\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "947af84946dfcc334ce6084ed23193543b8270336435", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-3 order-lg-2"">
                            <div class=""card-profile-image"">
                                <a href=""#"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "947af84946dfcc334ce6084ed23193543b8270337904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class=""card-header text-center border-0 pt-8 pt-md-4 pb-0 pb-md-4"">
                        <div class=""d-flex justify-content-between"">
                            <a href=""#"" class=""btn btn-sm btn-info  mr-4 "">Connect</a>
                            <a href=""#"" class=""btn btn-sm btn-default float-right"">Message</a>
                        </div>
                    </div>
                    <div class=""card-body pt-0"">
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""card-profile-stats d-flex justify-content-center"">
                                    <div>
                                        <span class=""heading"">22</span>
                                        <span class=""description"">Friends</span>
                                    </div>
  ");
            WriteLiteral(@"                                  <div>
                                        <span class=""heading"">10</span>
                                        <span class=""description"">Photos</span>
                                    </div>
                                    <div>
                                        <span class=""heading"">89</span>
                                        <span class=""description"">Comments</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""text-center"">
                            <h5 class=""h3"">
                                Jessica Jones<span class=""font-weight-light"">, 27</span>
                            </h5>
                            <div class=""h5 font-weight-300"">
                                <i class=""ni location_pin mr-2""></i>Bucharest, Romania
                            </div>
                           ");
            WriteLiteral(@" <div class=""h5 mt-4"">
                                <i class=""ni business_briefcase-24 mr-2""></i>Solution Manager - Creative Tim Officer
                            </div>
                            <div>
                                <i class=""ni education_hat mr-2""></i>University of Computer Science
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-8 order-xl-1"">
                <div class=""card"">
                    <div class=""card-header"">
                        <div class=""row align-items-center"">
                            <div class=""col-8"">
                                <h3 class=""mb-0"">Edit profile </h3>
                            </div>
                            <div class=""col-4 text-right"">
                                <a href=""#!"" class=""btn btn-sm btn-primary"">Settings</a>
                            </div>
                        </div>
      ");
            WriteLiteral("              </div>\r\n                    <div class=\"card-body\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "947af84946dfcc334ce6084ed23193543b82703312345", async() => {
                WriteLiteral(@"
                            <h6 class=""heading-small text-muted mb-4"">User information</h6>
                            <div class=""pl-lg-4"">
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-username"">Username</label>
                                            <input type=""text"" id=""input-username"" class=""form-control"" placeholder=""Username"" value=""lucky.jesse"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-email"">Email address</label>
                                            <input type=""email"" id=""input-email"" class=""form-contr");
                WriteLiteral(@"ol"" placeholder=""jesse@example.com"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-first-name"">First name</label>
                                            <input type=""text"" id=""input-first-name"" class=""form-control"" placeholder=""First name"" value=""Lucky"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-6"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-last-name"">Last name</label>
                                            <input type=""text"" id=""input");
                WriteLiteral(@"-last-name"" class=""form-control"" placeholder=""Last name"" value=""Jesse"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr class=""my-4"" />
                            <!-- Address -->
                            <h6 class=""heading-small text-muted mb-4"">Contact information</h6>
                            <div class=""pl-lg-4"">
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-address"">Address</label>
                                            <input id=""input-address"" class=""form-control"" placeholder=""Home Address"" value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"" type=""text"">
                                        </div>
           ");
                WriteLiteral(@"                         </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-city"">City</label>
                                            <input type=""text"" id=""input-city"" class=""form-control"" placeholder=""City"" value=""New York"">
                                        </div>
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">Country</label>
                                            <input type=""text"" id=""input-country"" class=""form-control"" placeholder=""Country"" value=""United States"">
                                        </div");
                WriteLiteral(@">
                                    </div>
                                    <div class=""col-lg-4"">
                                        <div class=""form-group"">
                                            <label class=""form-control-label"" for=""input-country"">Postal code</label>
                                            <input type=""number"" id=""input-postal-code"" class=""form-control"" placeholder=""Postal code"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <hr class=""my-4"" />
                            <!-- Description -->
                            <h6 class=""heading-small text-muted mb-4"">About me</h6>
                            <div class=""pl-lg-4"">
                                <div class=""form-group"">
                                    <label class=""form-control-label"">About Me</label>
                                    <textarea ");
                WriteLiteral("rows=\"4\" class=\"form-control\" placeholder=\"A few words about you ...\">A beautiful Dashboard for Bootstrap 4. It is Free and Open Source.</textarea>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantManagement.Data.AdditionalUserInformation> Html { get; private set; }
    }
}
#pragma warning restore 1591
