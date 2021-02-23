using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_stage_management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API : ControllerBase
    {
        private readonly ILogger<API> _logger;

        public API(ILogger<API> logger)
        {
            _logger = logger;
            _logger.LogInformation("打的");
            _logger.LogError("错误");
        }
    }
}
