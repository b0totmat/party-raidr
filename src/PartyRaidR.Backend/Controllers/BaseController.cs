using Microsoft.AspNetCore.Mvc;
using PartyRaidR.Backend.Services.Base;
using PartyRaidR.Shared.Models;

namespace PartyRaidR.Backend.Controllers
{
    public abstract class BaseController<TModel, TDto> : ControllerBase
        where TModel : class, IDbEntity<TModel>, new()
        where TDto : class
    {
        protected readonly IBaseService<TModel, TDto> _service;

        protected BaseController(IBaseService<TModel, TDto> service)
        {
            _service = service;
        }
    }
}
