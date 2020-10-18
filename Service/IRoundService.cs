using System.Collections.Generic;
using System.Threading.Tasks;
using CardViewer.Model;

namespace CardViewer.Service
{
    public interface IRoundService
    {
        Task<List<Round>> GetRounds();
    }
}