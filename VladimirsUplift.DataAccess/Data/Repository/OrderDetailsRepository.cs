using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VladimirsUplift.DataAccess.Data.Repository.IRepository;
using VladimirsUplift.Models;

namespace VladimirsUplift.DataAccess.Data.Repository
{
   public class OrderDetailsRepository : Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       
    }
}
