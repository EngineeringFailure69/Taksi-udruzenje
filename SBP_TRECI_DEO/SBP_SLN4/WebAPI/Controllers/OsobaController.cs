namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OsobaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveOsobe")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSveOsobe()
    {
        (bool isError, var osobe, ErrorMessage? error) = DataProvider.GetOsobaInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(osobe);
    }

    [HttpPut]
    [Route("PromeniOsobu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniOsobu([FromBody] OsobaView? p)
    {
        (bool isError, var osoba, ErrorMessage? error) = await DataProvider.UpdateOsoba(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (osoba == null)
        {
            return BadRequest("Osoba nije validna.");
        }

        return Ok($"Uspesno azurirana osoba");
    }
}