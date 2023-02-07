﻿using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using AdminApi;
using AdminApi.Models;
using AdminApi.Models.App;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {     
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<State> States{ get; set; }
        public virtual DbSet<City> Cities{ get; set; }
        public virtual DbSet<Area> Areas { get; set; }

        public virtual DbSet<Banner> Banners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
            //modelBuilder.SeedOracle();//use this only for Oracle
            #region 

            //Hospital

           modelBuilder.Entity<Category>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

           modelBuilder.Entity<Category>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();


            modelBuilder.Entity<State>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<State>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<City>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<City>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Area>()
        .Property(s => s.CreatedOn)
        .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Area>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Banner>()
       .Property(s => s.CreatedOn)
       .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Banner>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            #endregion
        }

    }
}
