namespace P01Customer
{
    using System;
    using System.Collections.Generic;

    public class CustomerMain
    {
        public static void Main()
        {
            List<Payment> payments = new List<Payment>()
            {
                new Payment("product1", 55.93),
                new Payment("product2", 103.37)
            };

            Customer customer = new Customer(
                "Peshkz",
                "Goshkov",
                "Ivanov",
                9112162821,
                "Adres",
                "peshko@goshkov.com",
                "0888888888",
                payments,
                CustomerType.Golden);

            Customer customer2 = new Customer(
                "Peshko",
                "Goshkov",
                "Ivanov",
                9112162820,
                "Adres",
                "peshko@goshkov.com",
                "0888888888",
                payments,
                CustomerType.Golden);

            Console.WriteLine(customer.CompareTo(customer2));
        }
    }
}
