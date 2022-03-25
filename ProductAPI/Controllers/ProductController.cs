using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Service;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IOfferService _offerService;
        public ProductController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public List<Offer> GetTodaysOffer()
        {
            return _offerService.GetToDaysOffer();
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _offerService.GetProducts().OrderBy(x=>x.Price).Take(3).ToList();
        }

        [HttpGet]
        public List<Product> GetSecondProduct()
        {
            return _offerService.GetProducts().OrderBy(x => x.Price).Take(2).ToList();
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _offerService.SaveProduct(product);
        }
    }
}
