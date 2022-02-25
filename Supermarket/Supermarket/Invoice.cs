namespace Supermarket
{
    public class Invoice : IPay
    {
        private string _products;

        public Invoice(string products)
        {
            _products = products;
        }
        
        
        //public Product AddProduct (Product product)
        //{

        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //public decimal valuetopay()
        //{
        //    throw new notimplementedexception();
        //}
    }
}
