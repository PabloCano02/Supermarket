﻿namespace Supermarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            return Price * (decimal)Quantity * (1 + (decimal)Tax);
        }

        public override string ToString()
        {
            return $"   {Id} {Description} " +
                $"\n\tMeasurement: {Measurement}" +
                $"\n\tQuantity...:{$"{Quantity:N2}",13} " +
                $"\n\tPrice......:{$"{Price:C2}",13} " +
                $"\n\tTax........:{ $"{Tax:P2}",15} " +
                $"\n\tValue......:{$"{ValueToPay():C2}",13} ";
        }
    }
}
