namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ZaposleniController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveZaposlene")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSveZaposlene()
    {
        (bool isError, var zaposleni, ErrorMessage? error) = DataProvider.GetZaposleniInfos();

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(zaposleni);
    }

    [HttpPost]
    [Route("DodajZaposlenog")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajZaposlenog([FromBody] ZaposleniView? p)
    {
        p.Tip_Osobe = "Zaposleni";
        var data = await DataProvider.dodajZaposlenog(p);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return StatusCode(201, $"Uspesno dodat zaposleni");
    }

    [HttpPut]
    [Route("PromeniZaposlenog")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> PromeniZaposlenog([FromBody] ZaposleniView? z)
    {
        var data = await DataProvider.UpdateZaposleni(z);

        if (data.IsError)
        {
            return StatusCode(data.Error.StatusCode, data.Error.Message);
        }

        return Ok($"Uspesno azuriran zaposleni");
    }

    [HttpGet]
    [Route("PreuzmiZaposlenog/{idzap}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiZaposlenog(int idzap)
    {
        (bool isError, var zaposleni, ErrorMessage? error) = DataProvider.GetZaposleni(idzap);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(zaposleni);
    }

    [HttpGet]
    [Route("PreuzmiZaposlenogIme/{imeZap}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiZaposlenogIme(string imeZap)
    {
        (bool isError, var zaposleni, ErrorMessage? error) = DataProvider.GetZaposleniIme(imeZap);

        if (isError)
        {
            return StatusCode(error?.StatusCode ?? 400, error?.Message);
        }

        return Ok(zaposleni);
    }
}