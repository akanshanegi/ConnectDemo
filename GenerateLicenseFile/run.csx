using System;

public class Order
{
    public string OrderId{get;set;}
    public string Email{get;set;}
    public decimal Price{get;set;}
}

public static void Run(Order myQueueItem, TraceWriter log,TextWriter outputBlob)
{
    log.Info($"C# Queue trigger function processed: {myQueueItem.OrderId}");
    outputBlob.WriteLine($"OrderId:{myQueueItem.OrderId}");
    outputBlob.WriteLine($"OrderId:{myQueueItem.Email}");

}
