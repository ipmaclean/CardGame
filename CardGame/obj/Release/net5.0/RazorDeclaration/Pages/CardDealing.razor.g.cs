// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CardGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using CardGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\_Imports.razor"
using CardGame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dealing")]
    public partial class CardDealing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\iainp\OneDrive\Github\CardGame\CardGame\Pages\CardDealing.razor"
       

    private Deck deck { get; set; }
    private Hand hand { get; set; } = new Hand();

    protected override void OnInitialized()
    {
        deck = new Deck(true);
    }

    private void DealCard(bool faceUp)
    {
        var dealtCard = deck.Deal(faceUp);

        hand.Cards.Add(dealtCard);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
