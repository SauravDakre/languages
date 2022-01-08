using Microsoft.AspNetCore.Mvc;
using crud.Entities;
using crud.Repositories;
using crud.Dtos;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            return repository.GetItems().Select(item => item.AsDto());
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDto> getItem(Guid id){
            var item = repository.GetItem(id);
            if(item is null){
                return NotFound();
            }
            return item.AsDto();
        }

        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto item){
            Item newItem = new(){
                Id = Guid.NewGuid(),
                Name = item.Name,
                Price = item.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };
            repository.CreateItem(newItem);
            return CreatedAtAction(nameof(getItem), new {id = newItem.Id}, newItem.AsDto());
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(Guid id, UpdateItemDto item){
            var existingItem = repository.GetItem(id);
            if(existingItem is null){
                return NotFound();
            }
            var updatedItem = existingItem with 
            {
                Name = item.Name,
                Price = item.Price
            };
            repository.UpdateItem(updatedItem);
            return NoContent();
        }

        [HttpDelete]
        public ActionResult DeleteItem(Guid id){
            var existingItem = repository.GetItem(id);
            if(existingItem is null){
                return NotFound();
            }
            repository.DeleteItem(id);
            return NoContent();
        }
    }
}
