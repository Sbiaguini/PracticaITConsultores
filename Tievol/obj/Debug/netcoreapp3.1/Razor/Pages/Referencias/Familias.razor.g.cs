#pragma checksum "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e464b3490433c66cba30e4acb3540f5e00f4e58b"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Referencias/Familias")]
    public partial class Familias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Tievol.Pages.Referencias.Familias.TypeInference.CreateTelerikGrid_0(__builder, 0, 1, 
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                   LstFamilias

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 6 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                          GridEditMode.Popup

#line default
#line hidden
#nullable disable
            , 3, "100%", 4, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                      true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                    true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                  10

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 7 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 8 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                            GridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(11);
                __builder2.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                       () => OnClick("Add", null) 

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "Icon", "add");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(15, "Agregar");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n    ");
            }
            , 17, (__builder2) => {
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(19);
                __builder2.AddAttribute(20, "Width", "70px");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, "\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(23);
                    __builder3.AddAttribute(24, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                          (args) => OnClick("Upd", args.Item as Familia)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(25, "Icon", "edit");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(28);
                __builder2.AddAttribute(29, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                           nameof(Familia.ID_Familia)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "Title", "Identificador");
                __builder2.AddAttribute(31, "Width", "150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(33);
                __builder2.AddAttribute(34, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                           nameof(Familia.N_Familia)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Title", "Descripción");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(37);
                __builder2.AddAttribute(38, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                           nameof(Familia.Estado)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Title", "Estado");
                __builder2.AddAttribute(40, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(42, "\n                ");
                    __builder3.AddContent(43, 
#nullable restore
#line 22 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                   (context as Familia).Estado.N_Estado

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(44, "\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\n\n\n        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridCommandColumn>(46);
                __builder2.AddAttribute(47, "Width", "70px");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\n            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.GridCommandButton>(50);
                    __builder3.AddAttribute(51, "Command", "Delete");
                    __builder3.AddAttribute(52, "Icon", "delete");
                    __builder3.AddAttribute(53, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Telerik.Blazor.Components.GridCommandEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridCommandEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                         (args) => OnClick("Del", args.Item as Familia)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\n    ");
            }
            );
            __builder.AddMarkupContent(56, "\n\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikWindow>(57);
            __builder.AddAttribute(58, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                        ShowWindow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "Modal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "Class", "c-Window");
            __builder.AddAttribute(61, "WindowContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(62, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(63);
                __builder2.AddAttribute(64, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 35 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                         SelectedFamilia

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 35 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                          OnSave

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\n            \n            ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "card");
                    __builder3.AddAttribute(70, "style", "width: 500px; height: 450px;");
                    __builder3.AddMarkupContent(71, "\n                ");
                    __builder3.OpenElement(72, "div");
                    __builder3.AddAttribute(73, "class", "card-header blue-gradient-rgba text-black");
                    __builder3.AddMarkupContent(74, "\n                    ");
                    __builder3.OpenElement(75, "h5");
                    __builder3.AddAttribute(76, "class", "card-title my-2");
                    __builder3.OpenElement(77, "strong");
                    __builder3.AddContent(78, 
#nullable restore
#line 39 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                         TituloWindow

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(79, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\n\n                ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "card-body text-muted");
                    __builder3.AddMarkupContent(83, "\n                    ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(84);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\n                    ");
                    __builder3.OpenElement(86, "div");
                    __builder3.AddAttribute(87, "class", "row my-1");
                    __builder3.AddMarkupContent(88, "\n                        ");
                    __builder3.OpenElement(89, "div");
                    __builder3.AddAttribute(90, "class", "col");
                    __builder3.AddMarkupContent(91, "\n                            \n                            ");
                    __builder3.AddMarkupContent(92, "<label class=\"k-label\">Identificador</label>\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Familias.TypeInference.CreateTelerikNumericTextBox_1(__builder3, 93, 94, "100%", 95, 
#nullable restore
#line 48 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                                                                               false

#line default
#line hidden
#nullable disable
                    , 96, 
#nullable restore
#line 48 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                SelectedFamilia.ID_Familia

#line default
#line hidden
#nullable disable
                    , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedFamilia.ID_Familia = __value, SelectedFamilia.ID_Familia)), 98, () => SelectedFamilia.ID_Familia, 99, (__value) => {
#nullable restore
#line 48 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                                                               IDInt = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.AddMarkupContent(100, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(101, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(102, "\n                    ");
                    __builder3.OpenElement(103, "div");
                    __builder3.AddAttribute(104, "class", "row mt-2");
                    __builder3.AddMarkupContent(105, "\n                        ");
                    __builder3.OpenElement(106, "div");
                    __builder3.AddAttribute(107, "class", "col");
                    __builder3.AddMarkupContent(108, "\n                            \n                            ");
                    __builder3.AddMarkupContent(109, "<label class=\"k-label\">Descripción</label>\n                            ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikTextBox>(110);
                    __builder3.AddAttribute(111, "Width", "100%");
                    __builder3.AddAttribute(112, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                         SelectedFamilia.N_Familia

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(113, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedFamilia.N_Familia = __value, SelectedFamilia.N_Familia))));
                    __builder3.AddAttribute(114, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SelectedFamilia.N_Familia));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Familias.TypeInference.CreateValidationMessage_2(__builder3, 116, 117, 
#nullable restore
#line 56 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                      () => SelectedFamilia.N_Familia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(118, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(120, "\n\n                    ");
                    __builder3.OpenElement(121, "div");
                    __builder3.AddAttribute(122, "class", "row mt-4");
                    __builder3.AddMarkupContent(123, "\n                        ");
                    __builder3.OpenElement(124, "div");
                    __builder3.AddAttribute(125, "class", "col");
                    __builder3.AddMarkupContent(126, "\n                            \n                            ");
                    __builder3.AddMarkupContent(127, "<label class=\"k-label\">Estado</label>\n                            ");
                    __Blazor.Tievol.Pages.Referencias.Familias.TypeInference.CreateTelerikComboBox_3(__builder3, 128, 129, 
#nullable restore
#line 64 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                    LstEstado

#line default
#line hidden
#nullable disable
                    , 130, "100%", 131, "N_Estado", 132, "ID_Estado", 133, "Seleccione un Estado...", 134, 
#nullable restore
#line 66 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                    , 135, 
#nullable restore
#line 66 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                    , 136, 
#nullable restore
#line 64 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                                            SelectedFamilia.Estado.ID_Estado

#line default
#line hidden
#nullable disable
                    , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedFamilia.Estado.ID_Estado = __value, SelectedFamilia.Estado.ID_Estado)), 138, () => SelectedFamilia.Estado.ID_Estado);
                    __builder3.AddMarkupContent(139, "\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(140, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(141, "\n\n                    ");
                    __builder3.OpenElement(142, "div");
                    __builder3.AddAttribute(143, "class", "form-row");
                    __builder3.AddMarkupContent(144, "\n                        ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(145);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(147, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(148, "\n                ");
                    __builder3.OpenElement(149, "div");
                    __builder3.AddAttribute(150, "class", "card-footer");
                    __builder3.AddMarkupContent(151, "\n                    ");
                    __builder3.OpenElement(152, "div");
                    __builder3.AddAttribute(153, "class", "form-row d-flex d-flex justify-content-between");
                    __builder3.AddMarkupContent(154, "\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(155);
                    __builder3.AddAttribute(156, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                              IconButton

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(157, "Class", "btn btn-outline-info btn-telerik");
                    __builder3.AddAttribute(158, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 79 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                    ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(159, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(160, "\n                            ");
                        __builder4.OpenElement(161, "strong");
                        __builder4.AddContent(162, 
#nullable restore
#line 80 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                     TituloButton

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(163, "\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(164, "\n\n                        ");
                    __builder3.OpenComponent<Telerik.Blazor.Components.TelerikButton>(165);
                    __builder3.AddAttribute(166, "Icon", "cancel");
                    __builder3.AddAttribute(167, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                               OnCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(168, "Class", "btn btn-outline-danger btn-telerik");
                    __builder3.AddAttribute(169, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Telerik.Blazor.ButtonType>(
#nullable restore
#line 85 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                                                    ButtonType.Button

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(171, "Cancelar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(172, "\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(173, "\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(174, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(175, "\n            \n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(176, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(177, "\n\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikNotification>(178);
            __builder.AddComponentReferenceCapture(179, (__value) => {
#nullable restore
#line 94 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
                            Notification = (Telerik.Blazor.Components.TelerikNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\MrBBlueSky\source\TievolPractica-dev_seba\Tievol\Pages\Referencias\Familias.razor"
       

    //
    public List<Familia> LstFamilias { get; set; }
    public List<Estado> LstEstado { get; set; }

    //
    public string Accion { get; set; }
    public Familia SelectedFamilia { get; set; }

    //
    public string TituloWindow { get; set; }
    public string TituloButton { get; set; }
    public string IconButton { get; set; }

    public bool ShowWindow { get; set; } = false;

    public TelerikNotification Notification { get; set; }

    // Referencias de tipo
    private Telerik.Blazor.Components.TelerikNumericTextBox<int> IDInt;

    //
    protected override async Task OnInitializedAsync()
    {
        LstFamilias = await srvFamilia.GetFamilias();
        LstEstado = await srvEstado.GetEstados();
    }
    //
    private void OnCancel(MouseEventArgs e)
    {
        ShowWindow = false;

    }
    //
    private void OnClick(string cAccion, Familia familia) // Problem de Excepción nula, interrupción de la aplicación. 
    {
        ShowWindow = true;
        Accion = cAccion;
        SelectedFamilia = familia;

        if (cAccion == "Add")
        {   //
            SelectedFamilia = new Familia()
            {
                ID_Familia = 0,
                N_Familia = string.Empty,
                Estado = new Estado()
                {
                    ID_Estado = 0,
                    N_Estado = string.Empty
                }

            };

            TituloWindow = "Agregar Familia";
            IconButton = "add";
        }
        else
        {   //
            SelectedFamilia = familia;

            //
            if (Accion == "Upd")
            {
                TituloWindow = "Actualizar Familia";
                TituloButton = "Guardar";
                IconButton = "save";

            }
            else
            {
                TituloWindow = "Eliminar Familia";
                TituloButton = "Eliminar";
                IconButton = "delete";

            }
        }

        StateHasChanged();
        Task.Delay(1000);
    }
    //
    private async Task OnSave()
    {
        ShowWindow = false;
        if (Accion == "Add")
        {
            if (LstFamilias.Exists(f => f.N_Familia == SelectedFamilia.N_Familia))
            {
                //toast.ShowWarning("La descripción ya se encuentra en la lista...", "ATENCION");
                return;
            }

            var response = await srvFamilia.CreateAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias.Add(response.Result);
                //toast.ShowSuccess("Los datos se almacenaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Upd")
        {

            var response = await srvFamilia.UpdateAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias.Add(response.Result);
                var posicion = LstFamilias.FindIndex(f => f.ID_Familia == SelectedFamilia.ID_Familia);
                if (posicion == -1)
                {
                    //toast.ShowError("Se produjo un error inesperado...", "ERROR");
                }
                else
                {
                    LstFamilias[posicion] = SelectedFamilia;
                    Notification.Show(new NotificationModel()
                    {
                        Text = "Los datos se almacenaron correctamente...",
                        ThemeColor = "primary",
                        ShowIcon = true
                    });
                }
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        if (Accion == "Del")
        {
            var response = await srvFamilia.DeleteAsync(SelectedFamilia);
            if (response.IsSuccess)
            {
                LstFamilias = await srvFamilia.GetFamilias();
                //toast.ShowSuccess("Los datos se eliminaron correctamente...", "ATENCION");
            }
            else
            {
                //toast.ShowError(response.Message, "ERROR");
            }
        }

        //
        LstFamilias = await srvFamilia.GetFamilias();



        StateHasChanged();
        await Task.Delay(1000);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EstadosServices srvEstado { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FamiliasServices srvFamilia { get; set; }
    }
}
namespace __Blazor.Tievol.Pages.Referencias.Familias
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Telerik.Blazor.GridEditMode __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Int32 __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::Telerik.Blazor.GridSelectionMode __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "EditMode", __arg1);
        __builder.AddAttribute(__seq2, "Height", __arg2);
        __builder.AddAttribute(__seq3, "Sortable", __arg3);
        __builder.AddAttribute(__seq4, "Pageable", __arg4);
        __builder.AddAttribute(__seq5, "PageSize", __arg5);
        __builder.AddAttribute(__seq6, "Resizable", __arg6);
        __builder.AddAttribute(__seq7, "SelectionMode", __arg7);
        __builder.AddAttribute(__seq8, "GridToolBar", __arg8);
        __builder.AddAttribute(__seq9, "GridColumns", __arg9);
        __builder.CloseComponent();
        }
        public static void CreateTelerikNumericTextBox_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg4, int __seq5, global::System.Action<global::Telerik.Blazor.Components.TelerikNumericTextBox<T>> __arg5)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikNumericTextBox<T>>(seq);
        __builder.AddAttribute(__seq0, "Width", __arg0);
        __builder.AddAttribute(__seq1, "Enabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddComponentReferenceCapture(__seq5, (__value) => { __arg5((global::Telerik.Blazor.Components.TelerikNumericTextBox<T>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateTelerikComboBox_3<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, TValue __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg8, int __seq9, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg9)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikComboBox<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Width", __arg1);
        __builder.AddAttribute(__seq2, "TextField", __arg2);
        __builder.AddAttribute(__seq3, "ValueField", __arg3);
        __builder.AddAttribute(__seq4, "Placeholder", __arg4);
        __builder.AddAttribute(__seq5, "ClearButton", __arg5);
        __builder.AddAttribute(__seq6, "Filterable", __arg6);
        __builder.AddAttribute(__seq7, "Value", __arg7);
        __builder.AddAttribute(__seq8, "ValueChanged", __arg8);
        __builder.AddAttribute(__seq9, "ValueExpression", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
