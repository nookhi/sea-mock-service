using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using CoreWCF.Channels;
using Services;
using CoreWCF.Configuration;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Добавляем поддержку CoreWCF
builder.Services.AddServiceModelServices();

var app = builder.Build();

// Регистрируем SOAP-эндпоинт с поддержкой SOAP 1.1
app.UseServiceModel(builder =>
{
    builder.AddService<DocumentService>();
    builder.AddServiceEndpoint<DocumentService, IDocumentService>(
        new CustomBinding(
            new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8),
            new HttpTransportBindingElement()),
        "/DocumentService.svc");
});

app.Run();