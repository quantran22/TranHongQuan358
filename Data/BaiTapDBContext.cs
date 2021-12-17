using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoDotNetMVC.Models;
using TranHongQuan358.Models;

    public class BaiTapDBContext : DbContext
    {
        public BaiTapDBContext (DbContextOptions<BaiTapDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoDotNetMVC.Models.UniversityTHQ358> UniversityTHQ358 { get; set; }

        public DbSet<TranHongQuan358.Models.THQ358> THQ358 { get; set; }
    }
