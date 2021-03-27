using ScrumRandomizerApp.Persistency;
using ScrumRandomizerApp.Scrum.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Scrum.Repositories
{
    public class ScrumParticipantRepository : IScrumParticipantRepository
    {
        public Task<ScrumParticipant> CreateOrUpdate(ScrumParticipant scrumParticipant)
        {
            throw new System.NotImplementedException();

        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ScrumParticipant>> GetScrumParticipants()
        {
            throw new System.NotImplementedException();
        }
    }
}