using System.Linq;
using CardViewer.Model;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class SumRow : ComponentBase
    {
        [Parameter]
        public Round Round { get; set; }

        public int GetScore(Score score) {
            return score.Scores.Sum();
        }
    }
}