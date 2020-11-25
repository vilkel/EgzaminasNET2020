using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EgzaminasSVS.Models;

namespace EgzaminasSVS.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<EgzaminasSVS.Models.StorageClient> StorageClient { get; set; }

        public DbSet<EgzaminasSVS.Models.StorageItem> StorageItem { get; set; }
        public DbSet<EgzaminasSVS.Models.ClientItem> ClientItem { get; set; }
    }
}
