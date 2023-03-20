﻿
public class Product
{
    public Product(long code)
    {
        this.Code = code;
    }

    public long Code { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
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
        return $"{Code}-{Name}";
    }


}