using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: customer in the USA
        Address address1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jordan Lee", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Water Bottle", "P100", 12.50, 2));
        order1.AddProduct(new Product("Backpack", "P101", 45.00, 1));
        order1.AddProduct(new Product("Notebook", "P102", 3.75, 4));

        // Order 2: customer outside the USA
        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Amara Chen", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Headphones", "P200", 60.00, 1));
        order2.AddProduct(new Product("Phone Case", "P201", 15.25, 2));

        Order[] orders = { order1, order2 };

        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine($"----- Order {orderNumber} -----");

            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"Total Price: {order.GetTotalPrice():C}");
            Console.WriteLine();

            orderNumber++;
        }
    }
}