using Bacon.Ipsum.API.Client;
using Bacon.Ipsum.API.Client.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBaconIpsumApiClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/text-generator/paragraph/", (IBaconIpsumApiClient client, int paragraphs) =>
{
    return client.TextGenerator.GenerateParagraphAsync(paragraphs);
})
.WithName("GenerateParagraph");

app.MapGet("/text-generator/setence/", (IBaconIpsumApiClient client, int sentences) =>
{
    return client.TextGenerator.GenerateSentenceAsync(sentences);
})
.WithName("GenerateSetence");

app.Run();
