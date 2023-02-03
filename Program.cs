// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.AddAzureAppConfiguration(Environment.GetEnvironmentVariable("AzureAppConfig"));

var config = builder.Build();
Console.WriteLine(config["AzureAppConfiguration:ConnectionString:SQL"] ?? "Hello world!");