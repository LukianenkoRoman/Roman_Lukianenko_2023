using Microsoft.EntityFrameworkCore;
using Skeleton.DAL.Entities;

namespace Skeleton.DAL.Context
{
    public class SkeletonDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }         //DbSet for the User entity
        public DbSet<Test> Tests { get; set; }         //DbSet for the Test entity
        public DbSet<Question> Questions { get; set; }      //DbSet for the Question entity
        public DbSet<Answer> Answers { get; set; }          //DbSet for the Answer entity
    }
}
