using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardViewer.Model;
using CardViewer.Service;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class ViewRounds : ComponentBase
    {
        [Inject]
        public IRoundService RoundService { get; set; }

        private List<Round> Rounds;

        protected override async Task OnInitializedAsync() {
            try {
            Rounds = await RoundService.GetRounds();
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}