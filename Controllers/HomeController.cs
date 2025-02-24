using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Microsoft.Extensions.Logging;
using System.Net.Mail;
using System.Net;
using Library.Services;

namespace Library.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly EmailService _emailService;

    public HomeController(ILogger<HomeController> logger, EmailService emailService)
    {
        _logger = logger;
        _emailService = emailService;
    }

    public IActionResult Index()
    {
        return View(new EmailModel());
    }

    [HttpPost]
    public async Task<IActionResult> SendEmail(EmailModel model)
    {
        try
        {
            // Combine Topic and Detail into the message
            string fullMessage = $"Topic: {model.Topic}\n\nDetail: {model.Detail}\n\n{model.Message}";
            
            await _emailService.SendEmailAsync(model.ReceiverEmail, model.Subject, fullMessage);
            TempData["Message"] = "Email başarıyla gönderildi!";
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            TempData["Error"] = "Email gönderilirken hata oluştu: " + ex.Message;
            return View("Index", model);
        }
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
