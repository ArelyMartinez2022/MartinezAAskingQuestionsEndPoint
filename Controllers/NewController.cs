using Microsoft.AspNetCore.Mvc;

namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{

    [HttpGet]
    [Route("Asking")]
    //localHost9000/Input/Name
    public string AskingQuestions()
    {
        return "WHAT IS YOUR NAME? \nWHAT TIME DID YOU WAKE UP?";
    }

    [HttpGet]
    [Route("Asking/{name}/{time}")]
    //localHost9000/Input/Name
    public string AskingQuestions(string name, string time)
    {
        return$"Whats up {name}, you woke up at {time} !";
    }

    //return$"This would be my return {var} "
}