using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Homework2_2
{

    class Product
    {
        string _productCategoryName;

        public Product(string productCategoryName)
        {
            _productCategoryName = productCategoryName;
        }

        public string ProductCategoryName { get { return _productCategoryName; }  }

    }

    class Buyer
    {
        string _buyerName;

        public Buyer(string buyerName)
        {
            _buyerName = buyerName;
            products = new List<Product>();
        }
        public string BuyerName { get { return _buyerName; } }


        public List<Product> products;

       

    }




    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Створіть колекцію, до якої можна додавати покупців та категорію придбаної ними продукції.
             * З колекції можна отримувати категорії товарів, які купив покупець 
             * або за категорією визначити покупців.
             */

            Product product1 = new Product("TV Set Samsung");
            Product product2 = new Product("Mouse Logitech");
            Product product3 = new Product("Keyboard Logitech");

            Buyer buyer1 = new Buyer("Amica");
            buyer1.products.Add(product1);
            buyer1.products.Add(product2);
            buyer1.products.Add(product3);
            buyer1.products.Add(product3);


            Buyer buyer2 = new Buyer("Stilantis");
            buyer2.products.Add(product1);
            buyer2.products.Add(product2);
            buyer2.products.Add(product3);




            ArrayList clients = new ArrayList();

            clients.Add(buyer1);
            clients.Add(buyer2);


            string searchValue = "Keyboard Logitech";

            SearchBuyerByProductCategory(clients, searchValue);

            searchValue = "Stilantis";

            SearchProductCategoryByBuyer(clients, searchValue);
            

            Console.ReadKey();
        }

        public static void SearchBuyerByProductCategory(ArrayList clients, string searchValue)
        {

            for (int i = 0; i < clients.Count; i++)
            {

                Buyer buyer = clients[i] as Buyer;


                foreach (Product product in buyer.products)
                {
                    if (product.ProductCategoryName == searchValue)
                    {
                        Console.WriteLine(buyer.BuyerName);
                        break;
                    }
                }



            }

        }

        public static void SearchProductCategoryByBuyer(ArrayList clients, string searchValue)
        {

            foreach (Buyer buyer in clients)
            {
                if (buyer.BuyerName == searchValue)
                {
                    Console.WriteLine(buyer.BuyerName);
                    IEnumerable<Product> products = from p in buyer.products
                                                    select p;

                    foreach (Product product in products)
                        Console.WriteLine(product.ProductCategoryName);
                }
            }

            

        }

    }
}
