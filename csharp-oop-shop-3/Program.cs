using csharp_shop_2;

Console.OutputEncoding = System.Text.Encoding. Unicode;

//GENERAZIONE PRODOTTI
Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");
Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);
sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });

//RICHIEDO IL NUMERO DI PRODOTTI GENERATI
Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

//AGGIUNGO I PRODOTTI AL CARRELLO
PhisicalShopCart mioCarrelloDellaSpesa = new PhisicalShopCart(20);
PhisicalShopCart mioCarrelloDellaSpesa2 = new PhisicalShopCart(20);
PhisicalShopCart mioCarrelloDellaSpesa3 = new PhisicalShopCart(20);
PhisicalShopCart mioCarrelloDellaSpesa4 = new PhisicalShopCart(20);
mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
mioCarrelloDellaSpesa.AddProduct(Limone);
mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);

//STAMPO IL NUMERO DI CARRELLI GENERATI
Console.WriteLine("Il numero di carrelli generati è: " + PhisicalShopCart.cartCounter);

//STAMPO I PRODOTTI
Console.WriteLine("STAMPIAMO IL CARRELLO");
Console.WriteLine(mioCarrelloDellaSpesa.ToString());










