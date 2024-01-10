using MiniChallengeTwoToFour___Endpoints.Services.Compare;
using MiniChallengeTwoToFour___Endpoints.Services.name;
using MiniChallengeTwoToFour___Endpoints.Services.Sum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISumService, SumService>();
builder.Services.AddScoped<INameService, NameService>();
builder.Services.AddScoped<ICompareService, CompareService>();

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
