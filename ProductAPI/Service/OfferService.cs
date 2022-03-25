using ProductAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Service
{
    public class OfferService : IOfferService
    {

        private readonly List<Product> _products;

        public OfferService()
        {
            _products = Inventory();
        }
        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Offer> GetToDaysOffer()
        {
            List<Offer> offers = new List<Offer>();
            Offer offer1 = new Offer("ComboPackage1", _products.TakeWhile(i => i.Price % 2 == 0).ToList());
            Offer offer2 = new Offer("ComboPackage2", _products.TakeWhile(i => i.Price % 2 == 1).ToList());
            Offer offer3 = new Offer("ComboPackage3", _products.TakeWhile(i => i.Price % 3 == 0).ToList());
            Offer offer4 = new Offer("ComboPackage4", _products.TakeWhile(i => i.Price % 3 == 1).ToList());

            offers.Add(offer1);
            offers.Add(offer2);
            offers.Add(offer3);
            offers.Add(offer4);

            return offers;
        }

        public Product SaveProduct(Product product)
        {
            _products.Add(product);
            return product;
        }

        private List<Product> Inventory()
        {
            List<Product> products = new List<Product>();
            Product product1 = new Product("P1", 1000, "P1 desc");
            products.Add(product1);
            Product product2 = new Product("P2", 200, "P2 desc");
            products.Add(product2);
            Product product3 = new Product("P3", 400, "P3 desc");
            products.Add(product3);
            Product product4 = new Product("P4", 700, "P4 desc");
            products.Add(product4);
            Product product5 = new Product("P5", 600, "P5 desc");
            products.Add(product5);
            Product product6 = new Product("P6", 800, "P6 desc");
            products.Add(product6);

            return products;
        }
    }
}
