#pragma checksum "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2752f384ca8f3fd4d22b3980000c955e32dfdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore;

#line default
#line hidden
#line 2 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\_ViewImports.cshtml"
using ASPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2752f384ca8f3fd4d22b3980000c955e32dfdc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4ada19fa78fcc822c8d676fe3956dba96f0df0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlumnoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pagina de Alumnos";

#line default
#line hidden
            BeginContext(76, 633, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bienvenido</h1>
    <p>learn about <a href=""https://docs.microsoft.com/aspnet/core"">buildig Webs apss with ASP.NET Core</a></p>
</div>



<div class=""table-condensed"">
   <table cellpadding=""0"" cellspacing=""0"" class=""table"">
       <thead>
           <tr>
               <th scope=""col"" > Numero de Control</th>
               <th scope=""col"" > Nombre</th>
               <th scope=""col"" > Apellido Paterno</th>
               <th scope=""col"" > Apellido Materno</th>
               <th scope=""col"" > Codigo de Especialidad</th>
           </tr>
       </thead>
");
            EndContext();
#line 25 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
        foreach (AlumnoModel alumno in (AlumnoModel[])ViewBag.alumnos)
       {

#line default
#line hidden
            BeginContext(791, 36, true);
            WriteLiteral("           <tr>\r\n               <td>");
            EndContext();
            BeginContext(828, 14, false);
#line 28 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
              Write(alumno.NumCont);

#line default
#line hidden
            EndContext();
            BeginContext(842, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(869, 13, false);
#line 29 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
              Write(alumno.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(882, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(909, 23, false);
#line 30 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
              Write(alumno.Apellido_paterno);

#line default
#line hidden
            EndContext();
            BeginContext(932, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(959, 23, false);
#line 31 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
              Write(alumno.Apellido_paterno);

#line default
#line hidden
            EndContext();
            BeginContext(982, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(1009, 26, false);
#line 32 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
              Write(alumno.Codigo_especialidad);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 25, true);
            WriteLiteral("</td>\r\n           </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Gabriela\source\repos\ASPCore\ASPCore\Views\Home\Index.cshtml"
       }

#line default
#line hidden
            BeginContext(1070, 21, true);
            WriteLiteral("   </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlumnoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
