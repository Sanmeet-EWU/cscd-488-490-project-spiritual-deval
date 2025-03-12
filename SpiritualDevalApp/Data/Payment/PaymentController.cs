using Microsoft.AspNetCore.Mvc;
using Razorpay.Api;

[Route("api/payment")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly RazorpayService _razorpayService;

    public PaymentController(RazorpayService razorpayService)
    {
        _razorpayService = razorpayService;
    }

    [HttpGet("createorder")]
    public IActionResult CreateOrder()
    {
        var order = _razorpayService.CreateOrder(100); // ₹100 example
        return Ok(order["id"].ToString());
    }
}
