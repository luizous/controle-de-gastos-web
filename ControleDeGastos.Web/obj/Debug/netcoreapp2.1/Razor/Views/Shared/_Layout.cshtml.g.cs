#pragma checksum "C:\Users\gabri\controle-de-gastos-web\ControleDeGastos.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82a7cb0f882d1adaea16cadc798d50fc7a107a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\gabri\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web;

#line default
#line hidden
#line 2 "C:\Users\gabri\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e82a7cb0f882d1adaea16cadc798d50fc7a107a4", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8362db70870513e98ca1d998932338fc7a82a09", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 643, true);
            WriteLiteral(@"<!--
=========================================================
 Paper Dashboard 2 - v2.0.0
=========================================================

 Product Page: https://www.creative-tim.com/product/paper-dashboard-2
 Copyright 2019 Creative Tim (https://www.creative-tim.com)
 Licensed under MIT (https://github.com/creativetimofficial/paper-dashboard/blob/master/LICENSE)

 Coded by Creative Tim

=========================================================

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. -->

<!DOCTYPE html>
<html lang=""en"">
");
            EndContext();
            BeginContext(643, 1018, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7a20aa3f901405280511ec6b94125f1", async() => {
                BeginContext(649, 281, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""../assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""../assets/img/favicon.png"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
    <title>
        ");
                EndContext();
                BeginContext(931, 13, false);
#line 24 "C:\Users\gabri\controle-de-gastos-web\ControleDeGastos.Web\Views\Shared\_Layout.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(944, 710, true);
                WriteLiteral(@"
    </title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />
    <!--     Fonts and icons     -->
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700,200"" rel=""stylesheet"" />
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"" rel=""stylesheet"">
    <!-- CSS Files -->
    <link href=""../assets/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""../assets/css/paper-dashboard.css?v=2.0.0"" rel=""stylesheet"" />
    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href=""../assets/demo/demo.css"" rel=""stylesheet"" />
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1661, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1663, 9709, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49954408232644e891dd083903b4bc62", async() => {
                BeginContext(1678, 4388, true);
                WriteLiteral(@"
    <div class=""wrapper "">
        <div class=""sidebar"" data-color=""white"" data-active-color=""danger"">
            <!--
                Tip 1: You can change the color of the sidebar using: data-color=""blue | green | orange | red | yellow""
            -->
            <div class=""logo"">
                <a href=""http://www.creative-tim.com"" class=""simple-text logo-mini"">
                    <div class=""logo-image-small"">
                        <img src=""../assets/img/logo-small.png"">
                    </div>
                </a>
                <a href=""http://www.creative-tim.com"" class=""simple-text logo-normal"">
                    Creative Tim
                    <!-- <div class=""logo-image-big"">
                      <img src=""../assets/img/logo-big.png"">
                    </div> -->
                </a>
            </div>
            <div class=""sidebar-wrapper"">
                <ul class=""nav"">
                    <li class=""active "">
                        <a href=""./dashboar");
                WriteLiteral(@"d.html"">
                            <i class=""nc-icon nc-bank""></i>
                            <p>Dashboard</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./icons.html"">
                            <i class=""nc-icon nc-diamond""></i>
                            <p>Icons</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./map.html"">
                            <i class=""nc-icon nc-pin-3""></i>
                            <p>Maps</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./notifications.html"">
                            <i class=""nc-icon nc-bell-55""></i>
                            <p>Notifications</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./user.html"">
                            <i class=""nc-icon nc-si");
                WriteLiteral(@"ngle-02""></i>
                            <p>User Profile</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./tables.html"">
                            <i class=""nc-icon nc-tile-56""></i>
                            <p>Table List</p>
                        </a>
                    </li>
                    <li>
                        <a href=""./typography.html"">
                            <i class=""nc-icon nc-caps-small""></i>
                            <p>Typography</p>
                        </a>
                    </li>
                    <li class=""active-pro"">
                        <a href=""./upgrade.html"">
                            <i class=""nc-icon nc-spaceship""></i>
                            <p>Upgrade to PRO</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""main-panel"">
            <!-- Navbar -->
            <nav");
                WriteLiteral(@" class=""navbar navbar-expand-lg navbar-absolute fixed-top navbar-transparent"">
                <div class=""container-fluid"">
                    <div class=""navbar-wrapper"">
                        <div class=""navbar-toggle"">
                            <button type=""button"" class=""navbar-toggler"">
                                <span class=""navbar-toggler-bar bar1""></span>
                                <span class=""navbar-toggler-bar bar2""></span>
                                <span class=""navbar-toggler-bar bar3""></span>
                            </button>
                        </div>
                        <a class=""navbar-brand"" href=""#pablo"">Paper Dashboard 2</a>
                    </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-bar navbar-kebab""></span>
                 ");
                WriteLiteral(@"       <span class=""navbar-toggler-bar navbar-kebab""></span>
                        <span class=""navbar-toggler-bar navbar-kebab""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-end"" id=""navigation"">
                        ");
                EndContext();
                BeginContext(6066, 544, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52def251631047a08882440020344fc1", async() => {
                    BeginContext(6072, 531, true);
                    WriteLiteral(@"
                            <div class=""input-group no-border"">
                                <input type=""text"" value="""" class=""form-control"" placeholder=""Search..."">
                                <div class=""input-group-append"">
                                    <div class=""input-group-text"">
                                        <i class=""nc-icon nc-zoom-split""></i>
                                    </div>
                                </div>
                            </div>
                        ");
                    EndContext();
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
                EndContext();
                BeginContext(6610, 2162, true);
                WriteLiteral(@"
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                <a class=""nav-link btn-magnify"" href=""#pablo"">
                                    <i class=""nc-icon nc-layout-11""></i>
                                    <p>
                                        <span class=""d-lg-none d-md-block"">Stats</span>
                                    </p>
                                </a>
                            </li>
                            <li class=""nav-item btn-rotate dropdown"">
                                <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""nc-icon nc-bell-55""></i>
                                    <p>
                                        <span class=""d-lg-none d-md-block"">Some Actions</span>
                                    </p>
           ");
                WriteLiteral(@"                     </a>
                                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
                                    <a class=""dropdown-item"" href=""#"">Action</a>
                                    <a class=""dropdown-item"" href=""#"">Another action</a>
                                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                                </div>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link btn-rotate"" href=""#pablo"">
                                    <i class=""nc-icon nc-settings-gear-65""></i>
                                    <p>
                                        <span class=""d-lg-none d-md-block"">Account</span>
                                    </p>
                                </a>
                            </li>
                        </ul>
                    </div>
                ");
                WriteLiteral("</div>\r\n            </nav>\r\n            <!-- End Navbar -->\r\n\r\n            <div class=\"content\">\r\n                ");
                EndContext();
                BeginContext(8773, 12, false);
#line 175 "C:\Users\gabri\controle-de-gastos-web\ControleDeGastos.Web\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(8785, 2580, true);
                WriteLiteral(@"
            </div>
            <footer class=""footer footer-black  footer-white "">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <nav class=""footer-nav"">
                            <ul>
                                <li>
                                    <a href=""https://www.creative-tim.com"" target=""_blank"">Creative Tim</a>
                                </li>
                                <li>
                                    <a href=""http://blog.creative-tim.com/"" target=""_blank"">Blog</a>
                                </li>
                                <li>
                                    <a href=""https://www.creative-tim.com/license"" target=""_blank"">Licenses</a>
                                </li>
                            </ul>
                        </nav>
                        <div class=""credits ml-auto"">
                            <span class=""copyright"">
                                ©
 ");
                WriteLiteral(@"                               <script>
                                    document.write(new Date().getFullYear())
                                </script>, made with <i class=""fa fa-heart heart""></i> by Creative Tim
                            </span>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    </div>
    <!--   Core JS Files   -->
    <script src=""../assets/js/core/jquery.min.js""></script>
    <script src=""../assets/js/core/popper.min.js""></script>
    <script src=""../assets/js/core/bootstrap.min.js""></script>
    <script src=""../assets/js/plugins/perfect-scrollbar.jquery.min.js""></script>
    <!--  Google Maps Plugin    -->
    <script src=""https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE""></script>
    <!-- Chart JS -->
    <script src=""../assets/js/plugins/chartjs.min.js""></script>
    <!--  Notifications Plugin    -->
    <script src=""../assets/js/plugins/bootstrap-notify.js""></script>
    <!--");
                WriteLiteral(@" Control Center for Now Ui Dashboard: parallax effects, scripts for the example pages etc -->
    <script src=""../assets/js/paper-dashboard.min.js?v=2.0.0"" type=""text/javascript""></script>
    <!-- Paper Dashboard DEMO methods, don't include it in your project! -->
    <script src=""../assets/demo/demo.js""></script>
    <script>
        $(document).ready(function () {
            // Javascript method's body can be found in assets/assets-for-demo/js/demo.js
            demo.initChartsPages();
        });
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11372, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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