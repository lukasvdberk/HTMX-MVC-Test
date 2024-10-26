using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HTMX_MVC_Test.Models;
using Htmx;

namespace HTMX_MVC_Test.Controllers;

public class HomeController : Controller
{
    private const int TimeToLoadMs = 2 * 1000; 
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [Route("/")]
    [HttpGet]
    public IActionResult Index()
    {
        // default view
        return View();
    }
    
    [Route("/")]
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        await Task.Delay(TimeToLoadMs);
        var formValues = new FormValueResult
        {
            Email = Request.Form["Email"],
            FirstName = Request.Form["FirstName"],
            LastName = Request.Form["LastName"]
        };
        
        return PartialView("_FormValues", formValues);
    }
}