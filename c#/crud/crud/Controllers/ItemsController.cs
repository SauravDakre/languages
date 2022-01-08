using Microsoft.AspNetCore.Mvc;
using crud.Entities;
using crud.Repositories;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItem inMemItem;

        public ItemsController()
        {
            inMemItem = new InMemItem();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return inMemItem.GetItems();
        }
    }
}
