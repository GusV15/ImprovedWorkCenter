#pragma checksum "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbcac3bc61266d78a2e1f42250a38888b91f92c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Socio_Delete), @"mvc.1.0.view", @"/Views/Socio/Delete.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\_ViewImports.cshtml"
using ImprovedWorkCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\_ViewImports.cshtml"
using ImprovedWorkCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbcac3bc61266d78a2e1f42250a38888b91f92c8", @"/Views/Socio/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756fa122fea88f22c8ba312cd75d7958e2f80fbc", @"/Views/_ViewImports.cshtml")]
    public class Views_Socio_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImprovedWorkCenter.Models.Socio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Socio</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Domicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Domicilio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contrasenia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contrasenia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EsDeudor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EsDeudor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInscripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaInscripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MetodoDePago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MetodoDePago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbcac3bc61266d78a2e1f42250a38888b91f92c812579", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbcac3bc61266d78a2e1f42250a38888b91f92c812846", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\Users\User\Desktop\ORT - Analista en Sistemas\1erAño_2erCuatrimestre\Principio_de_Nuevas_Tecnologias\Proyecto_grupal_NT1\ImprovedWorkCenter\Views\Socio\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SocioId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbcac3bc61266d78a2e1f42250a38888b91f92c814727", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImprovedWorkCenter.Models.Socio> Html { get; private set; }
    }
}
#pragma warning restore 1591
