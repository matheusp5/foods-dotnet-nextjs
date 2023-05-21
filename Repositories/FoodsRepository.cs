using Books.Models;
using Books.Repositories.Interfaces;

namespace Books.Repositories;

public class FoodsRepository : IFoodsRepository
{
    private List<Food> _foods = new List<Food>()
    {
        new() { Id = 1, Name = "Hamburguer", Description = "Good", Stars = 4},
        new() { Id = 2, Name = "Pizza", Description = "Good", Stars = 5},
        new() { Id = 3, Name = "Pasta", Description = "Good", Stars = 4},
    };

    public List<Food> getAll()
    {
        return this._foods;
    }
}