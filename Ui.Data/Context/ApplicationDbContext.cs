﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ui.Data.Entities;

namespace Ui.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //services.AddDbContext<ApplicationDbContext>(option =>{option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));});

        //"ConnectionStrings": {
        //"DefaultConnection": "data source=.;initial catalog=kzCoreData2; integrated security=true"
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }
        public DbSet<Product> Products { set; get; }
        public DbSet<CategoryName> CategoryNames { set; get; }
        public DbSet<ProductWithCategory> ProductWithCategorys { set; get; }
        public DbSet<Comment> Comments { set; get; }

    }
}
