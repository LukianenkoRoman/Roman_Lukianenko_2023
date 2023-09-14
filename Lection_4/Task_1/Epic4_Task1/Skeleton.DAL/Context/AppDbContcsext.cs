using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Skeleton.DAL.Context
{
    public class SkeletonDbContext : DbContext
    {
        public SkeletonDbContext(DbContextOptions<SkeletonDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }   
        public DbSet<Test> Tests { get; set; }       
        public DbSet<Question> Questions { get; set; }      
        public DbSet<Answer> Answers { get; set; }

    }
}
