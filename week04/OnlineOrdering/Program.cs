using System;

class Program
{   
    static void Main(string[] args)
    {
        Product product1 = new Product("Sunscreen", "45465", 15, 3);
        Product product2 = new Product("Facial Moisturizer", "83737", 47, 2);
        Product product3 = new Product("Hyaluronic Acid Serum", "83737", 400, 4);


        Address address1 = new Address("Paseo del cedro 68", "Toluca", "Mexico State", "Mexico");
        Customer customer1 = new Customer("Karina Torres", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.DisplayTotalPrice();
        


        Product product01 = new Product("Vitamin C Serum", "65748", 29.98, 5);
        Product product02 = new Product("Retinol Night Cream", "23432", 35.50, 4);
        Product product03 = new Product("Hydrating Toner", "78653", 17.75, 2);


        Address address2 = new Address("123 Maple Street", "Springfield", "Illinois", "USA");
        Customer customer2 = new Customer("Heather Ryder", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product01);
        order2.AddProduct(product02);
        order2.AddProduct(product03);
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        order2.DisplayTotalPrice();    


    }
}