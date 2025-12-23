namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UpravljaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSvaUpravljanja")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSvaUpravljanja()
    {
        (bool isError, var upravljanja, ErrorMessage? error) = DataProvider.GetUprInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(upravljanja);
    }

    [HttpPost]
    [Route("DodajUpravljanje")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajUpravljanje([FromBody] UpravljaView? u)
    {
        var data = await DataProvider.dodajUpravljanje(u);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodato upravljanje");
    }
}