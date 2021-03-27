using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrumRandomizerApp.Scrum
{
    public class ScrumParticipant
    {
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        [NotMapped]
        public bool IsDone { get; set; }
    }
}