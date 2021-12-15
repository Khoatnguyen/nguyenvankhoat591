using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nguyenvankhoat591.Models;

    public class MvcNVK591Context : DbContext
    {
        public MvcNVK591Context (DbContextOptions<MvcNVK591Context> options)
            : base(options)
        {
        }

        public DbSet<nguyenvankhoat591.Models.CompanyNVK591> CompanyNVK591 { get; set; }

        public DbSet<nguyenvankhoat591.Models.NVK0591> NVK0591 { get; set; }
    }
