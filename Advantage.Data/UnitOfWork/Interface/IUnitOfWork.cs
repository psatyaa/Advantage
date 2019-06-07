using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Advantage.Data.UnitOfWork.Interface
{
   public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
