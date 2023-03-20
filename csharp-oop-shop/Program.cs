
//BONUS:
//-create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
//-Usando una List(occhio! è una novità: chiedete a 
//@Paolo Mistretta
//), dichiarate una lista dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
//Buon lavoro!

Product id = new Product(code:4324);
id.Name = "Biscotti Ringo";
id.Description = "Descrizione forse un giorno";
id.Price = 24;
id.Iva = 22;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Codice prodotto = " + id.GetPaddedCode());
Console.WriteLine(id.Name);
Console.WriteLine(id.Description);
Console.WriteLine("Iva italiana = " + id.Iva);
Console.WriteLine("Prezzo = " + id.Price + "€");
Console.WriteLine("Prezzo con iva = " + id.GetPriceWithIva() + "€");
Console.WriteLine("Codice prodotto + nome = " + id.GetExtendedName());

