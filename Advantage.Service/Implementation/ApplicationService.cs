using Advantage.Data.UnitOfWork.Interface;
using Advantage.Domain.Model;
using Advantage.Repository.Interface;
using Advantage.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advantage.Service.Implementation
{
    public class ApplicationService : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ApplicationService(IApplicationRepository applicationRepository, IUnitOfWork unitOfWork)
        {
            _applicationRepository = applicationRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Application>> ListAsync()
        {
            return await _applicationRepository.ListAsync();
        }

        public async Task<Application> ListByIdAsync(int id)
        {
            return await _applicationRepository.ListByIdAsync(id);
        }
    }
}
