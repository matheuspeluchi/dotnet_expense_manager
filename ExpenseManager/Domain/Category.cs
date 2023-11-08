using System.ComponentModel.DataAnnotations;

namespace ExpenseManager.domain
{
  public class Category
  {

    [Key]
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }

    public Category(int id, string title, string description)
    {
      this.id = id;
      this.title = title;
      this.description = description;
    }

    public override bool Equals(object? obj)
    {
      return obj is Category category &&
             title == category.title &&
             description == category.description;
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(title, description);
    }
  }
}
