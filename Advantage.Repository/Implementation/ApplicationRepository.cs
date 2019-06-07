using Advantage.Data.Context;
using Advantage.Domain.Model;
using Advantage.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advantage.Repository.Implementation
{
    public class ApplicationRepository : BaseRepository, IApplicationRepository
    {
        public ApplicationRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Application>> ListAsync()
        {
            return await _context.Applications.ToListAsync();
        }

        public async Task<Application> ListByIdAsync(int id)
        {
            return await _context.Applications.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
