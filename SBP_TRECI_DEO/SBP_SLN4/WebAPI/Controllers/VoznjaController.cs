namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class VoznjaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiVoznje")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiVoznje()
    {
        (bool isError, var voznje, ErrorMessage? error) = DataProvider.GetVoznjaInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(voznje);
    }

    [HttpPost]
    [Route("DodajVoznju")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajVoznju([FromBody] VoznjaView p)
    {
        var data = await DataProvider.dodajVoznju(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodata voznja");
    }

    [HttpPut]
    [Route("PromeniVoznju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniVoznju([FromBody] VoznjaView p)
    {
        (bool isError, var voznja, ErrorMessage? error) = await DataProvider.UpdateVoznja(p);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        if (voznja == null)
        {
            return BadRequest("Voznja nije validna.");
        }

        return Ok($"Uspesno azurirana voznja");
    }

    [HttpDelete]
    [Route("IzbrisiVoznju/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> IzbrisiVoznju(int id)
    {
        var data = await DataProvider.obrisiVoznju(id);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(204, $"Uspesno obrisana voznja");
    }

    [HttpGet]
    [Route("PreuzmiVoznju/{idvoznja}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiVoznju(int idvoznja)
    {
        var voznja = DataProvider.GetVoznja(idvoznja);
        if (voznja==null)
        {
            return BadRequest("Voznja ne postoji.");
        }

        return Ok(voznja);
    }
}