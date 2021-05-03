﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metrics_Agent.Controllers
{
    [Route("api/cpu")]
    [ApiController]
    public class CpuMetricsController : ControllerBase
    {
        public class CpuMetricsController : ControllerBase
        {
            [HttpGet()]
            public IActionResult GetMetrics()
            {
                return Ok();
            }
        }
    }
}
