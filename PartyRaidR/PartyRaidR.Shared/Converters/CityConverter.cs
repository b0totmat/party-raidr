using PartyRaidR.Shared.Dtos;

namespace PartyRaidR.Shared.Converters
{
    public static class CityConverter
    {
        public static CityDto ConvertToCityDto(this CityDto city) =>
            new CityDto()
            {
                Id = city.Id,
                Name = city.Name,
                ZipCode = city.ZipCode,
                County = city.County,
                Country = city.Country
            };

        public static CityDto ConvertToCity(this CityDto cityDto) =>
            new CityDto()
            {
                Id = cityDto.Id,
                Name = cityDto.Name,
                ZipCode = cityDto.ZipCode,
                County = cityDto.County,
                Country = cityDto.Country
            };
    }
}
