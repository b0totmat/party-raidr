using Microsoft.EntityFrameworkCore;
using PartyRaidR.Backend.Repos.Base;
using PartyRaidR.Backend.Services.Base;
using PartyRaidR.Backend.Services.Promises;
using PartyRaidR.Shared.Assemblers;
using PartyRaidR.Shared.Dtos;
using PartyRaidR.Shared.Models;
using PartyRaidR.Shared.Models.Responses;
using System.Runtime.CompilerServices;

namespace PartyRaidR.Backend.Services
{
    public class PlaceService : BaseService<Place, PlaceDto>, IPlaceService
    {
        private IQueryable<Place> _query;

        public PlaceService(Assembler<Place, PlaceDto>? assembler, IRepositoryBase<Place>? repo) : base(assembler, repo)
        {
            _query = _repo.GetAllAsQueryable();
        }

        public async Task<ServiceResponse<IEnumerable<PlaceDto>>> FilterPlacesAsync(PlaceFilterDto filter)
        {
            try
            {
                if (filter.Name is not null)
                {
                    _query = FilterByName(filter.Name);
                }

                if (filter.CityId is not null)
                {
                    _query = FilterByCity(filter.CityId);
                }

                if (filter.Category is not null)
                {
                    _query = FilterByCategory(filter.Category);
                }

                if (filter.MaxDistanceKm is not null)
                {
                    _query = FilterByDistance(filter.Latitude, filter.Longitude, filter.MaxDistanceKm.Value);
                }

                List<Place> places = await _query.ToListAsync();
                List<PlaceDto> result = places.Select(_assembler.ConvertToDto).ToList();

                return new ServiceResponse<IEnumerable<PlaceDto>>
                {
                    Data = result,
                    Success = true,
                    Message = "Places filtered successfully",
                    StatusCode = 200
                };
            }
            catch(Exception e)
            {
                return new ServiceResponse<IEnumerable<PlaceDto>>
                {
                    Data = null,
                    Success = false,
                    Message = $"An error occurred while filtering places: {e.Message}",
                    StatusCode = 500
                };
            }
        }

        private static IQueryable<Place> FilterByName(string name)
        {
            
        }

        private static IQueryable<Place> FilterByCity(string cityId)
        {

        }

        private static IQueryable<Place> FilterByCategory(PlaceCategory? category)
        {
            
        }

        private static IQueryable<Place> FilterByDistance(double latitude, double longitude, double maxDistance)
        {

        }
    }
}
