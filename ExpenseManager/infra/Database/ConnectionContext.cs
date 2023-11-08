using ExpenseManager.domain;
using Microsoft.EntityFrameworkCore;


namespace ExpenseManager.Infra
{
  public class ConnectionContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder.UseNpgsql(
        "server=localhost;" +
        "Port=5432;Database=expense_manager;" +
        "User Id=root;" +
        "Password=khEEd932onv866;"
          ));
    }
  }
}
