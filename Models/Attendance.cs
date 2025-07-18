namespace ChoirManager.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public required Student Student { get; set; }

        public int? MassId { get; set; }
        public Mass? Mass { get; set; }

        public int? RehearsalId { get; set; }
        public Rehearsal? Rehearsal { get; set; }

        public bool WasPresent { get; set; }
    }
}
