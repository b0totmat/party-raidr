namespace PartyRaidR.Shared.Models
{
    public class Event : IDbEntity<Event>
    {
        public Event()
        {
            Id = Guid.Empty.ToString();
            Title = string.Empty;
            Description = string.Empty;
            StartingDate = DateTime.Now;
            EndingDate = DateTime.Now;
            PlaceId = string.Empty;
            EventCategoryId = string.Empty;
            AuthorId = string.Empty;
            Room = 0;
            TicketPrice = 0;
            DateCreated = DateTime.Now;
        }

        public Event(Guid id, string title, string description, DateTime startingDate, DateTime endingDate, string placeId, string eventCategoryId, string authorId, int room, decimal ticketPrice, DateTime dateCreated)
        {
            Id = id.ToString();
            Title = title;
            Description = description;
            StartingDate = startingDate;
            EndingDate = endingDate;
            PlaceId = placeId;
            EventCategoryId = eventCategoryId;
            AuthorId = authorId;
            Room = room;
            TicketPrice = ticketPrice;
            DateCreated = dateCreated;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string PlaceId { get; set; }
        public string EventCategoryId { get; set; }
        public string AuthorId { get; set; }
        public int Room { get; set; }
        public decimal TicketPrice { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
