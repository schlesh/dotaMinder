using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotaMinder.Models;

namespace dotaMinder.Controllers;

public class RoshController : Controller
{
    public IActionResult Index()
        {
            return View();
        }

}

