using ProductAPI.Models;
using System.Collections.Generic;

namespace ProductAPI.Service
{
    public interface IOfferService
    {
        List<Product> GetProducts();
        List<Offer> GetToDaysOffer();
        Product SaveProduct(Product product);
    }
}
