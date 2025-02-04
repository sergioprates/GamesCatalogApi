﻿using GamesCatalogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesCatalogApi.Data
{
    public class GamesContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GamesContext(DbContextOptions<GamesContext> options) : base(options)
        {
        }
    }
}
