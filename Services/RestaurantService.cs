using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDBackend.Services.Context;

namespace DDDBackend.Services
{
    public class RestaurantService
    {
        private readonly DataContext _context;

        public RestaurantService(DataContext context)
        {
            _context = context;
        }
    }
}