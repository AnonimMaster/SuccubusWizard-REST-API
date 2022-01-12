﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SuccubusWizard_REST_API.Models
{
	public class IncubusContext : DbContext
	{
        public DbSet<Incubus> IncubusList { get; set; }
        public IncubusContext(DbContextOptions<IncubusContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
