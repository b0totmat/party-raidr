namespace PartyRaidR.Shared.Models
{
    public class Application : IDbEntity<Application>
    {
        public Application()
        {
            Id = Guid.Empty.ToString();
            UserId = string.Empty;
            EventId = string.Empty;
            TimeOfApplication = DateTime.Now;
            StatusId = string.Empty;
        }

        public Application(Guid id, string userId, string eventId, DateTime timeOfApplication, string statusId)
        {
            Id = Guid.Empty.ToString();
            UserId = userId;
            EventId = eventId;
            TimeOfApplication = timeOfApplication;
            StatusId = statusId;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string EventId { get; set; }
        public DateTime TimeOfApplication { get; set; }
        public string StatusId { get; set; }
    }
}
