
//BONUS:
//), dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
//Buon lavoro!



Product id = new Product();
id.Name = "Biscotti Ringo";
id.Description = "Descrizione forse un giorno";
id.Price = 24;
id.Iva = 22;

Product id2 = new Product();
id2.Name = "Cioccolato Fondente";
id2.Description = "Una tavoletta di cioccolato fondente di alta qualità";
id2.Price = 5.50;
id2.Iva = 10;

Product id3 = new Product();
id3.Name = "T-shirt bianca";
id3.Description = "Una t-shirt bianca in cotone morbido";
id3.Price = 15;
id3.Iva = 22;

Product id4 = new Product();
id4.Name = "Scarpe da ginnastica";
id4.Description = "Scarpe da ginnastica leggere e comode";
id4.Price = 45;
id4.Iva = 22;

List<Product> productList = new List<Product>();
productList.Add(id);
productList.Add(id2);
productList.Add(id3);
productList.Add(id4);

foreach (Product p in productList)
{   
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Codice prodotto = " + p.GetPaddedCode());
Console.WriteLine(p.Name);
Console.WriteLine(p.Description);
Console.WriteLine("Iva italiana = " + p.Iva + "%");
Console.WriteLine("Prezzo = " + p.Price + "€");
Console.WriteLine("Prezzo con iva = " + p.GetPriceWithIva() + "€");
Console.WriteLine("Codice prodotto + nome = " + p.GetExtendedName());
Console.WriteLine();
}
Console.ReadLine();




