namespace Supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal GetValueToPay()
        {
            return Price * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return $"{base.ToString()} " +
                $"\n\tValue......:{$"{GetValueToPay():C2}",13} ";
        }
    }
}
