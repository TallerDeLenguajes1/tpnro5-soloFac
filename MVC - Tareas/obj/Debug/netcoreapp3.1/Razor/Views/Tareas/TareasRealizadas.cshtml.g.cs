#pragma checksum "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6404622b358f8ac6c45a6805d61498e916b5f837"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tareas_TareasRealizadas), @"mvc.1.0.view", @"/Views/Tareas/TareasRealizadas.cshtml")]
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
#line 1 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\_ViewImports.cshtml"
using MVC___Tareas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\_ViewImports.cshtml"
using MVC___Tareas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"
using MVC___Tareas.Entidades;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6404622b358f8ac6c45a6805d61498e916b5f837", @"/Views/Tareas/TareasRealizadas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc428e5552ae28abc399ca44b0191aa42636afa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tareas_TareasRealizadas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MVC___Tareas.Entidades.Tarea>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Tareas Realizadas</h1>\r\n\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Descripcion</th>\r\n        <th>Duracion</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"
     foreach (Tarea tareax in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"
           Write(tareax.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"
           Write(tareax.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"
           Write(tareax.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Franco\Desktop\Repositorios\codebin2#\TPN5\MVC - Tareas\Views\Tareas\TareasRealizadas.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MVC___Tareas.Entidades.Tarea>> Html { get; private set; }
    }
}
#pragma warning restore 1591