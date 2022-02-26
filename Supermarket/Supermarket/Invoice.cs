namespace Supermarket
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice ()
        {
            _products = new List<Product>();
        }

        public Product AddProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        public decimal ValueToPay()
        {
            decimal totalInvoice = 0;
            foreach (Product product in _products)
            {
                totalInvoice += product.ValueToPay();
            }
            return totalInvoice;
        }

        public override string ToString()
        {
            string invoicedProducts = "";
            foreach (Product product in _products)
            {
                invoicedProducts += product.ToString() + "\n";
            }
            return $" RECEIPT" +
                $"\n -------------------------------------------------\n" +
                $"{invoicedProducts}" +
                $"\t            =============" +
                $"\n TOTAL             :{$"{ValueToPay():C2}",13} ";
        }
    }
}
