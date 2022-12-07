using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDDBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantService _data;

        public RestaurantController(RestaurantService dataFromService)
        {
            _data = dataFromService;
        }
    }
}