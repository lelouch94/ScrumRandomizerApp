using ScrumRandomizerApp.Scrum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScrumRandomizerApp.Randomization
{
    public class ScrumRandomizerService
    {
        public List<ScrumParticipant> RandomizeScrumParticipants(List<ScrumParticipant> scrumParticipants)
        {
            Random random = new Random();
            return scrumParticipants.OrderBy(p => random.Next()).ToList();
        }
    }
}