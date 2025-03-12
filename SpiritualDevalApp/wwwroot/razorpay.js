function launchRazorpay(orderId) {
    var options = {
        "key": "your_test_api_key", 
        "amount": 10000, // Example: ₹100 in paise
        "currency": "INR",
        "name": "Your Business Name",
        "description": "Test Transaction",
        "order_id": orderId,
        "handler": function (response) {
            alert('Payment Successful! Payment ID: ' + response.razorpay_payment_id);
        },
        "prefill": {
            "name": "Test User",
            "email": "test@example.com",
            "contact": "9999999999"
        },
        "theme": {
            "color": "#3399cc"
        }
    };

    var rzp1 = new Razorpay(options);
    rzp1.open();
}
