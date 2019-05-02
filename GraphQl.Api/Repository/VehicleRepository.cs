using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQl.Api.Data;
using GraphQl.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.Api.Repository
{
    public class VehicleRepository
    {
        private readonly DataContext _datacontext;

        public VehicleRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<IEnumerable<Vehicle>> GetVehicleForUsersAsync(int id)
        {
            return await _datacontext.Vehicles.Include(x => x.UserId == id).ToListAsync();
        }
    }
}