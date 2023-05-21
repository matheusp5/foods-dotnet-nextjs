using Books.Models;

namespace Books.Repositories.Interfaces;

public interface IFoodsRepository
{
    List<Food> getAll();
}