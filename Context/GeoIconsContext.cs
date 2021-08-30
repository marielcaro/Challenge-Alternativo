﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeoApi.Entity;

namespace GeoApi.Context
{
    public class GeoIconsContext : DbContext
    {
        public GeoIconsContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Continent> Continets { get; set; } = null!;

        public DbSet<City> City { get; set; } = null!;

        public DbSet<GeographicIcon> GeographicIcons { get; set; } = null!;


    }
}
