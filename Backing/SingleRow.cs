using CardViewer.Model;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class SingleRow : ComponentBase
    {
        [Parameter]
        public Round Round { get; set; }

        [Parameter]
        public string RoundName { get; set; }

        [Parameter]
        public int RoundNumber { get; set; }

        public int GetScore(Score score, int roundNumber) {
            return score.Scores[roundNumber-1];
        }
    }
}