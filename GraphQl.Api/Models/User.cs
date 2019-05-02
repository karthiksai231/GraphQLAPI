using System;
using System.Collections.Generic;

namespace GraphQl.Api.Models
{
    public class User
    {
        public int Id { get; set; }       
        public string UserName { get; set; }   
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}