using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQl.Api.Data;
using GraphQl.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.Api.Repository
{
    public class UserRepository
    {
        private readonly DataContext _datacontext;

        public UserRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _datacontext.Users.ToListAsync();
        }
    }
}