using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Scrum.Interfaces
{
    public interface IScrumParticipantRepository
    {
        List<ScrumParticipant> GetPossibleScrumParticipants();
        ScrumParticipant CreateOrUpdate(ScrumParticipant scrumParticipant);
        bool Delete(int id);
    }
}