#pragma checksum "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e047b3b45213aacc29756ee4a8c8bbbe2d3ef2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Weapon_DetailsWeapon), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Weapon/DetailsWeapon.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Weapon/DetailsWeapon.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Weapon_DetailsWeapon), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e047b3b45213aacc29756ee4a8c8bbbe2d3ef2", @"/Areas/Admin/Pages/Weapon/DetailsWeapon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc54aa07e883ba4fc746ee89916f6c575ed408ec", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Weapon_DetailsWeapon : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditWeapon", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AllWeapons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 106, true);
            WriteLiteral("\r\n<h1>Weapon Details</h1>\r\n\r\n<hr />\r\n<div>    \r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(240, 47, false);
#line 15 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.Name));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 43, false);
#line 18 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayFor(model => model.Weapon.Name));

#line default
#line hidden
            EndContext();
            BeginContext(374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(418, 51, false);
#line 21 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(469, 47, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 516, "\"", 546, 1);
#line 24 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
WriteAttributeValue("", 522, Model.Weapon.ImageUrl, 522, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(547, 95, true);
            WriteLiteral(" alt=\"HTML5 Icon\" style=\"width:128px;height:128px;\">\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(643, 55, false);
#line 27 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.DamagePoints));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(742, 51, false);
#line 30 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayFor(model => model.Weapon.DamagePoints));

#line default
#line hidden
            EndContext();
            BeginContext(793, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(837, 63, false);
#line 33 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(900, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(944, 59, false);
#line 36 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayFor(model => model.Weapon.DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1047, 61, false);
#line 39 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.CriticalAttackMode));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1152, 57, false);
#line 42 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayFor(model => model.Weapon.CriticalAttackMode));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1253, 48, false);
#line 45 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayNameFor(model => model.Weapon.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1345, 44, false);
#line 48 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
       Write(Html.DisplayFor(model => model.Weapon.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 110, true);
            WriteLiteral(" <span style=\"font-family:Georgia;color:darkgoldenrod\">₡</span>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1499, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd4856ab48b04f79a8e4fae01cbea686", async() => {
                BeginContext(1558, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Lubomir\Desktop\Project Defense\RobotArena-master\RobotArena\Areas\Admin\Pages\Weapon\DetailsWeapon.cshtml"
                                 WriteLiteral(Model.Weapon.Id);

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
            BeginContext(1566, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1574, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b09f9873f312456fb4becfeafc61983b", async() => {
                BeginContext(1601, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1617, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsWeaponModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsWeaponModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsWeaponModel>)PageContext?.ViewData;
        public DetailsWeaponModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591