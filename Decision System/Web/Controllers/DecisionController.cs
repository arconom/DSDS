﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecisionSystem.Data;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DecisionSystem.Repository;
using Core.Interfaces;
using Core.Domains;

namespace DecisionSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DecisionController : BaseController<Decision, DecisionDto>
    {

        public DecisionController(ILogger<DecisionController> logger, IRepository<Decision> repository, IDomain<Decision, DecisionDto> domain) : base(logger, repository, domain)
        {
        }

        [HttpGet]
        [Route("User/{id}")]
        public IEnumerable<DecisionDto> GetByUserId(long id)
        {
            return ((DecisionDomain)_domain).GetByUserId(id);
        }
    }
}
