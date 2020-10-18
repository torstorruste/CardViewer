using System.Collections.Generic;
using System.Threading.Tasks;
using CardViewer.Model;

namespace CardViewer.Service
{
    public interface IPlayerService
    {
        Task<List<Player>> GetPlayers();
    }
}