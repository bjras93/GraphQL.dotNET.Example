using MindworkingTest.Application.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services
    .AddExternalServices()
    .AddServices(configuration);

var app = builder.Build();

app.UseWebSockets();
app.UseGraphQL();
app.UseGraphQLGraphiQL();

app.Run();
