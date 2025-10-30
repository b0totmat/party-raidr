namespace PartyRaidR.Shared.Models
{
    public class Notification : IDbEntity<Notification>
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string EventId { get; set; }
        public string NotificationTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsRead { get; set; }
    }
}
