#pragma checksum "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd0bb6acdb57656e9cd568808bcb1fb5219a45c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Weapon_AllWeapons), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Weapon/AllWeapons.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Weapon/AllWeapons.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Weapon_AllWeapons), null)]
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
#line 1 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena;

#line default
#line hidden
#line 2 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena.Models;

#line default
#line hidden
#line 3 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena.Areas.Admin.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd0bb6acdb57656e9cd568808bcb1fb5219a45c1", @"/Areas/Admin/Pages/Weapon/AllWeapons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc54aa07e883ba4fc746ee89916f6c575ed408ec", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Weapon_AllWeapons : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditWeapon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:purple;color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsWeapon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteWeapon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 118, true);
            WriteLiteral("\r\n<h1>All Weapons</h1>\r\n\r\n<hr />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(240, 50, false);
#line 16 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(346, 58, false);
#line 19 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].DamagePoints));

#line default
#line hidden
            EndContext();
            BeginContext(404, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 56, false);
#line 22 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].Durability));

#line default
#line hidden
            EndContext();
            BeginContext(516, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 66, false);
#line 25 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(638, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(694, 54, false);
#line 28 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(748, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(804, 64, false);
#line 31 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].CriticalAttackMode));

#line default
#line hidden
            EndContext();
            BeginContext(868, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(924, 51, false);
#line 34 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
           Write(Html.DisplayNameFor(model => model.Weapon[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(975, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
         foreach (var item in Model.Weapon)
        {

#line default
#line hidden
            BeginContext(1117, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1178, 39, false);
#line 44 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1285, 47, false);
#line 47 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.DamagePoints));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1400, 45, false);
#line 50 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.Durability));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1513, 55, false);
#line 53 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 71, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1639, "\"", 1661, 1);
#line 56 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
WriteAttributeValue("", 1645, item.ImageUrl, 1645, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1662, 119, true);
            WriteLiteral(" alt=\"HTML5 Icon\" style=\"width:128px;height:128px;\">\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1782, 53, false);
#line 59 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.CriticalAttackMode));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1903, 40, false);
#line 62 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1943, 150, true);
            WriteLiteral(" <span style=\"font-family:Georgia;color:darkgoldenrod\">₡</span>                    \r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2093, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edcf4c705dad4d54acd2f8e9fb341ffe", async() => {
                BeginContext(2168, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
                                                                         WriteLiteral(item.Id);

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
            BeginContext(2176, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2198, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cd3807d41f94478a6a1ea98f6e03dda", async() => {
                BeginContext(2308, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
                                                                                                            WriteLiteral(item.Id);

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
            BeginContext(2319, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2341, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00148d3142224bd0a0c2a15b9721332b", async() => {
                BeginContext(2417, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
                                                                          WriteLiteral(item.Id);

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
            BeginContext(2427, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\AllWeapons.cshtml"
        }

#line default
#line hidden
            BeginContext(2482, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllWeaponsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllWeaponsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllWeaponsModel>)PageContext?.ViewData;
        public AllWeaponsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
