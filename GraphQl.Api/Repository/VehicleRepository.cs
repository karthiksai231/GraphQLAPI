using System.Collections.Generic;
using System.Linq;
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
            return await _datacontext.Vehicles.Where(x => x.UserId == id).ToListAsync();
        }

        public async Task<ILookup<int, Vehicle>> GetForUsers(IEnumerable<int> userIds) {
            var vehicles = await _datacontext.Vehicles.Where(
                v => userIds.Contains(v.UserId)).ToListAsync();
                var vehiclesToLookUp = vehicles.ToLookup(x => x.UserId);

                return vehiclesToLookUp;
        }
    }
}