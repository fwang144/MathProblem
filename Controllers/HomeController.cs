using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MathProblem.Models;


namespace MathProblem.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        
        if (HttpContext.Session.GetInt32("right") == null)
        {        
    
            HttpContext.Session.SetInt32("right", 0);
            HttpContext.Session.SetInt32("wrong", 0);

        }

        TempData["right"] = (int) HttpContext.Session.GetInt32("right");
        TempData["wrong"] = (int) HttpContext.Session.GetInt32("wrong");

        
        return View();
    }

    public IActionResult Addition()
    {
        Random rand = new Random();

        int prob1 = rand.Next(10);
        int prob2 = rand.Next(10);

  
        TempData["prob1"] = prob1;
        HttpContext.Session.SetInt32("prob1" , prob1);
        TempData["prob2"] = prob2;
        HttpContext.Session.SetInt32("prob2" , prob2);
        return View();
    }

    public IActionResult Subtraction()
    {
        Random rand = new Random();

        int prob1 = rand.Next(10);
        int prob2 = rand.Next(10);

  
        TempData["prob1"] = prob1;
        HttpContext.Session.SetInt32("prob1" , prob1);
        TempData["prob2"] = prob2;
        HttpContext.Session.SetInt32("prob2" , prob2);
        return View();
    }

    [HttpPost]
    public IActionResult answer(int answer, string mode)
    {
        if (mode == "add")
        {
            int resultAdd = (int)HttpContext.Session.GetInt32("prob1") + (int)HttpContext.Session.GetInt32("prob2");
            if (resultAdd != answer)
            {
                int wrong = (int)HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", wrong);

                        TempData["prob1"] = (int)HttpContext.Session.GetInt32("prob1");
                        TempData["prob2"] = (int)HttpContext.Session.GetInt32("prob2");

                return View("Addition");

            }
            else{

                int right = (int)HttpContext.Session.GetInt32("right");
                right++;
                HttpContext.Session.SetInt32("right", right);


            }
        }
        else if (mode == "subtract")
        {
            int resultAdd = (int)HttpContext.Session.GetInt32("prob1") - (int)HttpContext.Session.GetInt32("prob2");
            if (resultAdd != answer)
            {
                int wrong = (int)HttpContext.Session.GetInt32("wrong");
                wrong++;
                HttpContext.Session.SetInt32("wrong", wrong);

                        TempData["prob1"] = (int)HttpContext.Session.GetInt32("prob1");
                        TempData["prob2"] = (int)HttpContext.Session.GetInt32("prob2");

                return View("Subtraction");

            }
            else{

                int right = (int)HttpContext.Session.GetInt32("right");
                right++;
                HttpContext.Session.SetInt32("right", right);


            }
        }

        return Redirect("/");

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
