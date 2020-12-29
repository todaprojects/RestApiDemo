using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Services;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VegetableController : BaseItemController<Vegetable>
    {
        public VegetableController(IShopService<Vegetable> shopService) : base(shopService)
        {
        }
    }
}