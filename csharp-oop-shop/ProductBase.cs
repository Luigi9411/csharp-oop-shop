
using System.Security.Cryptography;

public class Product
{
    public Product()
    {
        var random = new Random();
        Code = random.Next(1,957249);
    }

    public Product(int code)
    {
        Code = code;
    }

    public long Code { get; private set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public double Iva { get; set; }

    public double GetBasePrice()
    {
        return Price;
    }

    public double GetPriceWithIva()
    {
        return (Price + (Price * Iva / 100));
    }

    public string GetExtendedName()
    {
        return $"{GetPaddedCode()}-{Name}";
    }

    public string GetPaddedCode()
    {
        return Code.ToString().PadLeft(8, '0');
    }

}