namespace DesignPatterns.OpenClosedPrinciple;

public class Product
{
    public string Name { get; set; }
    public Color Color { get; set; }
    public Size Size { get; set; }

    public Product(string name, Color color, Size size)
    {
        if (name == null) throw new ArgumentNullException("name");
        Name = name;
        Color = color;
        Size = size;
    }
}
