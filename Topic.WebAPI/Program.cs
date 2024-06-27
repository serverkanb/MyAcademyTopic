using Topic.DataAccessLayer.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<TopicContext>();//her istek �a�r�s�nda yeni bir nesne olu�turuyor
builder.Services.AddSingleton<TopicContext>();//
builder.Services.AddTransient<TopicContext>();//Transientler her �a�r�l��ta tekrar bidaha olu�turuyor

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
