using Microsoft.AspNetCore.Mvc;

namespace Dotnet6EFCore.Controllers;

[ApiController]
[Route("[controller]")]
public class HumanController : ControllerBase
{
    private readonly ILogger<HumanController> _logger;
    private readonly EFCore6DBContext _dbcontext;

    public HumanController(ILogger<HumanController> logger,EFCore6DBContext dbcontext)
    {
        _logger = logger;
        _dbcontext = dbcontext;
    }

    [HttpGet(Name = "GetHuman")]
    public IEnumerable<Human> GetHuman()
    {
        return _dbcontext.Humans.AsEnumerable();
    }

    [HttpPost(Name = "PostHuman")]
    public IResult PostHuman(Human human)
    {
        _dbcontext.Humans.Add(human);
        _dbcontext.SaveChanges();
        return Results.Created($"/Human/{human.Id}", human);
    }
}
