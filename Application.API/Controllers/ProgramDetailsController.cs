using Application.Application.Dtos.Request;
using Application.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProgramDetailsController : ControllerBase
    {
        private readonly IProgramDetailService _detailService;

        public ProgramDetailsController(IProgramDetailService detailService)
        {
            _detailService = detailService;
        }

        [HttpPost("[action]", Name = "CreateProgramDetails")]
        public async Task<IActionResult> CreateProgramDetails(ProgramRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _detailService.CreateProgramDetails(request);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {

                return BadRequest(ex.Message);
            }
            catch(Exception)
            {
                return StatusCode(500, "An Error occured we are working on it");
            }
        }
    }
}
