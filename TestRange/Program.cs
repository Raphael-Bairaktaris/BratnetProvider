// See https://aka.ms/new-console-template for more information
using BratnetProvider;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

BuildString();

BuildStringBuilder();

var string1 = "LabrosRaphael";
var string2 = new StringBuilder().Append("Labros").Append("Raphael").ToString();

var isEqual = string1 == string2;

Console.WriteLine("Hello, World!");

//var invoiceType = InvoiceType.SalesInvoice;

//var s = BratnetProviderClientConstants.InvoiceTypeToStringMapper[invoiceType];

var currency1 = new CurrencyInfo()
{
    Code = "EUR",
    Name = "Euro",
    Symbol = "E"
};

var currency2 = new CurrencyInfo()
{
    Code = "EUR",
    Name = "Euro",
    Symbol = "E"
};

var areEqual = currency1 == currency2;


var client = new BratnetProviderClient("asdfgfgasvjxnsfgsifg324123");

var request = new InvoiceRequestModel()
{
    Taxes = new List<TaxRequestModel>()
    {
         new TaxRequestModel()
         {
              TaxAmount = 50,
              TaxCategory = VATCategory.VATRate9,
         },
         new TaxRequestModel()
         {
              TaxAmount = 50,
              TaxCategory = VATCategory.VATRate9,
         },
    },
    PaymentMethods = new List<PaymentMethodDetailDataModel>()
    {
        new PaymentMethodDetailDataModel()
        {
             Amount = 100,
             PaymentMethodInfo = "Μετρητα",
             Type = PaymentType.WebBanking
        }
    },
    InvoiceDetails = new List<InvoiceDetailRequestModel>()
    {
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_3,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
       new InvoiceDetailRequestModel()
       {
           Name = "Νερο",
           Quantity = 1,
           IncomeClassificationType = IncomeClassificationType.E3_106,
           IncomeClassificationCategory = IncomeClassificationCategory.Category1_2,
           IncomeClassificationAmount = 100
       },
    }
};

var dataModel = request.ToInvoiceDataModel();

var a = await client.SendInvoicesAsync(request);

var r = await client.SendInvoicesAsync(new InvoicesDataModel()
{
    Invoices = new List<InvoiceDataModel>()
    {
        new InvoiceDataModel()
        {
            InvoiceHeader = new InvoiceHeaderDataModel()
            {
                InvoiceType = InvoiceType.ProvisionOfServicesReceipt,
            },
            Counterpart = new CounterpartDataModel()
            {
                VATNumber = "123123123123"
            },
            Extras = new ExtrasDataModel()
            {
                 CustomerAddress = "Zakinthou 35 Patra"
            },
            InvoiceDetails = new List<InvoiceDetailDataModel>()
            {
                new InvoiceDetailDataModel()
                {
                    Name = "Νερο",
                    Quantity = 1,
                    LineNumber = 0,
                    IncomeClassifications = new List<IncomeClassificationDataModel>()
                    {
                         new IncomeClassificationDataModel()
                         {
                              IncomeClassificationType = IncomeClassificationType.E3_880_002,
                              IncomeClassificationCategory= IncomeClassificationCategory.Category1_3,
                              Amount = 100,
                         },
                    }
                },
                new InvoiceDetailDataModel()
                {
                    Name = "Νερο",
                    Quantity = 1,
                    LineNumber = 1,
                    IncomeClassifications = new List<IncomeClassificationDataModel>()
                    {
                         new IncomeClassificationDataModel()
                         {
                              IncomeClassificationType = IncomeClassificationType.E3_880_003,
                              IncomeClassificationCategory= IncomeClassificationCategory.Category1_3,
                              Amount = 100,
                              Id = 12
                         }
                    }
                },
                new InvoiceDetailDataModel()
                {
                    Name = "Νερο",
                    Quantity = 1,
                    LineNumber = 2,
                    IncomeClassifications = new List<IncomeClassificationDataModel>()
                    {
                         new IncomeClassificationDataModel()
                         {
                              IncomeClassificationType = IncomeClassificationType.E3_880_003,
                              IncomeClassificationCategory= IncomeClassificationCategory.Category1_2,
                              Amount = 100,
                         }
                    }
                }
            },
            TaxTotals = new TaxTotalsDataModel()
            {
                Taxes = new List<TaxDataModel>()
                {
                     new TaxDataModel()
                     {
                          TaxAmount = 50,
                          TaxCategory = VATCategory.VATRate9,
                          TaxId = 1,
                     },
                     new TaxDataModel()
                     {
                          TaxAmount = 50,
                          TaxCategory = VATCategory.VATRate9,
                          TaxId = 1,
                     },
                }
            },
            PaymentMethods = new PaymentMethodDetailsDataModel()
            {
                PaymentMethods = new List<PaymentMethodDetailDataModel>()
                {
                    new PaymentMethodDetailDataModel()
                    {
                         Amount = 100,
                         PaymentMethodInfo = "Μετρητα",
                         Type = PaymentType.WebBanking
                    }
                }
            },
            InvoiceSummary = new InvoiceSummaryDataModel()
            {
                TotalNetAmount = 300,
                 TotalGrossAmount = 300,
                 IncomeClassifications = new List<IncomeClassificationDataModel>()
                 {
                     new IncomeClassificationDataModel()
                     {
                          IncomeClassificationType = IncomeClassificationType.E3_880_002,
                          IncomeClassificationCategory= IncomeClassificationCategory.Category1_3,
                          Amount = 100
                     },
                     new IncomeClassificationDataModel()
                     {
                          IncomeClassificationType = IncomeClassificationType.E3_880_003,
                          IncomeClassificationCategory= IncomeClassificationCategory.Category1_3,
                          Amount = 100
                     },
                     new IncomeClassificationDataModel()
                     {
                          IncomeClassificationType = IncomeClassificationType.E3_880_003,
                          IncomeClassificationCategory= IncomeClassificationCategory.Category1_2,
                          Amount = 100
                     },
                 },
            }
        }
    }
});

if (!r.IsSuccessful)
{
    // Show error
    

    return;
}




var json = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Provider.json"));

var result = JsonConvert.DeserializeObject<InvoicesDataModel>(json, new JsonSerializerSettings()
{
    NullValueHandling = NullValueHandling.Ignore
});

//var json = await File.ReadAllTextAsync(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ISO4217.json"));

//var ob = JsonConvert.DeserializeObject<JObject>(json);

//var infos = new List<CurrencyInfo>();

//foreach (var item in ob!)
//{
//    var code = string.Empty;
//    var name = string.Empty;
//    var symbol = string.Empty;
//    foreach(var pair in (JObject)item.Value)
//    {
//        if (code == string.Empty)
//        {
//            code = pair.Value.ToString();

//            continue;
//        }

//        if (name == string.Empty) 
//        {
//            name = pair.Value.ToString();

//            continue;
//        }

//        symbol = pair.Value.ToString();
//    }
//    infos.Add(new CurrencyInfo()
//    {
//        Code = code,
//        Name = name,
//        Symbol = symbol
//    });
//}

//var sb = new StringBuilder();
//var i = 0;
//foreach(var info in infos)
//{
//    sb.AppendLine("/// <summary>");
//    sb.AppendLine($"/// {info.Name} ({info.Symbol})");
//    sb.AppendLine("/// </summary>");
//    sb.AppendLine($"{info.Code} = {i},");
//    sb.AppendLine();

//    i++;
//}

//var result = sb.ToString();

//var euro = CurrencyCode.EUR;

//var integer = (int)euro;

//var s = (CurrencyCode)integer;

Console.ReadLine();



void BuildString()
{
    var resultString = "test";

    resultString += "1";
    resultString += "2";
    resultString += "3";

    Console.WriteLine(resultString);
}

void BuildStringBuilder()
{
    var sb = new StringBuilder();

    sb.Append("test");
    sb.Append("1");
    sb.Append("2");
    sb.Append("3");

    var resultString = sb.ToString();

    Console.WriteLine(sb);
}

public class CurrencyInfo
{
    public required string Code { get; init; }

    public required string Name { get; init; }

    public required string Symbol { get; init; }

    public override bool Equals(object? obj)
    {
        if (obj is CurrencyInfo currencyInfo)
            return Code == currencyInfo.Code && Name == currencyInfo.Name && Symbol == currencyInfo.Symbol;

        return false;
    }

    //public static bool operator ==(object? first, object? second) => ReferenceEquals(first, second);

    //public static bool operator !=(object first, object second) => !ReferenceEquals(first, second);

}

