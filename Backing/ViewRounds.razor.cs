using System;
using System.Collections.Generic;
using System.Linq;
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

        private List<Round> AllRounds;
        private List<Round> Rounds;

        [Parameter]
        public int? PlayerId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                AllRounds = await RoundService.GetRounds();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected override void OnParametersSet()
        {
            if(PlayerId==null) {
                Rounds = AllRounds;
            } else {
                Rounds = AllRounds
                            .Where(r=>r.Scores.Any(s=>s.Player.Id==PlayerId))
                            .OrderBy(r=>r.Scores.Where(s=>s.Player.Id==PlayerId).SelectMany(s=>s.Scores).Sum())
                            .ToList();
            }
        }
    }
}