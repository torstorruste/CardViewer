using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardViewer.Model;
using CardViewer.Service;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class ViewStatistics : ComponentBase
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

        protected override void OnParametersSet() {
            Console.WriteLine($"OnParametersSet, PlayerId={PlayerId}");
            if(PlayerId!=null) {
                Rounds = AllRounds.Where(r=>r.Scores.Any(s=>s.Player.Id==PlayerId)).ToList();
            } else {
                Rounds = AllRounds;
            }
        }

        public IEnumerable<IGrouping<int, Round>> GroupRoundsByYear()
        {
            return Rounds.GroupBy(x => x.Date.Year).ToList().OrderBy(x => x.Key);
        }

        public IEnumerable<IGrouping<int, Round>> GroupRoundsByMonth()
        {
            return Rounds.GroupBy(x => x.Date.Month).ToList().OrderBy(x => x.Key);
        }

        public IEnumerable<IGrouping<System.DayOfWeek, Round>> GroupByDayOfWeek()
        {
            return Rounds.GroupBy(x => x.Date.DayOfWeek).ToList().OrderBy(x => x.Key);
        }

        public IEnumerable<IGrouping<int, Round>> GroupByNumPlayers()
        {
            return Rounds.GroupBy(x => x.Scores.Count()).ToList().OrderBy(x => x.Key);
        }

        public IEnumerable<IGrouping<Player, Score>> GroupByPlayer()
        {
            return Rounds.SelectMany(x => x.Scores).GroupBy(x => x.Player).OrderBy(x => x.Key.Name);
        }
    }
}