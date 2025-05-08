namespace OpenClosed
{
    //public enum CardTypes
    // {
    //     Standard,
    //     Silver,
    //     Gold,
    //     Premium

    // }

    public abstract class CardTypes
    {
        public abstract decimal GetDiscountedPrice(decimal price);
       
    }
}
