using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advantage.Schema.Interface
{
    public interface IApplicationSchema
    {
        void CreateTable(ModelBuilder modelBuilder);
    }
}
