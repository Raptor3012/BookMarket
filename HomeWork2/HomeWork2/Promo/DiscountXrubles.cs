namespace HomeWork2
{
    class DiscountXrubles : IPromo
    {
        uint Xrubles = 0;

        public DiscountXrubles(uint xrubles)
        {
            this.Xrubles = xrubles;
        }

        public void ApplyPromo(Order order)
        {
            order.Discount += this.Xrubles;
        }
    }

}
