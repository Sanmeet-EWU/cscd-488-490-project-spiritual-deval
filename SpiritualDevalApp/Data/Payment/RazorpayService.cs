using Razorpay.Api;
using System;

public class RazorpayService
{
    private const string _apiKey = "your_test_api_key"; //TODO - Replace with your Razorpay API key
    private const string _apiSecret = "your_test_api_secret"; //TODO - Replace with your Razorpay API secret

    public Order CreateOrder(decimal amount, string currency = "INR")
    {
        RazorpayClient client = new RazorpayClient(_apiKey, _apiSecret);

        var options = new Dictionary<string, object>
        {
            { "amount", (int)(amount * 100) }, // Amount in paise (₹100 = 10000)
            { "currency", currency },
            { "receipt", Guid.NewGuid().ToString() },
            { "payment_capture", 1 }
        };

        return client.Order.Create(options);
    }
}
