// See https://aka.ms/new-console-template for more information
using DiffancyAssignment.Dto;
using DiffancyAssignment.Services;
using CsvHelper;
using System.Globalization;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

var serviceProvider = SetupDI();

var _mapper = serviceProvider.GetRequiredService<IMapper>();
var result = new List<OutputDto>();
using (var _client = new HttpClient())
using (var reader = new StreamReader("Annex.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var records = csv.GetRecords<InputDto>().ToList();
    foreach (var record in records)
    {
        var leiRecord = await _client.GetAsync<LeiRecord>($"https://api.gleif.org/api/v1/lei-records?filter[lei]={record.lei}");
        var output = _mapper.Map<OutputDto>(record);
        var data = leiRecord.data.First();
        output.legalName = data.attributes.entity.legalName;
        output.legalAddress = data.attributes.entity.legalAddress;
        output.bic = data.attributes.bic;
        result.Add(output);
    }
}

static ServiceProvider SetupDI() => new ServiceCollection()
    .AddAutoMapper(typeof(Program).Assembly)
    .AddLogging()
    .BuildServiceProvider();

Console.WriteLine(Serializer.JsonSerialize(result));