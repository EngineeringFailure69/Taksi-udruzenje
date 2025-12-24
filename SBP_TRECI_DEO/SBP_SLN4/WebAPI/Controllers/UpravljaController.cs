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

    [HttpPut]
    [Route("PromeniUpravljanje")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniUpravljanje([FromBody] UpravljaView? p)
    {
        (bool isError, var upravljanje, ErrorMessage? error) = await DataProvider.UpdateUpravlja(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (upravljanje == null)
        {
            return BadRequest("Upravljanje nije validno.");
        }

        return Ok($"Uspesno azurirano upravljanje");
    }

    [HttpGet]
    [Route("PreuzmiUpravljanje/{idupr}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiUpravljanje(int idupr)
    {
        (bool isError, var upravljanje, ErrorMessage? error) = DataProvider.GetUpravljanje(idupr);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(upravljanje);
    }

    [HttpGet]
    [Route("PreuzmiIstorijuUpravljanja/{idvoz}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiIstorijuUpravljanja(int idvoz)
    {
        (bool isError, var upravljanje, ErrorMessage? error) = DataProvider.GetIstorijaUpravlja(idvoz);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(upravljanje);
    }
}