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
            (new ScrumParticipant() { Name = "Mo" }),
            (new ScrumParticipant() { Name = "Max" }),
            (new ScrumParticipant() { Name = "Yuliya" }),
            (new ScrumParticipant() { Name = "Markus" }),
            (new ScrumParticipant() { Name = "Aylin" }),
            (new ScrumParticipant() { Name = "Sina" })
        };

        public ScrumParticipant CreateOrUpdate(ScrumParticipant scrumParticipant)
        {
            if (scrumParticipant == null)
                throw new ArgumentNullException(nameof(scrumParticipant));

            try
            {
                AppDatabase.Database.Insert(scrumParticipant);
            }
            catch (Exception ex)
            {
                // TODO: implement logging
            }
            return scrumParticipant;
        }

        public bool Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id));

            var result = false;
            try
            {
                result = AppDatabase.Database.Delete(id) >= 0;
            }
            catch (Exception ex)
            {
                // TODO: implement logging
            }
            return result;
        }

        public List<ScrumParticipant> GetPossibleScrumParticipants()
        {
            if (AppDatabase.Database?.Table<ScrumParticipant>()?.Count() <= 0)
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