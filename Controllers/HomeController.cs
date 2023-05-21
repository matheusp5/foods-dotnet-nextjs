using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Books.Models;
using Books.Repositories.Interfaces;

namespace Books.Controllers;

[Route("foods")]
public class HomeController : Controller
{
    private readonly IFoodsRepository _foodsRepository;

    public HomeController(IFoodsRepository foodsRepository)
    {
        this._foodsRepository = foodsRepository;
    }
    
    [HttpGet("getAll")]
    public List<Food> GetAll()
    {
        return this._foodsRepository.getAll();
    }
}
