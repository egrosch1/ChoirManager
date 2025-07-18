using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChoirManager.Models;

namespace ChoirManager.Controllers;

public class RehearsalPrepController(ILogger<RehearsalPrepController> logger) : Controller
{
    private readonly ILogger<RehearsalPrepController> _logger = logger;

    public IActionResult RehearsalPrep() 
    {
        return View();
    } 
     


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
