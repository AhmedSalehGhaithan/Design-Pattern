using System.Collections.Generic;

namespace Decorator_Design_Pattern.OrderExample
{
    public class Order
    {
        private List<OrderLine> _lines = new List<OrderLine>();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddLine(int itemId, double quantity, decimal unitPrice)
        {
            _lines.Add(new OrderLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPrice });
        }
    }
}
