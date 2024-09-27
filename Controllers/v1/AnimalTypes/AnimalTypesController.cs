using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farm_API.data;
using Microsoft.AspNetCore.Mvc;

namespace Farm_API.Controllers.v1.AnimalTypes
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AnimalTypesController : ControllerBase
    {
        private readonly ApplicationDbContext Context;

        public AnimalTypesController(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}