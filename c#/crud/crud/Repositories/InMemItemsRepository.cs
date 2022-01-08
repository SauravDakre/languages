using crud.Entities;

namespace crud.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new(){
            new Item {Id = Guid.NewGuid(), Name="a", Price=10, CreatedDate=DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name="b", Price=15, CreatedDate=DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems(){
            return items;
        }

        public Item GetItem(Guid id){
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item){
            items.Add(item);
        }

        public void UpdateItem(Item item){
            var index =  items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
        }

        public void DeleteItem(Guid id){
            var index =  items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
        }
    }
}
