namespace PartyRaidR.Shared.Models
{
    public class Place : IDbEntity<Place>
    {
        public Place()
        {
            Id = Guid.Empty.ToString();
            Name = string.Empty;
            Address = string.Empty;
            CityId = string.Empty;
            PlaceCategoryId = string.Empty;
            GpsLattitude = string.Empty;
            GpsLongitude = string.Empty;
            Description = string.Empty;
        }

        public Place(Guid id, string name, string address, string cityId, string placeCategoryId, string gpsLattitude, string gpsLongitude, string description)
        {
            Id = id.ToString();
            Name = name;
            Address = address;
            CityId = cityId;
            PlaceCategoryId = placeCategoryId;
            GpsLattitude = gpsLattitude;
            GpsLongitude = gpsLongitude;
            Description = description;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CityId { get; set; }
        public string PlaceCategoryId { get; set; }
        public string GpsLattitude { get; set; }
        public string GpsLongitude { get; set; }
        public string Description { get; set; }
    }
}
