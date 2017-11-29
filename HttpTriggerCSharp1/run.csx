#r "Newtonsoft.Json"

using System.Net;
using Newtonsoft.Json;

public class Order
{
    public string OrderId{get;set;}
    public string Email{get;set;}
    public decimal Price{get;set;}
}
public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log,IAsyncCollector<Order> outputQueueItem)
{
    log.Info($"Order Received");
    string jsonContent =await req.Content.ReadAsStringAsync();
    var order = JsonConvert.DeserializeObject<Order>(jsonContent);
  log.Info("Order "+order.OrderId+" received");
    await outputQueueItem.AddAsync(order);

    return  req.CreateResponse(HttpStatusCode.OK, $"Thank you for your order!");
}
