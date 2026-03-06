
[Serializable]
public class Product
{
    public string Name { get; set; }
    public Category Category { get; set; }

    public Product(string name, Category category)
    {
        Name = name;
        Category = category;
    }

    public override string ToString()
    {
        return $"Producto: {Name}, Categoría: {Category.Name}";
    }

}
