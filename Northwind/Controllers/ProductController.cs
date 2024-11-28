using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult GetAll()
        {
            var result = _productService.GetAll();

            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            _productService.Add(product);

            return RedirectToAction("GetAll");
        }
    }
}
