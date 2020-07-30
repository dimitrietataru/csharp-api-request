using CSharp.ApiRequest.Foo.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CSharp.ApiRequest.Foo.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public sealed class FooController : ControllerBase
    {
        [HttpGet]
        [Route("api/v1/foo/get-with-response")]
        public IActionResult GetWithResponse()
        {
            var result = new ResponseDto("GET", "[Foo API] Requested GET with response");

            return Ok(result);
        }

        [HttpGet]
        [Route("api/v1/foo/get-without-response")]
        public IActionResult GetWithoutResponse()
        {
            return NoContent();
        }

        [HttpPost]
        [Route("api/v1/foo/post-with-body-and-with-response")]
        public IActionResult PostWithBodyAndWithReponse([FromBody] RequestDto _)
        {
            var result = new ResponseDto("POST", "[Foo API] Requested POST with body and with response");

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/foo/post-with-body-and-without-response")]
        public IActionResult PostWithBodyAndWithoutReponse([FromBody] RequestDto _)
        {
            return NoContent();
        }

        [HttpPost]
        [Route("api/v1/foo/post-without-body-and-with-response")]
        public IActionResult PostWithoutBodyAndWithReponse()
        {
            var result = new ResponseDto("POST", "[Foo API] Requested POST without body and with response");

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/foo/post-without-body-and-without-response")]
        public IActionResult PostWithoutBodyAndWithoutReponse()
        {
            return NoContent();
        }

        [HttpPut]
        [Route("api/v1/foo/put-with-body-and-with-response")]
        public IActionResult PutWithBodyAndWithReponse([FromBody] RequestDto _)
        {
            var result = new ResponseDto("PUT", "[Foo API] Requested PUT with body and with response");

            return Ok(result);
        }

        [HttpPut]
        [Route("api/v1/foo/put-with-body-and-without-response")]
        public IActionResult PutWithBodyAndWithoutReponse([FromBody] RequestDto _)
        {
            return NoContent();
        }

        [HttpPut]
        [Route("api/v1/foo/put-without-body-and-with-response")]
        public IActionResult PutWithoutBodyAndWithReponse()
        {
            var result = new ResponseDto("PUT", "[Foo API] Requested PUT without body and with response");

            return Ok(result);
        }

        [HttpPut]
        [Route("api/v1/foo/put-without-body-and-without-response")]
        public IActionResult PutWithoutBodyAndWithoutReponse()
        {
            return NoContent();
        }

        [HttpPatch]
        [Route("api/v1/foo/patch-with-body-and-with-response")]
        public IActionResult PatchWithBodyAndWithReponse([FromBody] RequestDto _)
        {
            var result = new ResponseDto("PATCH", "[Foo API] Requested PATCH with body and with response");

            return Ok(result);
        }

        [HttpPatch]
        [Route("api/v1/foo/patch-with-body-and-without-response")]
        public IActionResult PatchWithBodyAndWithoutReponse([FromBody] RequestDto _)
        {
            return NoContent();
        }

        [HttpPatch]
        [Route("api/v1/foo/patch-without-body-and-with-response")]
        public IActionResult PatchWithoutBodyAndWithReponse()
        {
            var result = new ResponseDto("PATCH", "[Foo API] Requested PATCH without body and with response");

            return Ok(result);
        }

        [HttpPatch]
        [Route("api/v1/foo/patch-without-body-and-without-response")]
        public IActionResult PatchWithoutBodyAndWithoutReponse()
        {
            return NoContent();
        }

        [HttpDelete]
        [Route("api/v1/foo/delete-with-response")]
        public IActionResult DeleteWithResponse()
        {
            var result = new ResponseDto("DELETE", "[Foo API] Requested DELETE with response");

            return Ok(result);
        }

        [HttpDelete]
        [Route("api/v1/foo/delete-without-response")]
        public IActionResult DeleteWithoutResponse()
        {
            return NoContent();
        }
    }
}
