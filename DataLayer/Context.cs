﻿using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-OERL0I6O; Database=SocialMedia; Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Likes> Likes { get; set; }
    }
}
