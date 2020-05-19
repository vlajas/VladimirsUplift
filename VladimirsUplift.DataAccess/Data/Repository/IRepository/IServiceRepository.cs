using System;
using System.Collections.Generic;
using System.Text;
using VladimirsUplift.Models;

namespace VladimirsUplift.DataAccess.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        void Update(Service service);
    }
}
