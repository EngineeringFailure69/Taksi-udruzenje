namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VoziloController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSvaVozila")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSvaVozila()
    {
        (bool isError, var vozila, ErrorMessage? error) = DataProvider.GetVoziloInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(vozila);
    }

    [HttpGet]
    [Route("PreuzmiVoziloMarka/{marka}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiVoziloMarka(string marka)
    {
        (bool isError, var vozilo, ErrorMessage? error) = DataProvider.GetVoziloMarka(marka);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(vozilo);
    }   
}