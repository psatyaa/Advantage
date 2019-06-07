using System.Collections.Generic;
using System.Threading.Tasks;
using Advantage.Domain.Model;
using Advantage.Domain.Resource.Response;
using Advantage.Service.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Advantage.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _appService;
        private readonly IMapper _mapper;
        public ApplicationController(IApplicationService appService, IMapper mapper)
        {
            _appService = appService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ApplicationResponse>> Get()
        {
            var applications = await _appService.ListAsync();
            var resource = _mapper.Map<IEnumerable<Application>, IEnumerable<ApplicationResponse>>(applications);
            return resource;
        }
    }
}