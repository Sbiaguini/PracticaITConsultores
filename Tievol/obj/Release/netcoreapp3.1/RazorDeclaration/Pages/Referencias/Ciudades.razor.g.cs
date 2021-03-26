// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tievol.Pages.Referencias
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Ciudades")]
    public partial class Ciudades : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Ciudades.razor"
       
    //
    public List<Ciudad> LstCiudades { get; set; }
    public List<Region> LstRegiones { get; set; }

    //
    public string Accion { get; set; }
    public Ciudad SelectedCiudad { get; set; }

    //
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }

    public bool ShowWindow { get; set; } = false;

    // Referencias de tipo
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;

    //
    protected override async Task OnInitializedAsync()
    {
        LstCiudades = await srvCiudades.GetCiudades();
        LstRegiones= await srvRegiones.GetRegiones();
    }
    //
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;
        StateHasChanged();
        
    }
    //
    private void OnClick(string cAccion, Ciudad ciudad)
    {
        ShowWindow = true;
        Accion = cAccion;
        SelectedCiudad = ciudad;

        if (cAccion == "Add")
        {   //
            SelectedCiudad = new Ciudad()
            {
                ID_Ciudad = 0,
                N_Ciudad = string.Empty,
                Region = new Region()
                {
                    ID_Region = 0,
                    N_Region = string.Empty
                }

            };

            TituloWindow = "Agregar Ciudad";
            TituloButton = "Agregar";
            IconButton = "add";
        }
        else
        {   //
            SelectedCiudad = ciudad;

            //
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Ciudad";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Ciudad";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }

       StateHasChanged();
     
    }
    //
    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstCiudades.Exists(e => e.N_Ciudad == SelectedCiudad.N_Ciudad))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvCiudades.CreateAsync(SelectedCiudad);
            if (response.IsSuccess)
            {
                LstCiudades.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")
        {

            var response = await srvCiudades.UpdateAsync(SelectedCiudad);
            if (response.IsSuccess)
            {
                LstCiudades.Add(response.Result);
                var posicion = LstCiudades.FindIndex(e => e.ID_Ciudad == SelectedCiudad.ID_Ciudad);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstCiudades[posicion] = SelectedCiudad;
                    //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
                }
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Del")
        {
            var response = await srvCiudades.DeleteAsync(SelectedCiudad);
            if (response.IsSuccess)
            {
                LstCiudades = await srvCiudades.GetCiudades();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        //
        LstCiudades = await srvCiudades.GetCiudades();

        StateHasChanged();
      
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RegionesServices srvRegiones { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CiudadesServices srvCiudades { get; set; }
    }
}
#pragma warning restore 1591
