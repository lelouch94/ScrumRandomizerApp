using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Scrum.Interfaces
{
    public interface IScrumParticipantRepository
    {
        Task<List<ScrumParticipant>> GetScrumParticipants();
        Task<ScrumParticipant> CreateOrUpdate(ScrumParticipant scrumParticipant);
        Task<bool> Delete(int id);
    }
}