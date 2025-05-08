using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{


    public class Silver : CardTypes
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .9m;
        }
    }

    public class Gold : CardTypes
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85m;
        }
    }

    public class Premium : CardTypes
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .8m;
        }
    }


    public class Customer
    {
        public CardTypes CardType { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal DiscountedPrice(decimal price) {
            //switch (Customer.CardType)
            //{
            //    case CardTypes.Standard:
            //        return price * .95m;
            //    case CardTypes.Silver:

            //        return price * .9m;
            //    case CardTypes.Gold:

            //        return price * .85m;
            //    default:
            //        return price;
            //}

            return Customer.CardType.GetDiscountedPrice(price);

        }
    }
}
