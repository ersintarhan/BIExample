namespace BIExample.Controllers.Requests
{
    public class EventRequest
    {
        public int? SportId { get; set; }
        public int? CategoryId { get; set; }
        public int? TournamentId { get; set; }
        public long? StartDate { get; set; }
        public long? EndDate { get; set; }
        
    }
}
