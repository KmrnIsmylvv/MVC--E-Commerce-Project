﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC__E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC__E_Commerce_Project.DAL
{
    public class Context : IdentityDbContext<AppUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<CompanySlider> CompanySliders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandCategory> BrandCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductRelation> ProductRelations { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPhoto> BlogPhotos { get; set; }
        public DbSet<Comments> Comment { get; set; }
        public DbSet<HomeProductSlider> HomeProductSliders{ get; set; }
        public DbSet<Sales> Sales{ get; set; }
        public DbSet<SalesProduct> SalesProducts{ get; set; }





        public IEnumerable<object> CategoryBrands { get; internal set; }
    }
}
