/*
ARELY MARTINEZ 

OCT 25, 2022 11:23AM 

ASKING QUESTION ENDPOINT

THIS PROGRAM WILL MAKE IT SO THAT THE USER CAN INPUT THE TIME THEY WOKE UP AND THIER NAME. THEY WOULD INPUT THROUGH POSTMAN LIKE OUTPUT: https://localhost:7119/input/asking/arely/3PM OUTPUT: Whats up arely, you woke up at 3pm 

PEER REVIEW: Pedro Castaneda -- Arely did a great job setting up her Endpoints. The route() is properly named. I think you should try adding validation to see if you can get the user to input the correct data type. Other than that your code is clean and you did a great job!

*/
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