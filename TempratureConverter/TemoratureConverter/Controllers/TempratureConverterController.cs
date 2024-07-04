using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TempratureConverter.Interface;

namespace TempratureConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempratureConverterController : ControllerBase
    {
        private readonly ITemprature _temprature;
        public TempratureConverterController(ITemprature temprature)
        {
            _temprature = temprature;
        }

        [HttpGet("ConvertToCelcius")]
        public IActionResult ConvertToCelcius(int temp)
        {
            try
            {
                var result = _temprature.ConvertToCelcius(temp);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet("ConvertToFarenheit")]
        public IActionResult ConvertToFarenhiet(int temp)
        {
            try
            {
                var result = _temprature.ConvertToFahrenheit(temp);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
