using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PassWord_Generator.ALL;

namespace PassWord_Generator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PassGeneratorController : ControllerBase
{
    [HttpPost]
    [Route("Generate")]
    public ActionResult<string> Generate(PassModel PassModel)
    {
        if (PassModel.Length > 0)
        {
            var passHash = PassGenerator.CreatePassword(PassModel);
            if (passHash != null)
            {
                return passHash;
            }
        }

        return "Something Wrong Happen";
    }
}