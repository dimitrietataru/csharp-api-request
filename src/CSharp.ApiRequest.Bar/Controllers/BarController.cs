using CSharp.ApiRequest.Bar.Communications.Dtos;
using CSharp.ApiRequest.Bar.Communications.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CSharp.ApiRequest.Bar.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public sealed class BarController : ControllerBase
    {
        private readonly IApiRequest apiRequest;

        public BarController(IApiRequest apiRequest) => this.apiRequest = apiRequest;

        [HttpGet]
        [Route("api/v1/bar/get-with-response")]
        public async Task<IActionResult> GetWithResponse()
        {
            var result = await apiRequest.Foo.GetWithResponseAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("api/v1/bar/get-without-response")]
        public async Task<IActionResult> GetWithoutResponse()
        {
            await apiRequest.Foo.GetWithoutResponseAsync();

            return NoContent();
        }

        [HttpPost]
        [Route("api/v1/bar/post-with-body-and-with-response")]
        public async Task<IActionResult> PostWithBodyAndWithReponse([FromBody] RequestDto dto)
        {
            var result = await apiRequest.Foo.PostWithBodyAndWithReponseAsync(dto);

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/bar/post-with-body-and-without-response")]
        public async Task<IActionResult> PostWithBodyAndWithoutReponse([FromBody] RequestDto dto)
        {
            await apiRequest.Foo.PostWithBodyAndWithoutReponseAsync(dto);

            return NoContent();
        }

        [HttpPost]
        [Route("api/v1/bar/post-without-body-and-with-response")]
        public async Task<IActionResult> PostWithoutBodyAndWithReponse()
        {
            var result = await apiRequest.Foo.PostWithoutBodyAndWithReponseAsync();

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/bar/post-without-body-and-without-response")]
        public async Task<IActionResult> PostWithoutBodyAndWithoutReponse()
        {
            await apiRequest.Foo.PostWithoutBodyAndWithoutReponseAsync();

            return NoContent();
        }

        [HttpPut]
        [Route("api/v1/bar/put-with-body-and-with-response")]
        public async Task<IActionResult> PutWithBodyAndWithReponse([FromBody] RequestDto dto)
        {
            var result = await apiRequest.Foo.PutWithBodyAndWithReponseAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        [Route("api/v1/bar/put-with-body-and-without-response")]
        public async Task<IActionResult> PutWithBodyAndWithoutReponse([FromBody] RequestDto dto)
        {
            await apiRequest.Foo.PutWithBodyAndWithoutReponseAsync(dto);

            return NoContent();
        }

        [HttpPut]
        [Route("api/v1/bar/put-without-body-and-with-response")]
        public async Task<IActionResult> PutWithoutBodyAndWithReponse()
        {
            var result = await apiRequest.Foo.PutWithoutBodyAndWithReponseAsync();

            return Ok(result);
        }

        [HttpPut]
        [Route("api/v1/bar/put-without-body-and-without-response")]
        public async Task<IActionResult> PutWithoutBodyAndWithoutReponse()
        {
            await apiRequest.Foo.PutWithoutBodyAndWithoutReponseAsync();

            return NoContent();
        }

        [HttpPatch]
        [Route("api/v1/bar/patch-with-body-and-with-response")]
        public async Task<IActionResult> PatchWithBodyAndWithReponse([FromBody] RequestDto dto)
        {
            var result = await apiRequest.Foo.PatchWithBodyAndWithReponseAsync(dto);

            return Ok(result);
        }

        [HttpPatch]
        [Route("api/v1/bar/patch-with-body-and-without-response")]
        public async Task<IActionResult> PatchWithBodyAndWithoutReponse([FromBody] RequestDto dto)
        {
            await apiRequest.Foo.PatchWithBodyAndWithoutReponseAsync(dto);

            return NoContent();
        }

        [HttpPatch]
        [Route("api/v1/bar/patch-without-body-and-with-response")]
        public async Task<IActionResult> PatchWithoutBodyAndWithReponse()
        {
            var result = await apiRequest.Foo.PatchWithoutBodyAndWithReponseAsync();

            return Ok(result);
        }

        [HttpPatch]
        [Route("api/v1/bar/patch-without-body-and-without-response")]
        public async Task<IActionResult> PatchWithoutBodyAndWithoutReponse()
        {
            await apiRequest.Foo.PatchWithoutBodyAndWithoutReponseAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("api/v1/bar/delete-with-response")]
        public async Task<IActionResult> DeleteWithResponse()
        {
            var result = await apiRequest.Foo.DeleteWithResponseAsync();

            return Ok(result);
        }

        [HttpDelete]
        [Route("api/v1/bar/delete-without-response")]
        public async Task<IActionResult> DeleteWithoutResponse()
        {
            await apiRequest.Foo.DeleteWithoutResponseAsync();

            return NoContent();
        }
    }
}
