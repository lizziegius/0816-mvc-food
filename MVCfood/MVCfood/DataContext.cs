﻿using System.Data.Entity;

namespace MVCfood
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVCfood.Models.Food> Foods { get; set; }
    }
}