using Commitizen.Core.Models;
using Commitizen.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commitizen.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChangeTypeController : ControllerBase
    {

        private readonly ILogger<ChangeTypeController> _logger;
        private readonly IChangeTypeService _changeTypeService;

        public ChangeTypeController(ILogger<ChangeTypeController> logger, IChangeTypeService changeTypeService)
        {
            _logger = logger;
            _changeTypeService = changeTypeService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ChangeType>>> GetAllChangeTypes()
        {
            var changeTypes = await _changeTypeService.GetAllActiveAsync();
            return Ok(changeTypes);
        }

    }
}
