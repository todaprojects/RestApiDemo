using Microsoft.AspNetCore.Mvc;
using RestApiDemo_WebApi.Models;
using RestApiDemo_WebApi.Services;

namespace RestApiDemo_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CookwareController : BaseItemController<Cookware>
    {
        public CookwareController(IShopService<Cookware> shopService) : base(shopService)
        {
        }
    }
}