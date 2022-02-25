namespace Supermarket
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal costOfProducts = 0;
            foreach (Product product in Products)
            {
                costOfProducts += product.ValueToPay() * (1 + (decimal)Tax) * (1 - (decimal)Discount);
            }
            return costOfProducts;
        }

        public override string ToString()
        {
            string productsList = "";
            foreach (Product product in Products)
            {
                productsList += product.Description + ", ";

            }
            return $"   {Id} {Description} " +
                $"\n\tProducts...: {productsList.Remove(productsList.Length - 2)} " +
                $"\n\tDiscount...:{$"{Discount:P2}",15} " +
                $"\n\tValue......:{$"{ValueToPay():C2}",13} ";
        }
    }
}
