using Microsoft.EntityFrameworkCore;
using SkillsTest.Models;

namespace SkillsTest.Data
{
    public class SkillsTestContext : DbContext
    {
        public SkillsTestContext(DbContextOptions<SkillsTestContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
