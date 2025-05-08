namespace OpenClosed
{
    public class Standard : CardTypes
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95m;
        }
    }
}
