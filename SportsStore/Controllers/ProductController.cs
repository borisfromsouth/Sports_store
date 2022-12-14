using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repo) // при использовании интерфейса создается новый объект репозитории, он далее и используется 
        {
            repository = repo;
        }

        //public ViewResult List(int productPage = 1) => View(repository.Products.OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize));
        public ViewResult List(string category, int productPage = 1) => View(new ProductsListViewModel
        {
            Products = repository.Products.Where(p => category == null || p.Category == category).OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo()
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? repository.Products.Count() : repository.Products.Where(e => e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}
