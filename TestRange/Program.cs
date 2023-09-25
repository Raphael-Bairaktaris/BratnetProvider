// See https://aka.ms/new-console-template for more information
using BratnetProvider;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

Console.WriteLine("Hello, World!");

var json = await File.ReadAllTextAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ISO4217.json"));

var ob = JsonConvert.DeserializeObject<JObject>(json);

var infos = new List<CurrencyInfo>();

foreach (var item in ob!)
{
    var code = string.Empty;
    var name = string.Empty;
    var symbol = string.Empty;
    foreach(var pair in (JObject)item.Value)
    {
        if (code == string.Empty)
        {
            code = pair.Value.ToString();

            continue;
        }

        if (name == string.Empty) 
        {
            name = pair.Value.ToString();

            continue;
        }

        symbol = pair.Value.ToString();
    }
    infos.Add(new CurrencyInfo()
    {
        Code = code,
        Name = name,
        Symbol = symbol
    });
}

var sb = new StringBuilder();
var i = 0;
foreach(var info in infos)
{
    sb.AppendLine("/// <summary>");
    sb.AppendLine($"/// {info.Name} ({info.Symbol})");
    sb.AppendLine("/// </summary>");
    sb.AppendLine($"{info.Code} = {i},");
    sb.AppendLine();

    i++;
}

var result = sb.ToString();

var euro = CurrencyCode.EUR;

var integer = (int)euro;

var s = (CurrencyCode)integer;

Console.ReadLine();



public record class CurrencyInfo
{
    public required string Code { get; init; }

    public required string Name { get; init; }

    public required string Symbol { get; init; }
}