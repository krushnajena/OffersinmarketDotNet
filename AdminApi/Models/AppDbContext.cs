 using AdminApi.Models.Helper;
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

        public virtual DbSet<Cuisine> Cuisines { get; set; }

        public virtual DbSet<Store> Stores { get; set; }


        public virtual DbSet<StoreRatting> StoreRattings { get; set; }
        public virtual DbSet<Follower> Followers { get; set; }

        public virtual DbSet<RestaurantImage> RestaurantImages { get; set; }


        public virtual DbSet<Story> Stories { get; set; }


        public virtual DbSet<RestaurantPriceForTwo> RestaurantPriceForTwos { get; set; }

        public virtual DbSet<RestaurantCuisine> RestaurantCuisines { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<ProductImage> ProductImages{ get; set; }

        public virtual DbSet<ProductSpecification> ProductSpecifications { get; set; }


        public virtual DbSet<ViewCount> ViewCounts { get; set; }

        public virtual DbSet<Cart> Carts { get; set; }

        public virtual DbSet<PopularStore> PopularStores { get; set; }

        public virtual DbSet<AdsCredit> AdsCredits { get; set; }

        public virtual DbSet<Notification> Notifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 

            //Hospital

        
           modelBuilder.Entity<Category>()
            .Property(s => s.CreatedOn)
            .HasDefaultValueSql("getdate()");

           modelBuilder.Entity<Category>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();



            modelBuilder.Entity<StoreRatting>()
           .Property(s => s.CreatedOn)
          .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<StoreRatting>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Follower>()
           .Property(s => s.CreatedOn)
           .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Follower>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<State>()
           .Property(s => s.CreatedOn)
           .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<State>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<City>()
           .Property(s => s.CreatedOn)
           .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<City>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Area>()
        .Property(s => s.CreatedOn)
        .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Area>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Banner>()
       .Property(s => s.CreatedOn)
       .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Banner>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<Cuisine>()
      .Property(s => s.CreatedOn)
      .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Cuisine>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Store>()
    .Property(s => s.CreatedOn)
    .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Store>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();

            modelBuilder.Entity<Store>()
               .HasMany(c => c.StoreRattings)
               .WithOne(e => e.Store).IsRequired(false);


            modelBuilder.Entity<Store>()
             .HasMany(c => c.Followers)
             .WithOne(e => e.Store).IsRequired(false);

            modelBuilder.Entity<RestaurantImage>()
     .Property(s => s.CreatedOn)
     .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<RestaurantImage>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Store>()
          .HasMany(c => c.RestaurantImages)
          .WithOne(e => e.Store).IsRequired(false);

            modelBuilder.Entity<Story>()
   .Property(s => s.CreatedOn)
   .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Story>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<RestaurantPriceForTwo>()
   .Property(s => s.CreatedOn)
   .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<RestaurantPriceForTwo>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<RestaurantCuisine>()
   .Property(s => s.CreatedOn)
   .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<RestaurantCuisine>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Store>()
        .HasMany(c => c.RestaurantCuisines)
        .WithOne(e => e.Store).IsRequired(false);


            modelBuilder.Entity<Store>()
     .HasMany(c => c.RestaurantPriceForTwos)
     .WithOne(e => e.Store).IsRequired(false);



            modelBuilder.Entity<Product>()
  .Property(s => s.CreatedOn)
  .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<ProductImage>()
  .Property(s => s.CreatedOn)
  .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProductImage>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<ProductSpecification>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ProductSpecification>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Product>()
     .HasMany(c => c.ProductImages)
     .WithOne(e => e.Product).IsRequired(false);

            modelBuilder.Entity<Product>()
  .HasMany(c => c.ProductSpecifications)
  .WithOne(e => e.Product).IsRequired(false);


            modelBuilder.Entity<Store>()
.HasMany(c => c.Products)
.WithOne(e => e.Store).IsRequired(false);


            modelBuilder.Entity<Store>()
.HasMany(c => c.Stories)
.WithOne(e => e.Store).IsRequired(false);


            modelBuilder.Entity<ViewCount>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");

            modelBuilder.Entity<ViewCount>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<Cart>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");



            modelBuilder.Entity<Cart>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            modelBuilder.Entity<PopularStore>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");



            modelBuilder.Entity<PopularStore>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<Category>()
.HasMany(c => c.Stores)
.WithOne(e => e.Category).IsRequired(false);


            modelBuilder.Entity<AdsCredit>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");



            modelBuilder.Entity<AdsCredit>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();



            modelBuilder.Entity<Notification>()
.Property(s => s.CreatedOn)
.HasDefaultValueSql("getdate()");



            modelBuilder.Entity<Notification>()
             .Property(s => s.IsDeleted)
             .HasDefaultValue(false)
             .ValueGeneratedNever();


            #endregion
        }

    }
}
