using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardViewer.Model;
using CardViewer.Service;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class ViewPlayers : ComponentBase
    {
        [Inject]
        public IPlayerService PlayerService { get; set; }

        private List<Player> Players;

        protected override async Task OnInitializedAsync() {
            try {
                Players = await PlayerService.GetPlayers();
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}