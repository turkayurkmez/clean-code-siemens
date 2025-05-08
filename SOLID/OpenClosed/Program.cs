// See https://aka.ms/new-console-template for more information
using OpenClosed;

Console.WriteLine("Hello, World!");
//(Varolan) Bir nesne ........gelişime........... açık .....değişime....... kapalı olmalı.
Customer customer = new Customer() { CardType = new Premium()};
OrderManagement orderManagement = new OrderManagement();
orderManagement.Customer = customer;

Console.WriteLine( orderManagement.DiscountedPrice(1000));

