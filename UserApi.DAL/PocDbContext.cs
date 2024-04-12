namespace UserApi.DAL;

public class PocDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<createLeaveTypeCommand> LeaveTypes { get; set; }

    public PocDbContext(DbContextOptions option) : base(option) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>(entity =>
        {
           
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

         
            entity.HasKey(e => e.UserID);

            entity.ToTable("Users");
        });

        base.OnModelCreating(modelBuilder);
    }
}