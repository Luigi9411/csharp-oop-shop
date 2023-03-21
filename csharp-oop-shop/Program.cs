
//BONUS:
//), dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
//Buon lavoro!

Product id = new Product();
id.Name = "Biscotti Ringo";
id.Description = "Descrizione forse un giorno";
id.Price = 24;
id.Iva = 22;



Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Codice prodotto = " + id.GetPaddedCode());
Console.WriteLine(id.Name);
Console.WriteLine(id.Description);
Console.WriteLine("Iva italiana = " + id.Iva + "%");
Console.WriteLine("Prezzo = " + id.Price + "€");
Console.WriteLine("Prezzo con iva = " + id.GetPriceWithIva() + "€");
Console.WriteLine("Codice prodotto + nome = " + id.GetExtendedName());
Console.ReadLine();

