// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tievol.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\_Imports.razor"
using Tievol.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(TelerikLayout))]
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Shared\MainLayout.razor"
       

    public TelerikDrawer<DrawerItem> DrawerOptions { get; set; }

    public DrawerItem selectedItem { get; set; }

    public bool Expanded { get; set; } = true;

    public IEnumerable<DrawerItem> Data { get; set; } =
        new List<DrawerItem>
        {
            //new DrawerItem { Text = "Rubros",  Icon = IconName.Dollar,  Url = "Referencias/Rubros"},
            //new DrawerItem { Text = "Sub_rubros",  Icon = IconName.Dollar,  Url = "Referencias/Sub_rubros"},
            //new DrawerItem { Text = "Bodegas",  Icon = IconName.Inbox,  Url = "Referencias/Bodegas"},
            new DrawerItem { Text = "Ciudades",  Icon="home",  Url = "Referencias/Ciudades"},
            //new DrawerItem { Text = "Comunas",   Icon = IconName.Globe,            Url = "Referencias/Comunas" },
            new DrawerItem { Text = "Estados",  Icon = "check-outline",  Url = "Referencias/Estados"},
            new DrawerItem { Text = "Proveedores",  Icon = IconName.TellAFriend,  Url = "Referencias/ClienteProveedor"},
            //new DrawerItem { Text = "Familias",  Icon = IconName.ModuleManager,  Url = "Referencias/Familias"},
            new DrawerItem { Text = "Marcas",  Icon = "barcode-outline",  Url = "Referencias/Marca"},
            new DrawerItem { Text = "Productos",  Icon = "cart",  Url = "Referencias/Producto"},
            //new DrawerItem { Text = "Perfiles",  Icon = IconName.User,  Url = "Referencias/Perfiles"},
            new DrawerItem { Text = "Regiones",  Icon = IconName.MarkerPinTarget,  Url = "Referencias/Regiones"},
            //new DrawerItem { Text = "Sub_Familias",  Icon = IconName.MarkerPinTarget,  Url = "Referencias/Subfamilia"},
            new DrawerItem { Text = "Sucursales",  Icon = IconName.Pin,  Url = "Referencias/Sucursales"},
            new DrawerItem { Text = "Tipos de Documentos",  Icon = IconName.File,  Url = "Referencias/Tipo_documentos"},
            new DrawerItem { Text = "Tipos de Proveedores",  Icon = IconName.Share,  Url = "Referencias/Tipo_ClienteProveedor"},
            new DrawerItem { Text = "Tipos de Descuento",  Icon = IconName.Percent,  Url = "Referencias/Tipo_descuentos"},
            //new DrawerItem { Text = "Tipos de Empresas",  Icon = IconName.MarkerPinTarget,  Url = "Referencias/Tipo_Empresa"},
            new DrawerItem { Text = "Tipos de Inventario",  Icon = IconName.DeliciousBox,  Url = "Referencias/Tipo_Inventario"},
            //new DrawerItem { Text = "Tipos de Materiales",  Icon = IconName.MarkerPinTarget,  Url = "Referencias/Tipo_Material"},
            new DrawerItem { Text = "Tipos de Pago",  Icon = IconName.Dollar,  Url = "Referencias/Tipo_Pago"},
            //new DrawerItem { Text = "Tipos de Productos",  Icon = IconName.Cart,  Url = "Referencias/Tipo_Productos"},
           new DrawerItem { Text = "Toma de Inventarios",  Icon = "track-changes-enable",  Url = "Referencias/Toma_Inventario"},
            //new DrawerItem { Text = "Tipos de Productos",  Icon = IconName.Cart,  Url = "Referencias/Toma_Inventario"},
            new DrawerItem { Text = "Ubicaciones",  Icon = IconName.Globe,  Url = "Referencias/Ubicaciones"},
                //new DrawerItem { Text = "Unidades",  Icon = IconName.Percent,  Url = "Referencias/Unidades"},
            };

    public class DrawerItem
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public bool IsSeparator { get; set; }
    }

    private void ToggleNavMenu()
    {
        Expanded = !Expanded;
    }

    private string NavMenuCssClass => Expanded ? "collapse" : null;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
