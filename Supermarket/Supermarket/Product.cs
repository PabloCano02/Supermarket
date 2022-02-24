namespace Supermarket
{
    public abstract class Product
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"   {Id} {Description} " +
                $"\n\tPrice......:{$"{Price:C2}",13} " +
                $"\n\tTax........:{ $"{Tax:P2}",15} ";
        }
    }
}
