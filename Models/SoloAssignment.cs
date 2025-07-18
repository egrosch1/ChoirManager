namespace ChoirManager.Models
{
        public class SoloAssignment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public required Student Student { get; set; }
        public int MassId { get; set; }
        public required Mass Mass { get; set; }
        public required string SoloTitle { get; set; }
        public bool WasPerformed { get; set; }
    }
}