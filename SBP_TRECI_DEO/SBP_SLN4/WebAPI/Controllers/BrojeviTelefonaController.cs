namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class BrojeviTelefonaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveBrojeveTelefona")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSveBrojeveTelefona()
    {
        var result = DataProvider.GetBrojInfos();

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpPost]
    [Route("DodajBrojTelefona")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajBrojTelefona([FromBody] BrojeviTelefonaView? p)
    {
        var data = await DataProvider.dodajBrojTelefona(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodat broj");
    }

    [HttpDelete]
    [Route("ObrisiBrojTelefona")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ObrisiBrojTelefona([FromBody] BrojeviTelefonaView? ob)
    {
        if (ob == null || ob.Id == null || ob.Id.Osoba == null)
        {
            return BadRequest("Invalid input data.");
        }

        var result = await DataProvider.DeleteBrojTelefona(ob);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok("Uspesno izbrisan broj telefona.");
    }
}