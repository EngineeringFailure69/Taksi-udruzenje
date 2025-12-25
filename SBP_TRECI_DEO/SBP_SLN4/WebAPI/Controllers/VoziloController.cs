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

    [HttpPost]
    [Route("DodajVozilo")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajVozilo([FromBody] VoziloView? p)
    {
        var data = await DataProvider.dodajVozilo(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodato vozilo");
    }

    [HttpPut]
    [Route("PromeniVozilo")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniVozilo([FromBody] VoziloView? v)
    {
        (bool isError, var vozilo, ErrorMessage? error) = await DataProvider.UpdateVozilo(v);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (vozilo == null)
        {
            return BadRequest("Vozilo nije validno.");
        }

        return Ok($"Uspesno azurirano vozilo");
    }

    [HttpGet]
    [Route("PreuzmiVozilo/{idvoz}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiVozilo(int idvoz)
    {
        (bool isError, var upravljanje, ErrorMessage? error) = DataProvider.GetVozilo(idvoz);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(upravljanje);
    }
}