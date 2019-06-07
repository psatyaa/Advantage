using Advantage.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advantage.Repository.Interface
{
   public interface IApplicationRepository
    {
        Task<IEnumerable<Application>> ListAsync();
        Task<Application> ListByIdAsync(int id);
    }
}
