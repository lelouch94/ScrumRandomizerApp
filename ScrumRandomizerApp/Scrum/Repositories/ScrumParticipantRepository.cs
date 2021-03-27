using ScrumRandomizerApp.Persistency;
using ScrumRandomizerApp.Scrum.Interfaces;
using System;
using System.Collections.Generic;

namespace ScrumRandomizerApp.Scrum.Repositories
{
    public class ScrumParticipantRepository : IScrumParticipantRepository
    {
        private List<ScrumParticipant> DefaultScrumParticipants = new List<ScrumParticipant>()
        {
            (new ScrumParticipant() { Name = "Ana" }),
            (new ScrumParticipant() { Name = "Dana" }),
            (new ScrumParticipant() { Name = "David M." }),
            (new ScrumParticipant() { Name = "David W." }),
            (new ScrumParticipant() { Name = "Janet" }),
            (new ScrumParticipant() { Name = "Jens" }),
            (new ScrumParticipant() { Name = "Mario" }),
            (new ScrumParticipant() { Name = "Mo" })
        };

        public ScrumParticipant CreateOrUpdate(ScrumParticipant scrumParticipant)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ScrumParticipant> GetScrumParticipants()
        {
            if (AppDatabase.Database?.Table<ScrumParticipant>() == null)
                SeedDatabase();

            return AppDatabase.Database?.Table<ScrumParticipant>()?.ToList()
                ?? DefaultScrumParticipants;
        }

        private void SeedDatabase()
        {
            try
            {
                AppDatabase.Database?.InsertAll(DefaultScrumParticipants);
            }
            catch (Exception ex)
            {
                // TODO: implement logging
            }
        }
    }
}