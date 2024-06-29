using DataBaseFirstDemo.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace DataBaseFirstDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly AccessManagementDBContext _accessManagementDBContext;
        public HomeController(AccessManagementDBContext accessManagementDBContext)
        {
            _accessManagementDBContext = accessManagementDBContext;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            var card = _accessManagementDBContext.TableCards.ToList();
            return Ok(card);
        }
    }
}
