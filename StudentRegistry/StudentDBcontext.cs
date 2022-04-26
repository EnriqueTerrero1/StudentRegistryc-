﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace StudentRegistry
{
    public  class StudentDBcontext:DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-38S3DRNP\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}
