using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.EntityResolver.Database.Models;
using PlatformService.EntityResolver.DTO;
using PlatformService.ServiceResolver.Repository;

namespace PlatformServiceAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlatformController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPlatformServiceRepository _platformServiceRepository;
        public PlatformController(IMapper mapper,IPlatformServiceRepository platformServiceRepository)
        {
            _mapper = mapper;
            _platformServiceRepository = platformServiceRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PlatformReadDTO>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<PlatformReadDTO>>> GetAllPlatforms()
        {
            try
            {
                var Platforms = await _platformServiceRepository.GetAllPlatforms();
                if (ModelState == null)
                {
                    return BadRequest();
                }
                return Ok(_mapper.Map<List<PlatformReadDTO>>(Platforms));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
