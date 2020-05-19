﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VladimirsUplift.DataAccess.Data.Repository.IRepository;
using VladimirsUplift.Models;

namespace VladimirsUplift.DataAccess.Data.Repository
{
   public class ServiceRepository : Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _db;
        public ServiceRepository(ApplicationDbContext db) :  base(db)
        {
            _db = db;
        }
        

        public void Update(Service service)
        {
            var objFromDb = _db.Service.FirstOrDefault(s => s.Id == service.Id);
            objFromDb.Name = service.Name;
            objFromDb.Price = service.Price;
            objFromDb.LongDesc = service.LongDesc;
            objFromDb.ImageUrl = service.ImageUrl;
            objFromDb.CategoryId = service.CategoryId;
            objFromDb.FrequencyId = service.FrequencyId;
            _db.SaveChanges();
        }
    }
}
