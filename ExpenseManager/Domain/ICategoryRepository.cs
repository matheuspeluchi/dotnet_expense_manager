using ExpenseManager.domain;

namespace ExpenseManager.Domain
{
  public interface ICategoryRepository
  {
    Category findById(int categoryId);
    Category create(Category category);
    List<Category> findAll();
    Category update(Category category);
    void delete(int categoryId);


  }
}
