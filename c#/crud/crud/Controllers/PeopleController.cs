using Microsoft.AspNetCore.Mvc;
using crud.Entities;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {

        public readonly List<People> peoples;

        public PeopleController(){
            peoples = new List<People>();   
            peoples.Add(new People(1, 1, "a"));
            peoples.Add(new People(2, 1, "b"));
        }

        [HttpGet]
        public List<People> Get()
        {
            return peoples;
        }
    }
}