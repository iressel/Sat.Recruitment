using Microsoft.EntityFrameworkCore;
using Sat.Recruitment.Model.DB.Tables;
using Sat.Recruitment.Model.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.Model.DB
{
    public class RecruitmentDB : DbContext
    {
        public RecruitmentDB(DbContextOptions<RecruitmentDB> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
