using CardViewer.Model;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class ViewRound : ComponentBase
    {
        [Parameter]
        public Round Round { get; set; }
    }
}