using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace statsgetter
{

    [Route("api/[controller]")]
    [ApiController]
    public class statsController : ControllerBase
    {
        private readonly statsProcessor _stats;

        public statsController(statsProcessor stats){
            _stats = stats;
        }


        [HttpGet]
        [Route("{name}")]
        public Task<string> GetStats(string name){
            return _stats.GetStats(name);
        }
    }
}