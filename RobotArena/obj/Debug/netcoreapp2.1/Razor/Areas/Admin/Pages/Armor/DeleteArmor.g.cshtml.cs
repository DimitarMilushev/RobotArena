#pragma checksum "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a04f3eca93da78eb91617023503e2fa8072f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_Armor_DeleteArmor), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Armor/DeleteArmor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Armor/DeleteArmor.cshtml", typeof(AspNetCore.Areas_Admin_Pages_Armor_DeleteArmor), @"{id}")]
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
#line 1 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena;

#line default
#line hidden
#line 2 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena.Models;

#line default
#line hidden
#line 3 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\_ViewImports.cshtml"
using RobotArena.Areas.Admin.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a04f3eca93da78eb91617023503e2fa8072f3e", @"/Areas/Admin/Pages/Armor/DeleteArmor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc54aa07e883ba4fc746ee89916f6c575ed408ec", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Armor_DeleteArmor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./AllArmors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 38, true);
            WriteLiteral("\r\n<h1>Are you sure you want to delete ");
            EndContext();
            BeginContext(170, 16, false);
#line 9 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
                                Write(Model.Armor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(187, 116, true);
            WriteLiteral(" ?</h1>\r\n\r\n<hr />\r\n<div>\r\n    <h4>Armor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(304, 46, false);
#line 17 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayNameFor(model => model.Armor.Name));

#line default
#line hidden
            EndContext();
            BeginContext(350, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(394, 42, false);
#line 20 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayFor(model => model.Armor.Name));

#line default
#line hidden
            EndContext();
            BeginContext(436, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(480, 50, false);
#line 23 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayNameFor(model => model.Armor.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(530, 47, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 577, "\"", 606, 1);
#line 26 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
WriteAttributeValue("", 583, Model.Armor.ImageUrl, 583, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 95, true);
            WriteLiteral(" alt=\"HTML5 Icon\" style=\"width:128px;height:128px;\">\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(703, 53, false);
#line 29 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayNameFor(model => model.Armor.ArmorPoints));

#line default
#line hidden
            EndContext();
            BeginContext(756, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(800, 49, false);
#line 32 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayFor(model => model.Armor.ArmorPoints));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(893, 62, false);
#line 35 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayNameFor(model => model.Armor.DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(955, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(999, 58, false);
#line 38 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayFor(model => model.Armor.DurabilityLossAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1101, 47, false);
#line 41 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayNameFor(model => model.Armor.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1192, 43, false);
#line 44 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
       Write(Html.DisplayFor(model => model.Armor.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 97, true);
            WriteLiteral(" <span style=\"font-family:Georgia;color:darkgoldenrod\">₡</span>\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1332, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c250f6d65b940d38b92c681d50fafd4", async() => {
                BeginContext(1352, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1362, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d40901a729da4e43abf0a0947b629d5a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 49 "C:\Users\Lubomir\Desktop\RobotArena-master\RobotArena\Areas\Admin\Pages\Armor\DeleteArmor.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Armor.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1404, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1488, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0612b2f66eea4faf86c356a8a4e89a59", async() => {
                    BeginContext(1514, 12, true);
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
                BeginContext(1530, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1543, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeleteArmorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeleteArmorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DeleteArmorModel>)PageContext?.ViewData;
        public DeleteArmorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
