using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Scrum.Interfaces
{
    public interface IScrumParticipantRepository
    {
        List<ScrumParticipant> GetScrumParticipants();
        ScrumParticipant CreateOrUpdate(ScrumParticipant scrumParticipant);
        bool Delete(int id);
    }
}