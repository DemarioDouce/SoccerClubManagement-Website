#pragma checksum "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f961556adb9cbe6a69eba712578c45f726394136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_ManagePlayers), @"mvc.1.0.view", @"/Views/Players/ManagePlayers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Players/ManagePlayers.cshtml", typeof(AspNetCore.Views_Players_ManagePlayers))]
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
#line 1 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Demario_D_301021637.Models;

#line default
#line hidden
#line 2 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Demario_D_301021637.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f961556adb9cbe6a69eba712578c45f726394136", @"/Views/Players/ManagePlayers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7989228140c7d5d789c555437cb387b971163615", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_ManagePlayers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Players>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Players", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReassignPlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddPlayers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
  
    Layout = "_DefaultLayout";
    ViewBag.Title = "ManagePlayers";

#line default
#line hidden
            BeginContext(106, 322, true);
            WriteLiteral(@"
<title>Manage Players - Dream League Soccer</title>


<h2 class=""cover-heading"">MANAGE PLAYERS</h2>

<table class=""table table-dark"" border=""1"">
    <thead>
        <tr>
            <th scope=""col"">Player Name</th>
            <th scope=""col"">Player Club</th>
            <th scope=""col"">Player Position</th>
");
            EndContext();
#line 18 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
             if (SignInManager.IsSignedIn(User))
            {
                

#line default
#line hidden
#line 20 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                 if (User.Identity.Name == "Admin")
                {

#line default
#line hidden
            BeginContext(565, 50, true);
            WriteLiteral("        <th scope=\"col\" colspan=\"2\">Actions</th>\r\n");
            EndContext();
#line 23 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                }

#line default
#line hidden
#line 23 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                 
             }

#line default
#line hidden
            BeginContext(650, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
         foreach (Players p in Model)
        {

#line default
#line hidden
            BeginContext(742, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(781, 12, false);
#line 31 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
               Write(p.PlayerName);

#line default
#line hidden
            EndContext();
            BeginContext(793, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(821, 12, false);
#line 32 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
               Write(p.PlayerClub);

#line default
#line hidden
            EndContext();
            BeginContext(833, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(861, 16, false);
#line 33 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
               Write(p.PlayerPosition);

#line default
#line hidden
            EndContext();
            BeginContext(877, 9, true);
            WriteLiteral("</td>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    

#line default
#line hidden
#line 37 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                     if (User.Identity.Name == "Admin")
                    {

#line default
#line hidden
            BeginContext(1039, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1089, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f961556adb9cbe6a69eba712578c45f7263941369561", async() => {
                BeginContext(1095, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1125, 228, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f961556adb9cbe6a69eba712578c45f7263941369974", async() => {
                    BeginContext(1277, 72, true);
                    WriteLiteral("\r\n                                REASSIGN\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PlayerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 42 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                                       WriteLiteral(p.PlayerID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PlayerId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PlayerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PlayerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1353, 66, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"PlayerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1419, "\"", 1438, 1);
#line 45 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
WriteAttributeValue("", 1427, p.PlayerID, 1427, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1439, 29, true);
                WriteLiteral(" />\r\n                        ");
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
            BeginContext(1475, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1554, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f961556adb9cbe6a69eba712578c45f72639413614503", async() => {
                BeginContext(1625, 66, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"PlayerId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1691, "\"", 1710, 1);
#line 50 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
WriteAttributeValue("", 1699, p.PlayerID, 1699, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1711, 194, true);
                WriteLiteral(" />\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                DEREGISTER\r\n                            </button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1912, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 56 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                        }

#line default
#line hidden
#line 56 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(1991, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 59 "C:\Users\demar\Desktop\New folder\Demario_D_301021637\Views\Players\ManagePlayers.cshtml"
        }

#line default
#line hidden
            BeginContext(2021, 30, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2051, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f961556adb9cbe6a69eba712578c45f72639413618034", async() => {
                BeginContext(2127, 3, true);
                WriteLiteral("ADD");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Players>> Html { get; private set; }
    }
}
#pragma warning restore 1591
