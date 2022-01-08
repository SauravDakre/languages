using crud.Entities;

namespace crud.Repositories
{
    public interface IItemsRepository{
        IEnumerable<Item> GetItems();
        Item GetItem(Guid id);
    }
}