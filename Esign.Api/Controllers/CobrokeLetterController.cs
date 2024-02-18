using Esigning.Service;
using Microsoft.AspNetCore.Mvc;

namespace Esigning.Api.Controllers
{
    [Route("api/esign/cobroke-Letters")]
    [ApiController]
    public class CobrokeLetterController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateCobrokeLetter([FromBody] CreateCobrokeLetterRequest request)
        {
            //驗證請求參數
            var validator = new CreateCobrokeLetterRequestValidator();
            var validateResult = validator.Validate(request);

            if (!validateResult.IsValid)
            {
                return BadRequest(validateResult.Errors);
            }

            //TODO: 使用Service建立同業合作契約

            var response = new CreateCobrokeLetterResponse
            {
                Message = $"Successfully Create Cobroke Letter."
            };

            return Ok(response);
        }
    }
}
