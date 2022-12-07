using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DDDBackend.Models
{
    public class RestaurantModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public RestaurantModel(){}
    }
}