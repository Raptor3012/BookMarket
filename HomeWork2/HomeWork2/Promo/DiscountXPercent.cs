using System;

namespace HomeWork2
{
    class DiscountXPercent : IPromo
    {
        uint Xpercent = 0;

        public DiscountXPercent(uint Xpercent)
        {
            this.Xpercent = Xpercent;
        }

        public void ApplyPromo(Cart cart)
        {
            cart.CostWithDiscounts -= Math.Round(cart.Cost / 100.0 * this.Xpercent);
        }
    }
}
