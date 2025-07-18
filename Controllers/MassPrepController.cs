using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;

namespace ChoirManager.Controllers;

public class MassPrepController(ILogger<MassPrepController> logger) : Controller
{
    private readonly ILogger<MassPrepController> _logger = logger;

    public IActionResult MassPrep() 
    {
        return View();
    } 
     


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
