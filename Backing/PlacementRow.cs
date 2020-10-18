using System.Linq;
using CardViewer.Model;
using Microsoft.AspNetCore.Components;

namespace CardViewer.Pages
{
    public partial class PlacementRow : ComponentBase
    {
        [Parameter]
        public Round Round { get; set; }

        public int GetPosition(Player player) {
            var orderedScores = Round.Scores.OrderBy(x=>x.Scores.Sum()).ToList();

            for(int i=0;i<orderedScores.Count;i++) {
                if(orderedScores[i].Player.Equals(player)) {
                    return i+1;
                }
            }

            return -1;
        }
    }
}