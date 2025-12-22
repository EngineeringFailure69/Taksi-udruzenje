namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MusterijaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveMusterije")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSveMusterije()
    {
        (bool isError, var musterije, ErrorMessage? error) = DataProvider.GetMusterijaInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(musterije);
    }

    [HttpPost]
    [Route("DodajMusteriju")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajMusteriju([FromBody] MusterijaView? p)
    {
        p.Tip_Osobe = "Musterija";
        var data = await DataProvider.dodajMusteriju(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodata musterija");
    }

    [HttpGet]
    [Route("PreuzmiMusteriju/{idmus}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiMusteriju(int idmus)
    {
        (bool isError, var zaposleni, ErrorMessage? error) = DataProvider.GetMusterija(idmus);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(zaposleni);
    }
}