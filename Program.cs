using Satis_Platformasi.Enum;
using Satis_Platformasi.Model;
using System;

List<Product> products = new List<Product>
{
    new Product(1, "Laptop", 1500, 50, 30, ProductCategory.Electronics),
    new Product(2, "Smartphone", 700, 100, 70, ProductCategory.Electronics),
    new Product(3, "Headphones", 200, 200, 150, ProductCategory.Accessories),
    new Product(4, "Desk Chair", 100, 75, 50, ProductCategory.Furniture),
    new Product(5, "Bookshelf", 250, 30, 15, ProductCategory.Furniture),
    new Product(6, "Tablet", 350, 60, 40, ProductCategory.Electronics),
    new Product(7, "Gaming Headset", 120, 120, 100, ProductCategory.Accessories),
    new Product(8, "E-Reader", 130, 90, 60, ProductCategory.Electronics),
    new Product(9, "Coffee Table", 220, 45, 25, ProductCategory.Furniture),
    new Product(10, "Books", 15, 1000, 800, ProductCategory.Books)
};


List<Customer> customers = new List<Customer>()
{
    new Customer(1, "Ali", "Hüseynov", "ali.huseynov@gmail.com", "password123"),
    new Customer(2, "Leyla", "Abdullayeva", "leyla.abdullayeva@gmail.com", "leyla123"),
    new Customer(3, "Rəşad", "Məmmədov", "rashad.mammadov@gmail.com", "rashad456"),
    new Customer(4, "Nigar", "Əliyeva", "nigar.aliyeva@gmail.com", "nigar789"),
    new Customer(5, "Emin", "Quliyev", "emin.quliyev@gmail.com", "emin2023"),
    new Customer(6, "Zaur", "Əliyev", "zaur.aliyev@gmail.com", "zaur2024"),
    new Customer(7, "Aygün", "Həsənova", "aygun.hesenova@gmail.com", "aygun543"),
    new Customer(8, "Elvin", "Məmmədov", "elvin.mammadov@gmail.com", "elvin321"),
    new Customer(9, "Sevda", "Orucova", "sevda.orucova@gmail.com", "sevda654"),
    new Customer(10, "Kamal", "Rəhimov", "kamal.rahimov@gmail.com", "kamal890")
};

List<Order> orders = new List<Order>
{
    new Order(1, DateTime.Now, customers[0], products[0], 1),
    new Order(2, DateTime.Now, customers[1], products[1], 2),
    new Order(3, DateTime.Now, customers[2], products[2], 3),
    new Order(4, DateTime.Now, customers[3], products[3], 2),
    new Order(5, DateTime.Now, customers[4], products[5], 1),
    new Order(6, DateTime.Now, customers[5], products[7], 1),
    new Order(7, DateTime.Now, customers[6], products[4], 2),
    new Order(8, DateTime.Now, customers[7], products[6], 3),
    new Order(9, DateTime.Now, customers[8], products[8], 1),
    new Order(10, DateTime.Now, customers[9], products[9], 2)
};

