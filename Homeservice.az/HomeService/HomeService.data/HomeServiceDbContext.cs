using HomeService.core.Models;
using HomeService.data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.data
{
   public class HomeServiceDbContext:IdentityDbContext<AppUser>
    {
        public HomeServiceDbContext(DbContextOptions<HomeServiceDbContext> options):base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<LanguageAdnvantage> LanguageAdnvantages { get; set; }
        public DbSet<LanguageSetting> LanguageSettings { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceLanguage> ServiceLanguages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentLanguage> CommentLanguages { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CostLanguage> CostLanguages { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionLanguage> positionLanguages { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<BlogLanguage> BlogLanguages { get; set; }
        public DbSet<SeoDescription> SeoDescriptions { get; set; }
        public DbSet<SeoTag> SeoTags { get; set; }
        public DbSet<SeoKeyword> SeoKeywords { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SettingConfiguration());
            modelBuilder.ApplyConfiguration(new AdvantageConfiguration());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
