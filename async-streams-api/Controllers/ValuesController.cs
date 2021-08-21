using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace async_streams_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IAsyncEnumerable<int> Get()
        {
            return GetNumberStreams();
        }

        private async IAsyncEnumerable<int> GetNumberStreams()
        {
            int index = 0;
            while (true)
                yield return index++;
        }
    }
}
