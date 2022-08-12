using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Views.Shared.Components
{
    public class CartSummaryViewComponent : ViewComponent // перенести в главноый класс
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
