using ExpenseManager.domain;
using ExpenseManager.Domain;

namespace ExpenseManager.Infra.Persistence
{
  public class CategoryRepository : ICategoryRepository
  {
    private readonly ConnectionContext context = new ConnectionContext();
    public Category create(Category category)
    {
      context.Categories.Add(category);
      context.SaveChanges();
      return category;
    }

    public void delete(int categoryId)
    {
      context.Categories.Remove(findById(categoryId));
    }

    public List<Category> findAll()
    {
      return context.Categories.ToList();
    }

    public Category findById(int categoryId)
    {
      return context.Categories.Find(categoryId);
    }

    public Category update(Category category)
    {
      context.Categories.Update(category);
      return context.Categories.Find(category.id);
    }
  }
}
