using ECommerceApplication.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using Repository;
using Repository.Implementation;
using Services;
using Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services
    .AddRefitClient<ProductsWebApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(builder.Configuration.GetSection("ProductPartnerIntegration:clientBaseUrl").Value));

builder.Services.AddScoped<IRepositorySupportTicket, RepositorySupportTicket>();
builder.Services.AddScoped<ISupportTicketService, SupportTicketService>();
builder.Services.AddScoped<ILogger<SupportTicketAnalysisController>, Logger<SupportTicketAnalysisController>>();

builder.Services.AddScoped<IRepositorySeasonalSales , RepositorySeasonalSales>();
builder.Services.AddScoped<ISeasonalSalesService, SeasonalSalesService>();
builder.Services.AddScoped<ILogger<SeasonalSalesAnalysisController>, Logger<SeasonalSalesAnalysisController>>();

builder.Services.AddScoped<IRepositoryLoyalty, RepositoryLoyalty>();
builder.Services.AddScoped<ILoyaltyService, LoyaltyService>();
builder.Services.AddScoped<ILogger<LoyaltyAnalysisController>, Logger<LoyaltyAnalysisController>>();

builder.Services.AddScoped<IPartnerService, PartnerService>();
builder.Services.AddScoped<ILogger<PartnerController>, Logger<PartnerController>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
