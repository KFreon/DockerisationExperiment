using Microsoft.EntityFrameworkCore;

public class YoloDbContext : DbContext
{
    public class Item
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int SwagAmount { get; set; }
    }

    public YoloDbContext(DbContextOptions<YoloDbContext> opts) : base(opts) { }

    public DbSet<Item> Yolo { get; set; }
}