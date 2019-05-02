using System.Collections.Generic;
using GraphQl.Api.Models;
using GraphQl.Api.Repository;
using Newtonsoft.Json;

namespace GraphQl.Api.Data
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedUsers()
        {
            var userData = System.IO.File.ReadAllText("Data/UserSeed.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);

            foreach (var user in users)
            {
                _context.Add(user);
            }

            _context.SaveChanges();
        }
    }
}