﻿using Keyyum.Models;
using System.Data.Entity;


namespace Keyyum.DAL
{
    public class KeyyumDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public KeyyumDbContext()
            : base("DefaultConnection")
        {

        }
    }
}
