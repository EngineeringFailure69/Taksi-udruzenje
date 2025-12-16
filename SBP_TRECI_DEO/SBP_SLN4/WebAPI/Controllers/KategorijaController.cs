namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class KategorijaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveKategorije")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public IActionResult PreuzmiSveKategorije()
    {
        var result = DataProvider.GetKategorijeInfos();

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok(result.Data);
    }

    [HttpPost]
    [Route("DodajKategoriju")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> DodajKategoriju([FromBody]KategorijaView? ob)
    {
        if (ob == null)
        {
            return BadRequest("Input object is null.");
        }

        var result = await DataProvider.dodajKategoriju(ob);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return StatusCode(201, "Uspesno dodata kategorija.");
    }

    [HttpDelete]
    [Route("ObrisiKategoriju")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> ObrisiKategoriju([FromBody] KategorijaView? ob)
    {
        if (ob == null || ob.Id == null || ob.Id.Zaposleni == null || string.IsNullOrEmpty(ob.Id.Kategorija))
        {
            return BadRequest("Invalid input data.");
        }

        var result = await DataProvider.DeleteKategorija(ob);

        if (result.IsError)
        {
            return StatusCode(result.Error.StatusCode, result.Error.Message);
        }

        return Ok("Uspesno izbrisana kategorija.");
    }
}