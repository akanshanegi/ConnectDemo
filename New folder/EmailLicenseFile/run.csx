using System.Text.RegularExpressions;

public static void Run(string myBlob, string filename, TraceWriter log)
{
    var email = Regex.Match(myBlob,@"^Email\:\ (.+)$",RegexOptions.Multiline).Groups[1].Value;
    log.Info($"Got order from {email}\n License file Name:{filename}");
}
