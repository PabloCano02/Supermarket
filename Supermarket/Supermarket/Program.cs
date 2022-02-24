using Supermarket;

Console.WriteLine(" PRODUCTS");
Console.WriteLine(" -------------------------------------------------");
Product product1 = new FixedPriceProduct()
{
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};
Console.WriteLine(product1);
